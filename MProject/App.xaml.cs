﻿using MProject.Pages.DataTransactions;

namespace MProject
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set; }
       
        public App(DBTrans dbtrans)
        {
            InitializeComponent();

            MainPage = new AppShell();
            DBTrans = dbtrans;  
        }
    }
}
