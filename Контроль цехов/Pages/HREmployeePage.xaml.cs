using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using УППО_Пропуски.Models;

namespace УППО_Пропуски.Pages
{
    /// <summary>
    /// Логика взаимодействия для HREmployeePage.xaml
    /// </summary>
    public partial class HREmployeePage : System.Windows.Controls.Page
    {
        public static string EmployeePhoto { get; set; }
        public static string EmployeeFullPhoto { get; set; }

        public static Employee Employee { get; set; }
        public HREmployeePage(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            WorkshopComboBox.ItemsSource = App.Context.Workshops.ToList();
            EmployeeBirthdateDatePicker.BlackoutDates.Add(new CalendarDateRange(DateTime.Now.AddYears(-14), DateTime.MaxValue));
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Pages.Autorization());

            Assets.Helpers.FrameManager.Navigate(new Pages.Autorization());
            if (Employee.Gender == "М")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} вышел из системы", Employee.Code, null));
            else if (Employee.Gender == "Ж")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} вышла из системы", Employee.Code, null));
            App.Context.SaveChanges();
        }

        private void UploadPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Фотографии |*.jpg;*.png",
                Multiselect = false,
                Title = "Выберите фото {Employee.SubdivisionNavigation.Name}а",
                ReadOnlyChecked = true,
                ValidateNames = true,
                DefaultExt = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            if (openFileDialog.ShowDialog() == true)
            {
                EmployeePhoto = openFileDialog.SafeFileName;
                EmployeeFullPhoto = openFileDialog.FileName;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(openFileDialog.FileName);
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                UserPhotoImage.Source = bitmapImage;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Pages.HREmployeePage(Employee), $"{Employee.SubdivisionNavigation.Name} - {Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.");
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SurnameTextBox.Text) && !string.IsNullOrWhiteSpace(NameTextBox.Text) && !string.IsNullOrWhiteSpace(PatronomicTextBox.Text) && GenderComboBox.SelectedItem != null && EmployeeBirthdateDatePicker.SelectedDate != null && WorkshopComboBox.SelectedItem != null)
            {
                if (!File.Exists($"../../../Assets/Images/{SurnameTextBox.Text.Trim()}_{NameTextBox.Text.Trim()}_{PatronomicTextBox.Text.Trim()}.png"))
                    File.Copy(EmployeeFullPhoto, $"../../../Assets/Images/{SurnameTextBox.Text.Trim()}_{NameTextBox.Text.Trim()}_{PatronomicTextBox.Text.Trim()}.png");

                Employee employee = new Employee(App.Context.Employees.ToList().Max(x => x.Code) + 1, SurnameTextBox.Text.Trim(), NameTextBox.Text.Trim(), PatronomicTextBox.Text.Trim(), ((ComboBoxItem)GenderComboBox.SelectedItem).Content.ToString(), DateOnly.Parse(((DateTime)EmployeeBirthdateDatePicker.SelectedDate).ToShortDateString()), $"{SurnameTextBox.Text.Trim()}_{NameTextBox.Text.Trim()}_{PatronomicTextBox.Text.Trim()}.png", null, ((Workshop)WorkshopComboBox.SelectedItem).Id, null, "На проверке", 0, 0, null, null, null);
                App.Context.Employees.Add(employee);

                if (Employee.Gender == "М")
                    App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} добавил пользователя {employee.Surname} {employee.Name} {employee.Patronomic}", Employee.Code, null));
                else if (Employee.Gender == "Ж")
                    App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} добавила пользователя {employee.Surname} {employee.Name} {employee.Patronomic}", Employee.Code, null));
                App.Context.SaveChanges();

                Windows.MessageBox.Show("Уведомление", "Сотрудник успешно добавлен и отправлен на проверку");
                Assets.Helpers.FrameManager.Navigate(new Pages.HREmployeePage(Employee), $"{Employee.SubdivisionNavigation.Name} отдела кадров - {Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.");
            }
            else
                Windows.MessageBox.Show("Уведомление", "Заполните все поля");
        }
    }
}
