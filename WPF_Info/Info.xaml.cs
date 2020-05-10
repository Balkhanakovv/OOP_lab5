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

            CallBt.Click += CallBt_Click;
            WriteBt.Click += WriteBt_Click;
            AddBt.Click += AddBt_Click;
        }

        //=======================Emp Name===========================================================
        public static readonly DependencyProperty EmpNameProperty = DependencyProperty.Register(
            "EName",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, EmpNameChanged));

        public string EName
        {
            get { return (string)GetValue(EmpNameProperty); }
            set { SetValue(EmpNameProperty, value); }
        }

        private static void EmpNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var EmpNameForm = obj as Info;
            EmpNameForm.EmpName.Text = EmpNameForm.EName.ToString();
        }


        //=======================Emp Surname===========================================================
        public static readonly DependencyProperty EmpSurnameProperty = DependencyProperty.Register(
            "ESurame",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, EmpSurnameChanged));

        public string ESurname
        {
            get { return (string)GetValue(EmpSurnameProperty); }
            set { SetValue(EmpSurnameProperty, value); }
        }

        private static void EmpSurnameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var EmpSurnameForm = obj as Info;
            EmpSurnameForm.EmpSurname.Text = EmpSurnameForm.ESurname.ToString();
        }


        //=======================Emp Age===========================================================
        public static readonly DependencyProperty EmpAgeProperty = DependencyProperty.Register(
           "EAge",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, EmpAgeChanged));

        public string EAge
        {
            get { return (string)GetValue(EmpAgeProperty); }
            set { SetValue(EmpAgeProperty, value); }
        }

        private static void EmpAgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var EmpAgeForm = obj as Info;
            EmpAgeForm.EmpAge.Text = EmpAgeForm.EAge.ToString();
        }


        //=======================Emp Age===========================================================
        public static readonly DependencyProperty EmpCompanyProperty = DependencyProperty.Register(
           "ECompany",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, EmpCompanyChanged));

        public string ECompany
        {
            get { return (string)GetValue(EmpCompanyProperty); }
            set { SetValue(EmpCompanyProperty, value); }
        }

        private static void EmpCompanyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var EmpCompanyForm = obj as Info;
            EmpCompanyForm.EmpCompany.Text = EmpCompanyForm.ECompany.ToString();
        }


        //=======================Emp Img===========================================================
        public static readonly DependencyProperty EmpImgProperty = DependencyProperty.Register(
           "EImg",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, EmpImgChanged));

        public string EImg
        {
            get { return (string)GetValue(EmpImgProperty); }
            set { SetValue(EmpImgProperty, value); }
        }

        private static void EmpImgChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var EmpImgForm = obj as Info;
            EmpImgForm.EmpImg.Source = new BitmapImage(new Uri($"pack://application:,,,/{EmpImgForm.EImg}"));
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
