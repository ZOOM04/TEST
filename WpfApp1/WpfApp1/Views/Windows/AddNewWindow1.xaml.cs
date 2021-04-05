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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddNewWindow1.xaml
    /// </summary>
    public partial class AddNewWindow1 : Window
    {
        public AddNewWindow1()
        {
            InitializeComponent();
        }

        private void BtnDob_Click(object sender, RoutedEventArgs e)
        {
            
            if (TBox.Text != null && DPicker.Text != null && TBox2.Text != null && TBox3.Text != null && TBox4.Text != null && TBox5.Text != null && TBox6.Text != null && CBox.Text != null && CBox2.Text != null)
            {
                MessageBox.Show("Данные были успешно добавлены!");
            }
            else
            {
                throw new Exception("Заполните все поля!");
            }
        }

        private void TBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
