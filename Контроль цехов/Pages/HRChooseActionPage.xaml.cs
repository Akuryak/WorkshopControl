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
    /// Логика взаимодействия для HRChooseActionPage.xaml
    /// </summary>
    public partial class HRChooseActionPage : Page
    {
        public static Employee Employee { get; set; }
        public HRChooseActionPage(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void MakeRequestButton_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> employees = App.Context.Employees.ToList();
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application()
            {
                SheetsInNewWorkbook = 1,
            };

            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Работники";

            worksheet.Cells[1][1] = "ФИО";
            worksheet.Cells[2][1] = "Пол";
            worksheet.Cells[3][1] = "День рождения";
            worksheet.Cells[4][1] = "Цех";
            worksheet.Cells[5][1] = "Подразделение";
            worksheet.Cells[6][1] = "Статус";

            for (int i = 0; i < employees.Count; i++)
            {
                worksheet.Cells[1][i + 2] = $"{employees[i].Surname} {employees[i].Name} {employees[i].Patronomic}";
                worksheet.Cells[2][i + 2] = employees[i].Gender;
                worksheet.Cells[3][i + 2] = employees[i].Birthdate.ToString();
                worksheet.Cells[4][i + 2] = employees[i].WorkshopNavigation.Name;
                worksheet.Cells[5][i + 2] = employees[i].SubdivisionNavigation == null ? "-" : employees[i].SubdivisionNavigation.Name;
                worksheet.Cells[6][i + 2] = employees[i].Status;
            }
            worksheet.Columns.AutoFit();

            application.Visible = true;

            App.Context.SaveChanges();

            if (Employee.Gender == "М")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} создал свод сотрудников.", Employee.Code, null));
            else if (Employee.Gender == "Ж")
                App.Context.Logs.Add(new Log(DateTime.Now, $"{Employee.SubdivisionNavigation.Name} {Employee.Name} {Employee.Surname} {Employee.Patronomic} создала свод сотрудников.", Employee.Code, null));
            App.Context.SaveChanges();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Pages.Autorization());
            App.Context.SaveChanges();
        }

        private void AddNewEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            Assets.Helpers.FrameManager.Navigate(new Pages.HREmployeePage(Employee), $"Сотрудник отдела кадров - {Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.");
        }
    }
}
