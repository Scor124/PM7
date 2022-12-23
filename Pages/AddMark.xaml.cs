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
    /// Логика взаимодействия для AddMark.xaml
    /// </summary>
    public partial class AddMark : Page
    {
        public AddMark()
        {
            InitializeComponent();
            cmbStudents.ItemsSource = DB.Connection.Студенты.ToList();
            cmbStudents.SelectedIndex = 0;
            dtpMarkDate.SelectedDate= DateTime.Now;
            cmbSubjects.ItemsSource = DB.Connection.Предметы.ToList();
            cmbSubjects.SelectedIndex = 0;
            cmbMark.ItemsSource = new List<byte>() { 2,3,4,5 };
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            DB.Connection.Оценки.Add(new Оценки
            {
                Код_студента = (cmbStudents.SelectedItem as Студенты).Код_студента,
                Дата_экзамена = dtpMarkDate.SelectedDate,
                Код_предмета = (cmbSubjects.SelectedItem as Предметы).Код_предмета,
                Оценка = Convert.ToByte(cmbMark.SelectedItem)
            });
            DB.Connection.SaveChanges();
            NavigationService.GoBack(); 
        }
    }
}
