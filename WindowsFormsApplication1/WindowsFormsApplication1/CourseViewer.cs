using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace WindowsFormsApplication1
{
    public partial class CourseViewer : Form
    {

        private SchoolEntities schoolContext;

        public CourseViewer()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            // Dispose the object context.
            schoolContext.Dispose();

            this.Close();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();

            var departmentQuery = from d in schoolContext.Departments.Include("Courses") orderby d.Name select d;

            try
            {
                this.departmentList.DisplayMember = "name";
                this.departmentList.DataSource = ((ObjectQuery)departmentQuery).Execute(MergeOption.AppendOnly);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Get the object for the selected department.
                Department department = (Department)this.departmentList.SelectedItem;

                //Bind the grid view to the collection of Course objects
                // that are related to the selected Department object.
                courseGridView.DataSource = department.Courses;

                // Hide the columns that are bound to the navigation properties on Course.
                courseGridView.Columns["Department"].Visible = false;
                courseGridView.Columns["StudentGrades"].Visible = false;
                courseGridView.Columns["OnlineCourse"].Visible = false;
                courseGridView.Columns["OnsiteCourse"].Visible = false;
                courseGridView.Columns["People"].Visible = false;
                courseGridView.Columns["DepartmentId"].Visible = false;

                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {

                // Save object changes to the database, 
                // display a message, and refresh the form.
                schoolContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
