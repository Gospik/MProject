

using MProject.Pages.DataTransactions;

namespace MProject.Pages;

public partial class Enroll : ContentPage
{
    private StudentClass selectedStudent;
    private CourseClass selectedCourse;
    public Enroll()
	{
		InitializeComponent();
		Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
		Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
        Enroll_List_View.ItemsSource = App.DBTrans.GetEnroll();
	}

    private void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedStudent = e.Item as StudentClass;
    }

    private void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        selectedCourse = e.Item as CourseClass;
    }

    private void Add_Button_Clicked(object sender, EventArgs e)
    {
        if (selectedStudent != null && selectedCourse != null)
        {

            App.DBTrans.Enroll(new GlobalClass
            {
                ID = selectedStudent.ID,
                Name = selectedStudent.Name,
                
            }) ;
        }
        else
        {
            return;
        }
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
    }

    private void Show_Button_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        Enroll_List_View.ItemsSource = App.DBTrans.GetEnroll();
    }

    private void Enroll_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}