namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFirstNameButton = new System.Windows.Forms.Button();
            this.changeLastNameButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ageChangedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(74, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // changeFirstNameButton
            // 
            this.changeFirstNameButton.Location = new System.Drawing.Point(307, 10);
            this.changeFirstNameButton.Name = "changeFirstNameButton";
            this.changeFirstNameButton.Size = new System.Drawing.Size(75, 23);
            this.changeFirstNameButton.TabIndex = 2;
            this.changeFirstNameButton.Text = "Изменить";
            this.changeFirstNameButton.UseVisualStyleBackColor = true;
            this.changeFirstNameButton.Click += new System.EventHandler(this.changeFirstNameButton_Click);
            // 
            // changeLastNameButton
            // 
            this.changeLastNameButton.Location = new System.Drawing.Point(307, 36);
            this.changeLastNameButton.Name = "changeLastNameButton";
            this.changeLastNameButton.Size = new System.Drawing.Size(75, 23);
            this.changeLastNameButton.TabIndex = 5;
            this.changeLastNameButton.Text = "Изменить";
            this.changeLastNameButton.UseVisualStyleBackColor = true;
            this.changeLastNameButton.Click += new System.EventHandler(this.changeLastNameButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(74, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // ageChangedButton
            // 
            this.ageChangedButton.Location = new System.Drawing.Point(307, 62);
            this.ageChangedButton.Name = "ageChangedButton";
            this.ageChangedButton.Size = new System.Drawing.Size(75, 23);
            this.ageChangedButton.TabIndex = 8;
            this.ageChangedButton.Text = "Изменить";
            this.ageChangedButton.UseVisualStyleBackColor = true;
            this.ageChangedButton.Click += new System.EventHandler(this.ageChangedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Возраст";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(74, 65);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(227, 20);
            this.ageNumericUpDown.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 127);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.ageChangedButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeLastNameButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeFirstNameButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Работа с событиями";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button changeFirstNameButton;
        private System.Windows.Forms.Button changeLastNameButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ageChangedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
    }
}

