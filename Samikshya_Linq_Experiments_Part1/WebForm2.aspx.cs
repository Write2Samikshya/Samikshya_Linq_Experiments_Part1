using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Samikshya_Linq_Experiments_Part1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["Samikshya_Linq_Connection"].ConnectionString;
            SqlConnection con1 = new SqlConnection(CS);
            SqlCommand cmd1 = new SqlCommand("Select * from Students",con1);

            List<Student> liststudents2 = new List<Student>();

            con1.Open();
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while(rdr1.Read())
            {

                Student stud = new Student();
                stud.ID = Convert.ToInt32(rdr1["ID"]);
                stud.Name = rdr1["Name"].ToString();
                stud.FirstName = rdr1["FirstName"].ToString();
                stud.LastName = rdr1["LastName"].ToString();
                stud.Gender = rdr1["Gender"].ToString();

                liststudents2.Add(stud);
            }

            con1.Close();
            con1.Dispose();

            GridView1.DataSource = liststudents2;
            GridView1.DataBind();

        }
    }
}