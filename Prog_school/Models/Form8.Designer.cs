namespace Prog_school.Models
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Название_предмета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Учитель_данного_предмета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценки_учеников = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название_предмета,
            this.Учитель_данного_предмета,
            this.Оценки_учеников});
            this.dataGridView1.Location = new System.Drawing.Point(118, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 234);
            this.dataGridView1.TabIndex = 30;
            // 
            // Название_предмета
            // 
            this.Название_предмета.HeaderText = "Название_предмета";
            this.Название_предмета.MinimumWidth = 6;
            this.Название_предмета.Name = "Название_предмета";
            this.Название_предмета.Width = 180;
            // 
            // Учитель_данного_предмета
            // 
            this.Учитель_данного_предмета.HeaderText = "Учитель_данного_предмета";
            this.Учитель_данного_предмета.MinimumWidth = 6;
            this.Учитель_данного_предмета.Name = "Учитель_данного_предмета";
            this.Учитель_данного_предмета.Width = 200;
            // 
            // Оценки_учеников
            // 
            this.Оценки_учеников.HeaderText = "Оценки_учеников";
            this.Оценки_учеников.MinimumWidth = 6;
            this.Оценки_учеников.Name = "Оценки_учеников";
            this.Оценки_учеников.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(265, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 67);
            this.button1.TabIndex = 31;
            this.button1.Text = "Добавить предмет";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(439, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 67);
            this.button2.TabIndex = 32;
            this.button2.Text = "Удалить предмет";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(260, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Сведения о предметах";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_предмета;
        private System.Windows.Forms.DataGridViewTextBoxColumn Учитель_данного_предмета;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценки_учеников;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}