using Microsoft.Office.Interop.Word;
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
    /// Логика взаимодействия для ForemanPage.xaml
    /// </summary>
    public partial class ForemanPage : System.Windows.Controls.Page
    {
        public static Employee Employee { get; set; }
        public ForemanPage(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeesDataGrid.ItemsSource = App.Context.Employees.ToList().Where(x=>x.Workshop == Employee.Workshop);

            foreach (Employee employee in App.Context.Employees.ToList().Where(x => x.Workshop == Employee.Workshop))
            {
                EmployeesListBox.Items.Add(new UserControls.ForemanUserControl(employee));
            }
        }

        public void SendRequest(Employee employee)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            Document doc = app.Documents.Add();

            var signatureTabStopPosition = app.InchesToPoints(6.5f);

            doc.PageSetup.TopMargin = app.CentimetersToPoints(2.5f);
            doc.PageSetup.BottomMargin = app.CentimetersToPoints(2.5f);
            doc.PageSetup.LeftMargin = app.CentimetersToPoints(2.5f);
            doc.PageSetup.RightMargin = app.CentimetersToPoints(2.5f);

            Microsoft.Office.Interop.Word.Paragraph para1 = doc.Paragraphs.Add();
            Employee employee1 = App.Context.Employees.ToList().FirstOrDefault(x => x.Subdivision == 2);
            para1.Range.Text = $"Сотруднику службы безопасности {employee1.Surname} {employee1.Name.First()}.{employee1.Patronomic.First()}.";
            para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            para1.Range.InsertParagraphAfter();


            Microsoft.Office.Interop.Word.Paragraph para2 = doc.Paragraphs.Add();
            para2.Range.Text = $"от {Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.";
            para2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            para2.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph para3 = doc.Paragraphs.Add();
            para3.Range.Text = $"{Employee.SubdivisionNavigation.Name}";
            para3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            para3.Range.InsertParagraphAfter();
            
            Microsoft.Office.Interop.Word.Paragraph para7 = doc.Paragraphs.Add();
            para7.Range.Text = "\n";
            para7.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;

            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph para4 = doc.Paragraphs.Add();
            para4.Range.Text = "Заявление на получение мандата доступа";
            para4.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            para4.Range.Font.Size = 20;
            para4.Range.Font.Bold = 1;
            para4.Range.InsertParagraphAfter();

            para3.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph para5 = doc.Paragraphs.Add();
            para5.Range.Font.Size = 14;
            para5.Range.Font.Bold = 0;
            para5.Range.Text = $"Я, {Employee.Surname} {Employee.Name} {Employee.Patronomic} запрашиваю получение мандатного доступа для сотрудника цеха {employee.Surname} {employee.Name} {employee.Patronomic}.";
            para5.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para5.Range.InsertParagraphAfter();

            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();
            para7.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph para6 = doc.Paragraphs.Add();
            para6.TabStops.Add(signatureTabStopPosition, Microsoft.Office.Interop.Word.WdTabAlignment.wdAlignTabRight, WdTabLeader.wdTabLeaderSpaces);
            para6.Range.ParagraphFormat.TabStops.Add(app.InchesToPoints(6.5f), WdTabAlignment.wdAlignTabRight, WdTabLeader.wdTabLeaderDots);
            para6.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            para6.Range.Font.Size = 12;
            para6.Range.Text = DateTime.Now.ToString("d MMMM yyyy, HH:mm") + $"\t\t\t\t{Employee.Surname} {Employee.Name.First()}.{Employee.Patronomic.First()}.: ___________________";
            para6.Range.InsertParagraphAfter();


            app.Visible = true;
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

        private void SendRequestButton_Click(object sender, RoutedEventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0)
            {
                if (EmployeesDataGrid.SelectedItem != null)
                {
                    SendRequest((Employee)EmployeesDataGrid.SelectedItem);
                }
                else
                    Windows.MessageBox.Show("Уведомление", "Выберите сотрудника");
            }

            else if (TabControlMain.SelectedIndex == 1)
            {
                if (EmployeesListBox.SelectedItem != null)
                {
                    SendRequest((Employee)((UserControls.ForemanUserControl)EmployeesListBox.SelectedItem).DataContext);
                }
                else
                    Windows.MessageBox.Show("Уведомление", "Выберите сотрудника");
            }
        }
    }
}
