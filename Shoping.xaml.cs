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

namespace Examination_project
{
    /// <summary>
    /// Логика взаимодействия для Shoping.xaml
    /// </summary>
    public partial class Shoping : Window
    {
        OpenWindow Opw;
        FirstP Fp;
        SecondP Sp;
        ThirdP Tp;
        FourthP Frp;
        public Shoping()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Opw = new OpenWindow();
            Opw.Show();
            this.Close();
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            Fp = new FirstP();
            Fp.Show();
        }
        private void second_Click(object sender, RoutedEventArgs e)
        {
            Sp = new SecondP();
            Sp.Show();
        }
        private void third_Click(object sender, RoutedEventArgs e)
        {
            Tp = new ThirdP();
            Tp.Show();
        }
        private void fourth_Click(object sender, RoutedEventArgs e)
        {
            Frp = new FourthP();
            Frp.Show();
        }
    }
}
