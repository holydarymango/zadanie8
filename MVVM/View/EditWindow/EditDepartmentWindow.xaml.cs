using Proect_8.MVVM.Model;
using Proect_8.MVVM.ViewModel;
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

namespace Proect_8.MVVM.View.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditDepartmentWindow.xaml
    /// </summary>
    public partial class EditDepartmentWindow : Window
    {
        public EditDepartmentWindow(Department department)
        {
            InitializeComponent();
            MainViewModel.SelectedDepartment = department;
            MainViewModel.DepartmentName = department.DepartmentName;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
