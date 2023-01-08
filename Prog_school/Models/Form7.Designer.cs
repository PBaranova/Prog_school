namespace Prog_school.Models
{
    partial class Form7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cabinetListBox = new System.Windows.Forms.ListBox();
            this.subjectListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Firebrick;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(226, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 100);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\n Добавить учителя";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(177, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО_учителя";
            // 
            // teacherFIO
            // 
            this.teacherFIO.Location = new System.Drawing.Point(323, 143);
            this.teacherFIO.Name = "teacherFIO";
            this.teacherFIO.Size = new System.Drawing.Size(235, 30);
            this.teacherFIO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = "Предмет, \r\nкоторый \r\nон(она) ведёт";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(383, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 85);
            this.button2.TabIndex = 6;
            this.button2.Text = "Уволить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер_кабинета";
            // 
            // cabinetListBox
            // 
            this.cabinetListBox.FormattingEnabled = true;
            this.cabinetListBox.ItemHeight = 25;
            this.cabinetListBox.Location = new System.Drawing.Point(323, 294);
            this.cabinetListBox.Name = "cabinetListBox";
            this.cabinetListBox.Size = new System.Drawing.Size(235, 54);
            this.cabinetListBox.TabIndex = 9;
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(323, 197);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(235, 79);
            this.subjectListBox.TabIndex = 10;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 512);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.cabinetListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacherFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox cabinetListBox;
        private System.Windows.Forms.CheckedListBox subjectListBox;
    }
}