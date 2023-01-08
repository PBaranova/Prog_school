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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.studentFIOSearch = new System.Windows.Forms.TextBox();
            this.subjectNameSeach = new System.Windows.Forms.TextBox();
            this.searchClass = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО_ученика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_предмета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Класс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Средняя_оценка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ФИО_ученика,
            this.Название_предмета,
            this.Класс,
            this.Средняя_оценка,
            this.QuarterName});
            this.dataGridView1.Location = new System.Drawing.Point(33, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 190);
            this.dataGridView1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(236, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Успеваемость учеников";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Внести оценку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentFIOSearch
            // 
            this.studentFIOSearch.Location = new System.Drawing.Point(82, 54);
            this.studentFIOSearch.Name = "studentFIOSearch";
            this.studentFIOSearch.Size = new System.Drawing.Size(150, 20);
            this.studentFIOSearch.TabIndex = 34;
            // 
            // subjectNameSeach
            // 
            this.subjectNameSeach.Location = new System.Drawing.Point(453, 54);
            this.subjectNameSeach.Name = "subjectNameSeach";
            this.subjectNameSeach.Size = new System.Drawing.Size(150, 20);
            this.subjectNameSeach.TabIndex = 35;
            // 
            // searchClass
            // 
            this.searchClass.Location = new System.Drawing.Point(276, 54);
            this.searchClass.Name = "searchClass";
            this.searchClass.Size = new System.Drawing.Size(150, 20);
            this.searchClass.TabIndex = 36;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(622, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 23);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ФИО_ученика
            // 
            this.ФИО_ученика.DataPropertyName = "StudentName";
            this.ФИО_ученика.HeaderText = "ФИО_ученика";
            this.ФИО_ученика.MinimumWidth = 6;
            this.ФИО_ученика.Name = "ФИО_ученика";
            this.ФИО_ученика.Width = 125;
            // 
            // Название_предмета
            // 
            this.Название_предмета.DataPropertyName = "SubjectName";
            this.Название_предмета.HeaderText = "Название_предмета";
            this.Название_предмета.MinimumWidth = 6;
            this.Название_предмета.Name = "Название_предмета";
            this.Название_предмета.Width = 180;
            // 
            // Класс
            // 
            this.Класс.DataPropertyName = "ClassName";
            this.Класс.HeaderText = "Класс";
            this.Класс.MinimumWidth = 6;
            this.Класс.Name = "Класс";
            this.Класс.Width = 110;
            // 
            // Средняя_оценка
            // 
            this.Средняя_оценка.DataPropertyName = "Grade";
            this.Средняя_оценка.HeaderText = "Оценка";
            this.Средняя_оценка.MinimumWidth = 6;
            this.Средняя_оценка.Name = "Средняя_оценка";
            this.Средняя_оценка.Width = 125;
            // 
            // QuarterName
            // 
            this.QuarterName.DataPropertyName = "QuarterName";
            this.QuarterName.HeaderText = "Четверть";
            this.QuarterName.Name = "QuarterName";
            this.QuarterName.ReadOnly = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 366);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchClass);
            this.Controls.Add(this.subjectNameSeach);
            this.Controls.Add(this.studentFIOSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox studentFIOSearch;
        private System.Windows.Forms.TextBox subjectNameSeach;
        private System.Windows.Forms.TextBox searchClass;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_ученика;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_предмета;
        private System.Windows.Forms.DataGridViewTextBoxColumn Класс;
        private System.Windows.Forms.DataGridViewTextBoxColumn Средняя_оценка;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterName;
    }
}