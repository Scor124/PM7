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

namespace ПМ._07_Соадминистрирование.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEducation.xaml
    /// </summary>
    public partial class PageEducation : Page
    {
        public PageEducation()
        {
            InitializeComponent();
            educationDataGrid.ItemsSource = DB.Connection.Оценки.ToList();
        }

        private void txtFindStudent_TextChanged(object sender, TextChangedEventArgs e)
        {
            educationDataGrid.ItemsSource = DB.Connection.Оценки.Where(x=> x.Студенты.ФИО.StartsWith(txtFindStudent.Text)).ToList();
        }

        private void btnAddMark_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMark());
            educationDataGrid.ItemsSource = DB.Connection.Оценки.ToList();
        }
    }
}
