using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Samikshya_Linq_Experiments_Part1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          IEnumerable<AllStudents> allStudents=  AllStudents.GetAllStudents().Where(students => students.StudentGender == "Male");
          
            GridView3.DataSource = allStudents;
            GridView3.DataBind();
        }


        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}