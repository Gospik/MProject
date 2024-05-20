using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MProject
{
    public class CourseClass
    {
        [PrimaryKey, AutoIncrement]
        public int Course_ID { get; set; }
        public int Course_Code { get; set; }
        public string Course_Name { get; set; }
            
        public CourseClass () { }

        public CourseClass (int course_ID ,int course_Code, string course_Name)
        {
            Course_ID = course_ID;
            Course_Code = course_Code;
            Course_Name = course_Name;
        }
    }
}
