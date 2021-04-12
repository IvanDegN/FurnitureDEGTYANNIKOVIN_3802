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

namespace FurnitureDEGTYANNIKOVIN_3802
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LogingForm : Window
    {
        public LogingForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            bool login = false;
            int IdRole = 0;
            foreach (var users in FurnityreBD.db.Fur_User)
            {
                if(LoginTextBox.Text == users.Login && PasswordPasswordBox.Password == users.Password)
                {
                    login = true;
                    IdRole = users.Id_Role;
                    break;
                }
            }

            if(login)
            {
                switch (IdRole)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;
                }
            }
        }

        private void CancelBth_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
