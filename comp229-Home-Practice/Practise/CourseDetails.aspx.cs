using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements required for EF DB access
using comp229_Home_Practice.Models;
using System.Web.ModelBinding;


namespace comp229_Home_Practice
{
    public partial class CourseDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to conect to the server
            using (MyContext db = new MyContext())
            {
                // use the course model to create a new course object and 
                // save a new record

                Course newCourse = new Course();

                int CourseID = 0;

                if (Request.QueryString.Count > 0) // our URL has a courseID in it
                {
                    // get the id from the URL
                }

                // add form data to the new course record
                
                newCourse.Title = TitleTextBox.Text;
                newCourse.Credits = Convert.ToInt32(CreditTextBox.Text);
                newCourse.DepartmentID = Convert.ToInt32(DepartmentIDTextBox.Text);

                // use LINQ to ADO.NET to add / insert new course into the db

                if (CourseID == 0)
                {
                    db.Courses.Add(newCourse);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated course page
                Response.Redirect("~/Practise/Courses.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the Course page
            Response.Redirect("~/Practise/Courses.aspx");
        }
    }
}