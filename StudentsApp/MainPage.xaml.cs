namespace StudentsApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        studentsList.ItemsSource = App.Database.GetItems();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Student selectedStudent = (Student)e.SelectedItem;
        StudentPage studentPage = new StudentPage();
        studentPage.BindingContext = selectedStudent;
        await Navigation.PushAsync(studentPage);
    }
    // обработка нажатия кнопки добавления
    private void CreateStudent(object sender, EventArgs e)
    {
        Student student = new Student();
        StudentPage studentPage = new StudentPage();
        studentPage.BindingContext = student;
        Navigation.PushAsync(studentPage);
    }
}

