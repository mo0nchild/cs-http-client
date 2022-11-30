namespace CSHttpClient.Windows
{
    partial class ProfileForm
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
            this.code_label = new System.Windows.Forms.Label();
            this.code_textbox = new System.Windows.Forms.TextBox();
            this.fio_label = new System.Windows.Forms.Label();
            this.fio_textbox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.course_label = new System.Windows.Forms.Label();
            this.course_textbox = new System.Windows.Forms.TextBox();
            this.group_label = new System.Windows.Forms.Label();
            this.group_textbox = new System.Windows.Forms.TextBox();
            this.split_panel = new System.Windows.Forms.Panel();
            this.subject_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.subjects_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code_label.Location = new System.Drawing.Point(12, 44);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(95, 19);
            this.code_label.TabIndex = 5;
            this.code_label.Text = "Код студента:";
            // 
            // code_textbox
            // 
            this.code_textbox.BackColor = System.Drawing.Color.White;
            this.code_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.code_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code_textbox.Location = new System.Drawing.Point(12, 66);
            this.code_textbox.MaxLength = 100;
            this.code_textbox.Name = "code_textbox";
            this.code_textbox.ReadOnly = true;
            this.code_textbox.Size = new System.Drawing.Size(207, 29);
            this.code_textbox.TabIndex = 4;
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fio_label.Location = new System.Drawing.Point(235, 44);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(102, 19);
            this.fio_label.TabIndex = 7;
            this.fio_label.Text = "ФИО студента:";
            // 
            // fio_textbox
            // 
            this.fio_textbox.BackColor = System.Drawing.Color.White;
            this.fio_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fio_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fio_textbox.Location = new System.Drawing.Point(235, 66);
            this.fio_textbox.MaxLength = 100;
            this.fio_textbox.Name = "fio_textbox";
            this.fio_textbox.ReadOnly = true;
            this.fio_textbox.Size = new System.Drawing.Size(207, 29);
            this.fio_textbox.TabIndex = 6;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.White;
            this.title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_label.Cursor = System.Windows.Forms.Cursors.No;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(13, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(430, 32);
            this.title_label.TabIndex = 8;
            this.title_label.Text = "Информация о профиле студенте:";
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.course_label.Location = new System.Drawing.Point(235, 98);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(106, 19);
            this.course_label.TabIndex = 12;
            this.course_label.Text = "Курс обучения:";
            // 
            // course_textbox
            // 
            this.course_textbox.BackColor = System.Drawing.Color.White;
            this.course_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.course_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.course_textbox.Location = new System.Drawing.Point(235, 120);
            this.course_textbox.MaxLength = 100;
            this.course_textbox.Name = "course_textbox";
            this.course_textbox.ReadOnly = true;
            this.course_textbox.Size = new System.Drawing.Size(207, 29);
            this.course_textbox.TabIndex = 11;
            // 
            // group_label
            // 
            this.group_label.AutoSize = true;
            this.group_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_label.Location = new System.Drawing.Point(12, 98);
            this.group_label.Name = "group_label";
            this.group_label.Size = new System.Drawing.Size(57, 19);
            this.group_label.TabIndex = 10;
            this.group_label.Text = "Группа:";
            // 
            // group_textbox
            // 
            this.group_textbox.BackColor = System.Drawing.Color.White;
            this.group_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_textbox.Location = new System.Drawing.Point(12, 120);
            this.group_textbox.MaxLength = 100;
            this.group_textbox.Name = "group_textbox";
            this.group_textbox.ReadOnly = true;
            this.group_textbox.Size = new System.Drawing.Size(207, 29);
            this.group_textbox.TabIndex = 9;
            // 
            // split_panel
            // 
            this.split_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.split_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_panel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.split_panel.Location = new System.Drawing.Point(13, 162);
            this.split_panel.Name = "split_panel";
            this.split_panel.Size = new System.Drawing.Size(430, 2);
            this.split_panel.TabIndex = 13;
            // 
            // subject_listview
            // 
            this.subject_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.subject_listview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_listview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subject_listview.FullRowSelect = true;
            this.subject_listview.GridLines = true;
            this.subject_listview.Location = new System.Drawing.Point(12, 192);
            this.subject_listview.MultiSelect = false;
            this.subject_listview.Name = "subject_listview";
            this.subject_listview.Size = new System.Drawing.Size(430, 161);
            this.subject_listview.TabIndex = 14;
            this.subject_listview.UseCompatibleStateImageBehavior = false;
            this.subject_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дисциплина";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Оценка";
            this.columnHeader2.Width = 120;
            // 
            // subjects_label
            // 
            this.subjects_label.AutoSize = true;
            this.subjects_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjects_label.Location = new System.Drawing.Point(13, 170);
            this.subjects_label.Name = "subjects_label";
            this.subjects_label.Size = new System.Drawing.Size(131, 19);
            this.subjects_label.TabIndex = 15;
            this.subjects_label.Text = "Список дисциплин:";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 376);
            this.Controls.Add(this.subjects_label);
            this.Controls.Add(this.subject_listview);
            this.Controls.Add(this.split_panel);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.course_textbox);
            this.Controls.Add(this.group_label);
            this.Controls.Add(this.group_textbox);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.fio_label);
            this.Controls.Add(this.fio_textbox);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.code_textbox);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Профиль ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label code_label;
        private TextBox code_textbox;
        private Label fio_label;
        private TextBox fio_textbox;
        private Label title_label;
        private Label course_label;
        private TextBox course_textbox;
        private Label group_label;
        private TextBox group_textbox;
        private Panel split_panel;
        private ListView subject_listview;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label subjects_label;
    }
}