namespace Prog_school.Models
{
    partial class Form10
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
            this.ФИО_ученика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_предмета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Класс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Средняя_оценка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО_ученика,
            this.Название_предмета,
            this.Класс,
            this.Средняя_оценка});
            this.dataGridView1.Location = new System.Drawing.Point(83, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 234);
            this.dataGridView1.TabIndex = 31;
            // 
            // ФИО_ученика
            // 
            this.ФИО_ученика.HeaderText = "ФИО_ученика";
            this.ФИО_ученика.MinimumWidth = 6;
            this.ФИО_ученика.Name = "ФИО_ученика";
            this.ФИО_ученика.Width = 125;
            // 
            // Название_предмета
            // 
            this.Название_предмета.HeaderText = "Название_предмета";
            this.Название_предмета.MinimumWidth = 6;
            this.Название_предмета.Name = "Название_предмета";
            this.Название_предмета.Width = 180;
            // 
            // Класс
            // 
            this.Класс.HeaderText = "Класс";
            this.Класс.MinimumWidth = 6;
            this.Класс.Name = "Класс";
            this.Класс.Width = 110;
            // 
            // Средняя_оценка
            // 
            this.Средняя_оценка.HeaderText = "Средняя_оценка";
            this.Средняя_оценка.MinimumWidth = 6;
            this.Средняя_оценка.Name = "Средняя_оценка";
            this.Средняя_оценка.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(188, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Средняя успеваемость по школе";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_ученика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_предмета;
        private System.Windows.Forms.DataGridViewTextBoxColumn Класс;
        private System.Windows.Forms.DataGridViewTextBoxColumn Средняя_оценка;
        private System.Windows.Forms.Label label1;
    }
}