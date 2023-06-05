using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace УППО_Пропуски.Windows
{
    /// <summary>
    /// Логика взаимодействия для MessageBox.xaml
    /// </summary>
    public partial class MessageBox : Window
    {
        public MessageBox(string title, string caption)
        {
            InitializeComponent();

            this.Title = title;
            this.CaptionTextBlock.Text = caption;
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        public static void Show(string title, string caption)
        {
            MessageBox messageBox = new MessageBox(title, caption);
            SystemSounds.Beep.Play();
            messageBox.ShowDialog();
        }
    }
}
