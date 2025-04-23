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
using System.Windows.Shapes;

namespace Proect_8.MVVM.View.AddWindow
{
    /// <summary>
    /// Логика взаимодействия для AddNewPositionWindow.xaml
    /// </summary>
    public partial class AddNewPositionWindow : Window
    {
        public AddNewPositionWindow()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void CheckingText(object sender, RoutedEventArgs e)
        //{
        //    Regex regex = new Regex("[^9-0]+");
        //    e.Handled = regex.IsMatch(e.Text);
        //}
    }
}
