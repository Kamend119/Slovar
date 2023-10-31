using System;
using System.Collections;
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

namespace task._24._10._23
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            if (TextBox_for_cout.Text != "")
            {
                List1.Items.Add(TextBox_for_cout.Text);
            }
            
        }

        private void Button_Click_remove(object sender, RoutedEventArgs e)
        {
            if (TextBox_for_cout.Text != "")
            {
                List1.Items.Remove(TextBox_for_cout.Text);
            }
        }

        private void Button_Click_removeat(object sender, RoutedEventArgs e)
        {
            if (TextBox_for_cout.Text != "")
            {
                List1.Items.RemoveAt(Convert.ToInt32(TextBox_for_cout.Text));
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Insert(object sender, RoutedEventArgs e)
        {
            if (TextBox_for_cout.Text != "")
            {
                List1.Items.Insert(List1.AlternationCount, TextBox_for_cout.Text);
            }
        }
    }
}
