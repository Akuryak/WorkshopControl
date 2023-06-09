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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Login()
        {
            if (!string.IsNullOrWhiteSpace(EmployeeCodeTextBox.Text) && !string.IsNullOrWhiteSpace(EmployeePasswordPasswordBox.Password))
            {
                if (int.TryParse(EmployeeCodeTextBox.Text.Trim(), out int code))
                {
                    List<Employee> employees = new List<Employee>();
                    try
                    {
                        employees = App.Context.Employees.ToList();
                    }
                    catch (Exception ex)
                    {
                        Windows.MessageBox.Show("Уведомление", $"Произошла ошибка при подключении к базе данных: {ex.Message}");
                        return;
                    }
                    foreach (Employee employee in employees)
                    {
                        if (employee.Code == code && employee.Password == EmployeePasswordPasswordBox.Password.Trim())
                        {
                            if (employee.Subdivision != null)
                            {
                                switch (employee.SubdivisionNavigation.Name)
                                {
                                    case "Сотрудник отдела кадров":
                                        Assets.Helpers.FrameManager.Navigate(new Pages.HRChooseActionPage(employee), $"Сотрудник отдела кадров - {employee.Surname} {employee.Name.First()}.{employee.Patronomic.First()}.");
                                        if (employee.Gender == "М")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошел в систему", employee.Code, null));
                                        else if (employee.Gender == "Ж")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошла в систему", employee.Code, null));
                                        break;

                                    case "Сотрудник службы безопасности":
                                        Assets.Helpers.FrameManager.Navigate(new Pages.SecurityEmployeePage(employee), $"Сотрудник службы безопасности - {employee.Surname} {employee.Name.First()}.{employee.Patronomic.First()}.");
                                        if (employee.Gender == "М")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошел в систему", employee.Code, null));
                                        else if (employee.Gender == "Ж")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошла в систему", employee.Code, null));
                                        break;

                                    case "Начальник цеха":
                                        Assets.Helpers.FrameManager.Navigate(new Pages.ForemanPage(employee), $"Начальник цеха - {employee.Surname} {employee.Name.First()}.{employee.Patronomic.First()}.");
                                        if (employee.Gender == "М")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошел в систему", employee.Code, null));
                                        else if (employee.Gender == "Ж")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошла в систему", employee.Code, null));
                                        break;

                                    case "Работник цеха":
                                        Assets.Helpers.FrameManager.Navigate(new Pages.EmployeeInfoPage(employee), $"Работник цеха - {employee.Surname} {employee.Name.First()}.{employee.Patronomic.First()}.");
                                        if (employee.Gender == "М")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошел в систему", employee.Code, null));
                                        else if (employee.Gender == "Ж")
                                            App.Context.Logs.Add(new Log(DateTime.Now, $"{employee.SubdivisionNavigation.Name} {employee.Name} {employee.Surname} {employee.Patronomic} вошла в систему", employee.Code, null));
                                        break;
                                }
                                App.Context.SaveChanges();
                                return;
                            }
                        }
                    }
                    Windows.MessageBox.Show("Уведомление", "Неверный логин или пароль");
                }
            }
            else
                Windows.MessageBox.Show("Уведомление", "Заполните все поля");
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void EmployeePasswordPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }

        private void EmployeeCodeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            EmployeeCodeTextBlock.Visibility = Visibility.Hidden;
        }

        private void EmployeeCodeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeCodeTextBox.Text))
                EmployeeCodeTextBlock.Visibility = Visibility.Visible;
        }

        private void EmployeePasswordPasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            EmployeePasswordTextBlock.Visibility = Visibility.Hidden;
        }

        private void EmployeePasswordPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeCodeTextBox.Text))
                EmployeePasswordTextBlock.Visibility = Visibility.Visible;
        }
    }
}
