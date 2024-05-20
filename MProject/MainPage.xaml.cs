namespace MProject
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
           
        }

        

        private void Add_Button_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.Add(new StudentClass   {   Name = Stu_Name.Text,    Department = Stu_Dept.Text,  });
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void Show_Button_Clicked(object sender, EventArgs e)
        {
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        }
        
        private async void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var student = e.Item as StudentClass;
            string message = $"Student ID: {student.ID}\nStudent Name: {student.Name}";

           
            var result = await DisplayAlert("Selected Student", message, "Delete", "Cancel");

            
            if (result)
            {
               
                DeleteStudent(student);
            }
        }
        private void DeleteStudent(StudentClass student)
        {
           
            App.DBTrans.Delete(student.ID);
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        }
    }

}
