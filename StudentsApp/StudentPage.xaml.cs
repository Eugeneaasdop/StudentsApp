namespace StudentsApp;

public partial class StudentPage : ContentPage
{
    public StudentPage()
    {
        InitializeComponent();
    }

    private void SaveStudent(object sender, EventArgs e)
    {
        var student = (Student)BindingContext;
        if (!String.IsNullOrEmpty(student.Group) && !String.IsNullOrEmpty(student.FIO))
        {
            App.Database.SaveItem(student);
        }
        this.Navigation.PopAsync();
    }
    private void DeleteStudent(object sender, EventArgs e)
    {
        var student = (Student)BindingContext;
        App.Database.DeleteItem(student.Id);
        this.Navigation.PopAsync();
    }
    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }
}