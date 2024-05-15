using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MProject
{
    public class StudentClass
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } 
        public string Name { get; set; }    
        public string Department { get; set; }
        
        public StudentClass() { } 

        public StudentClass(int id,string name, string deparment) 
        {
            ID = id;
            Name = name;
            Department = deparment;
        }
    }
}
