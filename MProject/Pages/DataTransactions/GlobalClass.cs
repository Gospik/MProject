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
        public int ID {  get; set; }
        public string Name { get; set; } 
        public string Course_Code {  get; set; }

        public GlobalClass() {  }

        public GlobalClass(int id,string name,string course_code) 
        {
            ID = id;
            Name= name;
            Course_Code = course_code;

        }
    }
}
