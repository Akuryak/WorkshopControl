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

namespace УППО_Пропуски.UserControls
{
    /// <summary>
    /// Логика взаимодействия для SecurityEmployeeUserControl.xaml
    /// </summary>
    public partial class SecurityEmployeeUserControl : UserControl
    {
        public static Employee Employee { get; set; }
        public SecurityEmployeeUserControl(Employee employee)
        {
            InitializeComponent();
            Employee = employee;

            FullNameTextBlock.Text = $"{employee.Surname} {employee.Name} {employee.Patronomic}";
            GenderTextBlock.Text = employee.Gender == "М" ? "Мужчина" : "Женщина";
            BirthdateTextBlock.Text = employee.Birthdate.ToShortDateString() + " года рождения.";
            PasswordTextBox.Text = employee.Password;
            StatusTextBox.Text = employee.Status;
            CanVisitOtherWorkshops.IsChecked = employee.CanVisitOtherWorkshops == 0 ? false : true;
            DivisionComboBox.ItemsSource = App.Context.Divisions.ToList();
            DivisionComboBox.SelectedItem = App.Context.Divisions.ToList().FirstOrDefault(x=>x.Id == employee.Subdivision);
            if (employee.Photo != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("../../../Assets/Images/" + employee.Photo, UriKind.Relative);
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                UserPhotoImage.Source = bitmapImage;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PasswordTextBox.IsFocused)
            {
                if (PasswordTextBox.Text.Trim().Count() > 4)
                    PasswordTextBox.Foreground = Brushes.Black;
                else
                    PasswordTextBox.Foreground = Brushes.Red;
            }
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text.Trim().Count() > 4)
            {
                if (PasswordTextBox.Text.Trim() != Employee.Password)
                {
                    PasswordTextBox.Foreground = Brushes.Green;
                    App.Context.Employees.ToList().FirstOrDefault(x => x.Code == Employee.Code).Password = PasswordTextBox.Text.Trim();
                    App.Context.SaveChanges();
                }
            }
            else
            {
                Windows.MessageBox.Show("Уведомление", "Пароль должен быть больше 5 символов");
                PasswordTextBox.Text = Employee.Password;
                PasswordTextBox.Foreground = Brushes.Black;
            }
        }

        private void StatusTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (StatusTextBox.IsFocused)
            {
                if (StatusTextBox.Text.Trim().Count() > 4)
                    StatusTextBox.Foreground = Brushes.Black;
                else
                    StatusTextBox.Foreground = Brushes.Red;
            }
        }

        private void StatusTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (StatusTextBox.Text.Trim() != Employee.Status)
            {
                StatusTextBox.Foreground = Brushes.Green;
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == Employee.Code).Status = StatusTextBox.Text.Trim();
                App.Context.SaveChanges();
            }
        }

        private void DivisionComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(DivisionComboBox.SelectedItem != null)
            {
                if (Employee.Subdivision != ((Division)DivisionComboBox.SelectedItem).Id)
                {
                    App.Context.Employees.ToList().FirstOrDefault(x => x.Code == Employee.Code).Subdivision = ((Division)DivisionComboBox.SelectedItem).Id;
                    App.Context.SaveChanges();
                }
            }
        }

        private void CanVisitOtherWorkshops_Checked(object sender, RoutedEventArgs e)
        {
            if (CanVisitOtherWorkshops.IsChecked == true)
            {
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == Employee.Code).CanVisitOtherWorkshops = 1;
            }
            else
            {
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == Employee.Code).CanVisitOtherWorkshops = 0;
            }
            CanVisitOtherWorkshops.BorderBrush = Brushes.Green;
            App.Context.SaveChanges();
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
