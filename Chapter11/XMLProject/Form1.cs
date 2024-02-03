using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Designer
{
    public partial class Form1 : Form
    {
        List<Rose> roses = new List<Rose>();
        Rose SelectedRose = null;
        Boolean dragging;
        Point startDragPoint;

        string filename = "";

        public Form1()
        {
            InitializeComponent();
        }

        #region Методы

        Rose GetItemAt(int x, int y)
        {
            foreach (Rose currRose in roses)
            {
                if (
                    currRose.X < x && 
                    currRose.X + currRose.Width > x && 
                    currRose.Y < y && 
                    currRose.Y + currRose.Height > y 
                    )
                    return currRose;
            }
            return null;
        }

        void DrawDraggingShape()
        {
            Point point = designerPanel.PointToScreen(SelectedRose.Location);
            ControlPaint.DrawReversibleFrame(new Rectangle(point, SelectedRose.Size), SystemColors.ButtonFace, FrameStyle.Dashed);
        }

        #endregion

        #region События меню


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roses.Clear();
            filename = "";
            designerPanel.Invalidate();
        }

        private void добавитьРозуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rose rose = new Rose("Роза " + roses.Count.ToString(), 0, 0);
            roses.Add(rose);
            designerPanel.Invalidate();
        }

        private void designerPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rose rose in roses)
                rose.Draw(e.Graphics);
        }

        private void designerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Rose rose = GetItemAt(e.X, e.Y);
            if (rose != null)
            {
                SelectedRose = rose;
                dragging = true;
                startDragPoint = e.Location;
                DrawDraggingShape();
            }
        }

        private void designerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
                DrawDraggingShape();
                designerPanel.Invalidate();
            }
        }

        private void designerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                DrawDraggingShape();
                SelectedRose.X = SelectedRose.Location.X + (e.Location.X - startDragPoint.X);
                SelectedRose.Y = SelectedRose.Location.Y + (e.Location.Y - startDragPoint.Y);
                DrawDraggingShape();
                startDragPoint = e.Location;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
                сохранитьКакToolStripMenuItem_Click(null, null);
            else
                SaveProject();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "XML files|*.xml";
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            filename = fileDialog.FileName;
            SaveProject();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML files|*.xml";
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            OpenProject(fileDialog.FileName);
        }

        #endregion

        #region Функции загрузки-сохранения

        void SaveProject()
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlTextWriter xmlOut = new XmlTextWriter(fs, Encoding.Unicode);

            xmlOut.Formatting = Formatting.Indented;

            xmlOut.WriteStartDocument();
            xmlOut.WriteComment("Этот файл создан для примера");
            xmlOut.WriteComment("Автор: Михаил Фленов (www.flenov.info)");

            xmlOut.WriteStartElement("RosesPlant");
            xmlOut.WriteAttributeString("Version", "1");

            foreach (Rose item in roses)
                item.SaveToFile(xmlOut);

            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();
            xmlOut.Close();
            fs.Close();
        }

        void OpenProject(string newFilename)
        {
            новыйToolStripMenuItem_Click(null, null);

            FileStream fs = new FileStream(newFilename, FileMode.Open);
            XmlTextReader xmlIn = new XmlTextReader(fs);
            xmlIn.WhitespaceHandling = WhitespaceHandling.None;
            xmlIn.MoveToContent();

            if (xmlIn.Name != "RosesPlant")
                throw new ArgumentException("Incorrect file format.");
            string version = xmlIn.GetAttribute(0);

            do
            {
                if (!xmlIn.Read())
                    throw new ArgumentException("Ошибочка");


                if ((xmlIn.NodeType == XmlNodeType.EndElement) && 
                    (xmlIn.Name == "RosesPlant"))
                    break;

                if (xmlIn.NodeType == XmlNodeType.EndElement)
                    continue;

                if (xmlIn.Name == "Rose")
                {
                    Rose newItem = new Rose("", 0, 0);
                    roses.Add(newItem);
                    newItem.LoadFromFile(xmlIn);
                }
            } while (!xmlIn.EOF);

            xmlIn.Close();
            fs.Close();

            filename = newFilename;
            designerPanel.Invalidate();
        }

        #endregion
    }
}
