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

namespace FurnitureDEGTYANNIKOVIN_3802
{
    /// <summary>
    /// Логика взаимодействия для Associate_Director.xaml
    /// </summary>
    public partial class Associate_Director : Window
    {
        public Associate_Director()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            LogingForm logingForm = new LogingForm();
            logingForm.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            logingForm.Show();
            this.Close();
        }
    }
}
