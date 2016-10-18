using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using comp229_Home_Practice.Models;
using System.Web.ModelBinding;

namespace comp229_Home_Practice
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time
            // populate the courses grid
            if (!IsPostBack)
            {
                // Get the courses data
                this.GetCourse();
            }
        }

        /// <summary>
        /// This method gets the courses data from the DB
        /// </summary>
        private void GetCourse()
        {
            // connect to EF DB
            using (MyContext db = new MyContext())
            {
                // query the Courses Table using EF and LINQ
                var CoursesData = (from allcourse in db.Courses
                                   select allcourse);

                // bind the result to the course GridView
                CoursesGridView.DataSource = CoursesData.ToList();
                CoursesGridView.DataBind();
            }
        }

        protected void CoursesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected CourseID using the Grid's DataKey collection
            int selectedCourseID = Convert.ToInt32(CoursesGridView.DataKeys[selectedRow].Values["CourseID"]);

            // use EF and LINQ to find the selected course in the DB and remove it
            using (MyContext db = new MyContext())
            {
                // create object ot the course class and store the query inside of it

                Course deletedCourse = (from courseRecords in db.Courses
                                     where courseRecords.CourseID == selectedCourseID
                                     select courseRecords).FirstOrDefault();


                // remove the selected course from the db
                db.Courses.Remove(deletedCourse);

                // save my changes back to the db
                db.SaveChanges();

                // refresh the grid
                this.GetCourse();
            }
        }
    }
}