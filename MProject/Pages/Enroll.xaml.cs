

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
                Course_Code = selectedCourse.Course_Code,
                Course_Name = selectedCourse.Course_Name,
            }) ;
        }
        else
        {
            return;
        }
        Enroll_List_View.ItemsSource = App.DBTrans.GetEnroll();
    }

    private void Show_Button_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        Enroll_List_View.ItemsSource = App.DBTrans.GetEnroll();
    }

    private async void Enroll_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var enroll = e.Item as GlobalClass;
        string message = $"Student Name: {enroll.Name}\nCourse Code: {enroll.Course_Name}";


        var result = await DisplayAlert("Selected Course", message, "Delete", "Cancel");


        if (result)
        {

            DeleteEnroll(enroll);
        }
    }
    private void DeleteEnroll(GlobalClass enroll)
    {

        App.DBTrans.DeleteEnroll(enroll.ID);
        Enroll_List_View.ItemsSource = App.DBTrans.GetEnroll();
    }
}