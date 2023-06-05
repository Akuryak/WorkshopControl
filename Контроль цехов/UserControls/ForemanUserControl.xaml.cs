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
    /// Логика взаимодействия для ForemanUserControl.xaml
    /// </summary>
    public partial class ForemanUserControl : UserControl
    {
        public ForemanUserControl(Employee employee)
        {
            InitializeComponent();

            DataContext = employee;

            FullNameTextBlock.Text += $"{employee.Surname} {employee.Name} {employee.Patronomic}";
            GenderTextBlock.Text += employee.Gender;
            BirthdateTextBlock.Text += employee.Birthdate.ToShortDateString();
            DivisionTextBlock.Text += employee.SubdivisionNavigation == null ? "-" : employee.SubdivisionNavigation.Name;
            StatusTextBlock.Text += employee.Status;
            CanVisitOtherWorkshopsCheckBox.IsChecked = employee.CanVisitOtherWorkshops == 1 ? true : false;
            IsVerificatedCheckBox.IsChecked = employee.IsVerificated == 1 ? true : false;

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
    }
}
