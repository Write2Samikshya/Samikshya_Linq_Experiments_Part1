using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samikshya_Linq_Experiments_Part1
{
    public class AllStudents
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string StudentGender { get; set; }

        public int StudentAge { get; set; }


        public static List<AllStudents> GetAllStudents()
        {
            List<AllStudents> allStudents = new List<AllStudents>();

            AllStudents allStudents1 = new AllStudents()
            {
                StudentID=1,
                StudentAge=12,
                StudentGender="Male",
                StudentName="Samu1"
            };

            allStudents.Add(allStudents1);

            AllStudents allStudents2 = new AllStudents()
            {
                StudentName="Samu2",
                StudentID=2,
                StudentGender="Female",
                StudentAge=13

            };
            allStudents.Add(allStudents2);

            AllStudents allStudents3 = new AllStudents()
            {
                StudentAge=14,
                StudentGender="Male",
                StudentID=5,
                StudentName="Samu3"
            };
            allStudents.Add(allStudents3);

            AllStudents allStudents4 = new AllStudents()
            {
                StudentName="Samu6",
                StudentID=22,
                StudentGender="Female",
                StudentAge=10

            };
            allStudents.Add(allStudents4);

            return allStudents;
        }




    }
}