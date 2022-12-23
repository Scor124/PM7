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
using ПМ._07_Соадминистрирование.Pages;

namespace ПМ._07_Соадминистрирование
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mainframe.Content = new Page()
            {
                Content = new Label()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Content = "Добро пожаловать"
                }
            };
        }
        // Page Students
        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(new PageStudents());
        }
        // Page Subjects
        private void btnSubjects_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(new PageSubjects());
        }
        // Page Education
        private void btnEducation_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(new PageEducation());
        }
    }
}
