namespace Prog_school.Models
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_предмета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Класс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(271, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сведения об учениках";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(213, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 75);
            this.button2.TabIndex = 19;
            this.button2.Text = "Добавить \r\n ученика";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(494, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 75);
            this.button3.TabIndex = 20;
            this.button3.Text = "Отчислить ученика";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО,
            this.Название_предмета,
            this.Оценки,
            this.Класс});
            this.dataGridView1.Location = new System.Drawing.Point(69, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 240);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО_ученика";
            this.ФИО.MinimumWidth = 6;
            this.ФИО.Name = "ФИО";
            this.ФИО.Width = 220;
            // 
            // Название_предмета
            // 
            this.Название_предмета.HeaderText = "Название_предмета";
            this.Название_предмета.MinimumWidth = 10;
            this.Название_предмета.Name = "Название_предмета";
            this.Название_предмета.Width = 170;
            // 
            // Оценки
            // 
            this.Оценки.HeaderText = "Оценки учеников ";
            this.Оценки.MinimumWidth = 10;
            this.Оценки.Name = "Оценки";
            this.Оценки.ReadOnly = true;
            this.Оценки.Width = 115;
            // 
            // Класс
            // 
            this.Класс.HeaderText = "Класс";
            this.Класс.MinimumWidth = 6;
            this.Класс.Name = "Класс";
            this.Класс.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_предмета;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Класс;
    }
}