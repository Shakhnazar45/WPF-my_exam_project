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
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        OpenWindow Opw;
        public registration()
        {
            
            InitializeComponent();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            while(TextName1.Text != "" && TextName2.Text != "" && Email.Text != "" && Pass1.Text != "" && Pass2.Text != "")
            {
                if (Pass1.Text != Pass2.Text)
                {
                    Pass1.Text = "";
                    Pass2.Text = "";
                }
                int str;
                Pass1.Text = Pass1.Text.Length.ToString();
                str = Int32.Parse(Pass1.Text);
                if (str < 8)
                {
                    Pass1.Text = "";
                    Pass2.Text = "";
                    MessageBox.Show("Пароль не соответсвует норме");
                    break;
                }
                else
                {
                    Pass1.Text = "";
                    Pass2.Text = "";
                    Opw = new OpenWindow();
                    Opw.Show();
                    this.Close();
                    break;
                }

            }
            


        }
    }
}
