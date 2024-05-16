﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MProject.Pages.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;  
        }
        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<StudentClass>();
            conn.CreateTable<CourseClass>();
        }
        public List<StudentClass> GetAllStudents() 
        {
            Init();
            return conn.Table<StudentClass>().ToList();
        }
        public void Add(StudentClass student) 
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }
        public void Delete(int student_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentClass { ID = student_ID });
        }

        public List<CourseClass> GetAllCourses()
        {
            Init();
            return conn.Table<CourseClass>().ToList();
        }

        public void AddCourse(CourseClass course)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(course);
        }

        public void DeleteCourse(int course_Code)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new CourseClass { Course_Code = course_Code});
        }
    }
}
