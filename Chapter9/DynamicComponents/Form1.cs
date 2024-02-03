using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicComponents
{
    public partial class Form1 : Form
    {
        Boolean dragging;
        Point startDragPoint;

        public Form1()
        {
            InitializeComponent();
        }

        #region события компонентов

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            if (control != null)
            {
                dragging = true;
                startDragPoint = e.Location;
            }
        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
                designerPanel.Invalidate();
            }
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                ((Control)sender).Left = ((Control)sender).Location.X + (e.Location.X - startDragPoint.X);
                ((Control)sender).Top = ((Control)sender).Location.Y + (e.Location.Y - startDragPoint.Y);
            }
        }

        #endregion

        #region события формы

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designerPanel.Controls.Clear();
        }

        private void добавитьПанельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Left= 0;
            panel.Top = 0;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.MouseDown += control_MouseDown;
            panel.MouseUp += control_MouseUp;
            panel.MouseMove += control_MouseMove;
            designerPanel.Controls.Add(panel);
        }

        private void добавитьКнопкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button panel = new Button();
            panel.Left = 0;
            panel.Top = 0;
            panel.MouseDown += control_MouseDown;
            panel.MouseUp += control_MouseUp;
            panel.MouseMove += control_MouseMove;
            designerPanel.Controls.Add(panel);
        }

        #endregion
    }
}
