using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Samikshya_Linq_Experiments_Part1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //    string CS = ConfigurationManager.ConnectionStrings["Samikshya_Link_ConnectionString"].ConnectionString;
        
            SqlConnection con = new SqlConnection("data source =.; database=LINQExperiments;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("Select ID, Name, Gender, FirstName,LastName from Students", con);

            List<Student> liststudents = new List<Student>();

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Student student = new Student();
                student.ID = Convert.ToInt32(rdr["ID"]);
                student.Name = (rdr["Name"].ToString());
                student.FirstName = (rdr["FirstName"].ToString());
                student.LastName = rdr["LastName"].ToString();
                student.Gender = rdr["Gender"].ToString();

                liststudents.Add(student);

            }

            con.Close();
            con.Dispose();

            GridView1.DataSource = liststudents;
            GridView1.DataBind();
        }  
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}