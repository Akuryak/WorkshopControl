using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace УППО_Пропуски.Assets.Helpers
{
    internal class FrameManager
    {
        public static Frame MainFrame { private get; set; }

        public static void Navigate(Page page, string title)
        {
            if (App.Current.Windows.OfType<MainWindow>().FirstOrDefault() != null)
            {
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().Title = title;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().MinHeight = page.MinHeight + 30;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().MinWidth = page.MinWidth + 30;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().Width = page.Width;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().Height = page.Height;
            }
            MainFrame.Navigate(page);
        }

        public static void Navigate(Page page)
        {
            if (App.Current.Windows.OfType<MainWindow>().FirstOrDefault() != null)
            {
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().Title = page.Title;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().MinHeight = page.MinHeight + 30;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().MinWidth = page.MinWidth + 30;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().Width = page.Width;
                App.Current.Windows.OfType<MainWindow>().FirstOrDefault().Height = page.Height;
            }
            MainFrame.Navigate(page);
        }
    }
}
