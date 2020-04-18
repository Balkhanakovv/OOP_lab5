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

namespace WPF_Info
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();

            Employee employee = new Employee("Vladimir", "Balkhanakov", 19, "SibSUTIS");
            this.DataContext = employee;
            EmpImg.Source = new BitmapImage(new Uri("pack://application:,,,/resources/123.jpg"));

            CallBt.Click += CallBt_Click;
            WriteBt.Click += WriteBt_Click;
            AddBt.Click += AddBt_Click;
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавляем");
        }

        private void WriteBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пишем");
        }

        private void CallBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Звоним");
        }
    }
}
