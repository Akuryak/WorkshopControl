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
    /// Логика взаимодействия для SecurityEmployeePage.xaml
    /// </summary>
    public partial class SecurityEmployeePage : Page
    {
        public static Employee Employee { get; set; }
        public SecurityEmployeePage(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Autorization());
            if (Employee.Gender == "М")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} вышел из системы", Employee.Code, null));
            else if (Employee.Gender == "Ж")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} вышла из системы", Employee.Code, null));
            App.Context.SaveChanges();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeesDataGrid.ItemsSource = App.Context.Employees.ToList();
            DivisionEmployeeComboBox.ItemsSource = App.Context.Divisions.ToList();

            foreach (Employee employee in App.Context.Employees.ToList())
            {
                EmployeesListBox.Items.Add(new UserControls.SecurityEmployeeUserControl(employee));
            }
        }

        private void EmployeesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem != null)
            {
                Employee employee = EmployeesDataGrid.SelectedItem as Employee;
                CanVisitOtherWorkshops.IsChecked = employee.CanVisitOtherWorkshops == 0 ? false : true;
                PasswordEmployeeTextBox.Text = employee.Password == null ? "" : employee.Password.Trim();
                DivisionEmployeeComboBox.SelectedItem = App.Context.Divisions.ToList().FirstOrDefault(x=>x.Id == employee.Subdivision);
                StatusEmployeeTextBox.Text = Employee.Status == null ? "" : Employee.Status.Trim();
            }
        }

        private void CancelChangesButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Pages.SecurityEmployeePage(Employee), $"{Employee.SubdivisionNavigation.Name} службы безопасности - {Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.");
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem != null)
            {
                Employee employee = EmployeesDataGrid.SelectedItem as Employee;

                if (employee.CanVisitOtherWorkshops != (sbyte)(CanVisitOtherWorkshops.IsChecked == true ? 1 : 0))
                    App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} изменил мандатный доступ на посещение других цехов пользователя с кодом {employee.Code}", Employee.Code, null));
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == employee.Code).CanVisitOtherWorkshops = (sbyte)(CanVisitOtherWorkshops.IsChecked == true ? 1 : 0);
                App.Context.SaveChanges();

                if (employee.Password != PasswordEmployeeTextBox.Text.Trim())
                    App.Context.Logs.Add(new Log(DateTime.Now.AddSeconds(1), $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} изменил пароль пользователя с кодом {employee.Code}", Employee.Code, null));
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == employee.Code).Password = PasswordEmployeeTextBox.Text.Trim();
                App.Context.SaveChanges();

                if (employee.Subdivision != ((Division)DivisionEmployeeComboBox.SelectedItem).Id)
                    App.Context.Logs.Add(new Log(DateTime.Now.AddSeconds(2), $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} изменил подразделение пользователя с кодом {employee.Code}", Employee.Code, null));
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == employee.Code).Subdivision = ((Division)DivisionEmployeeComboBox.SelectedItem).Id;
                App.Context.SaveChanges();

                if (employee.IsVerificated != 1)
                    App.Context.Logs.Add(new Log(DateTime.Now.AddSeconds(3), $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} одобрил пользователя с кодом {employee.Code}", Employee.Code, null));
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == employee.Code).IsVerificated = 1;

                if (employee.Status != StatusEmployeeTextBox.Text.Trim())
                    App.Context.Logs.Add(new Log(DateTime.Now.AddSeconds(4), $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} изменил статус пользователя с кодом {employee.Code}", Employee.Code, null));
                App.Context.Employees.ToList().FirstOrDefault(x => x.Code == employee.Code).Status = StatusEmployeeTextBox.Text.Trim();
                App.Context.SaveChanges();

                Windows.MessageBox.Show("Уведомление", $"Данные {Employee.SubdivisionNavigation.Name}а {employee.Surname} {employee.Name} {employee.Patronomic} сохранены");
                Assets.Helpers.FrameManager.Navigate(new Pages.SecurityEmployeePage(Employee), $"{Employee.SubdivisionNavigation.Name} службы безопасности - {Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.");
            }
            else
                Windows.MessageBox.Show("Уведомление", "Выберите сотрудника для редактирования");
        }
    }
}
