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
    /// Логика взаимодействия для PageSubjects.xaml
    /// </summary>
    public partial class PageSubjects : Page
    {
        public PageSubjects()
        {
            InitializeComponent();
            subjectsDataGrid.ItemsSource = DB.Connection.Предметы.ToList();
        }
    }
}
