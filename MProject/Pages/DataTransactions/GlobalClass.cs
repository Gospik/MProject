using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MProject.Pages.DataTransactions
{
   public class GlobalClass
    {
        [PrimaryKey]
        public int ID {  get; set; }
        public string Name { get; set; } 
        public int Course_Code {  get; set; }
        public string Course_Name { get; set; }

        public GlobalClass() {  }

        public GlobalClass(int id,string name,int course_code,string course_name) 
        {
            ID = id;
            Name= name;
            Course_Code = course_code;
            Course_Name = course_name;
        }
    }
}
