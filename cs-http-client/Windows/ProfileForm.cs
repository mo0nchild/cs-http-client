using CSHttpClient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHttpClient.Windows
{
    public partial class ProfileForm : Form
    {
        protected Controllers.StudentInfo StudentInfo { get; set; } = default!;
        protected Controllers.CollectionStatements Statements { get; set; } = default!;

        public ProfileForm(Controllers.StudentInfo student, Controllers.CollectionStatements statements)
        {
            this.InitializeComponent(); (this.StudentInfo, this.Statements) = (student, statements);
            this.Load += new EventHandler(ProfileFormLoad);
        }
        private void InitializeTextboxes()
        {
            this.fio_textbox.Text = this.StudentInfo.Name; this.code_textbox.Text = this.StudentInfo.Code;
            this.course_textbox.Text = this.StudentInfo.Сourse; this.group_textbox.Text = this.StudentInfo.Group;
        }

        private void ProfileFormLoad(object? sender, EventArgs args)
        {
            this.InitializeTextboxes();

            this.subject_listview.Items.Clear(); this.subject_listview.Groups.Clear();
            foreach(var course in this.Statements.Statement.GroupBy((Controllers.Statements key) => key.Course))
            {
                Console.WriteLine(course.Key);
                this.subject_listview.Groups.Add(new ListViewGroup(course.Key, course.Key) {  });
                foreach (var subject in course)
                {
                    var row_string = new string[] { subject.Subject, subject.Rating.ToString() };
                    this.subject_listview.Items.Add(new ListViewItem(row_string, this.subject_listview.Groups[course.Key]));
                }
            }
        }
    }
}
