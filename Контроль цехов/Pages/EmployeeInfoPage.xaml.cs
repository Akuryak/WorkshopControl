using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для EmployeeInfoPage.xaml
    /// </summary>
    public partial class EmployeeInfoPage : Page
    {
        public static Employee Employee { get; set; }
        public EmployeeInfoPage(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Pages.Autorization());

            if (Employee.Gender == "М")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} вышел из системы", Employee.Code, null));
            else if (Employee.Gender == "Ж")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} вышла из системы", Employee.Code, null));
            App.Context.SaveChanges();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameTextBlock.Text += $"{Employee.Surname} {Employee.Name} {Employee.Patronomic}";
            GenderTextBlock.Text += Employee.Gender;
            BirthdateTextBlock.Text += Employee.Birthdate.ToShortDateString();
            WorkshopTextBlock.Text += Employee.WorkshopNavigation.Name;
            DivisionTextBlock.Text += Employee.SubdivisionNavigation == null ? "-" : Employee.SubdivisionNavigation.Name;
            StatusTextBlock.Text += Employee.Status;
            VerificatedTextBlock.Text += Employee.IsVerificated == 1 ? "Да" : "Нет";
            CanVisitOtherWorkshopsTextBlock.Text += Employee.CanVisitOtherWorkshops == 1 ? "Да" : "Нет";

            if (Employee.Photo != null)
            {
                try
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.UriSource = new Uri("../../../Assets/Images/" + Employee.Photo, UriKind.Relative);
                    bitmapImage.EndInit();
                    EmployeePhotoImage.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    Windows.MessageBox.Show("Ошибка", $"Не удалось загрузить фото сотрудника: {ex.Message}");
                }
            }
        }
    }
}
