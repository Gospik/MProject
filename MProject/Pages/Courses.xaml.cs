

namespace MProject.Pages;

public partial class Courses : ContentPage
{
	public Courses()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
    }

    private void Add_Button_Clicked(object sender, EventArgs e)
    {
        int courseCode;
        if (int.TryParse(Course_Code.Text, out courseCode))
        {
           
            App.DBTrans.AddCourse(new CourseClass { Course_Code = courseCode, Course_Name = Course_Name.Text });
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
    }

    
    private async void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var course = e.Item as CourseClass;
        string message = $"Course Name: {course.Course_Name}\nCourse Code: {course.Course_Code}";


        var result = await DisplayAlert("Selected Course", message, "Delete", "Cancel");


        if (result)
        {

            DeleteCourse(course);
        }
    }
    private void DeleteCourse(CourseClass course)
    {

        App.DBTrans.DeleteCourse(course.Course_Code);
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
    }

}