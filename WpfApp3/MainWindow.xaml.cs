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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool id = false;
        bool pass = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Password.Text == )
            {
                pass = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (id && pass == true)
            {
                this.Close();
                Window1 search = new Window1();
                search.Show();
            }
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Username.Text == )
            {
                id = true;
            }
        }
    }
}
