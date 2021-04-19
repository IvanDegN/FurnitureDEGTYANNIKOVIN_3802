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
            try
            {
            bool login = false;
            int IdRole = 0;
            Fur_Role NameRole = new Fur_Role();
            foreach (var users in BD.db.Fur_User)
            {
                if(LoginTextBox.Text == users.Login && PasswordPasswordBox.Password == users.Password)
                {
                    login = true;
                    IdRole = users.Id_Role;
                    NameRole = users.Fur_Role;
                    break;
                }
                
            }


                if (login)
                {
                    MessageBox.Show($"U are logged as {NameRole}");
                    switch (IdRole)
                    {
                        case 1:
                            Associate_Director associate_Director = new Associate_Director();
                            associate_Director.Show();

                            break;

                        case 2:
                            Customer customer = new Customer();
                            customer.Show();

                            break;

                        case 3:
                            Director director = new Director();
                            director.Show();

                            break;

                        case 4:
                            Master master = new Master();
                            master.Show();

                            break;

                        case 5:
                            Manager manager = new Manager();
                            manager.Show();

                            break;

                        default:
                            MessageBox.Show("Error!");
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Incorrect data in field Login or Password!");
                    
                }

            

            
            }
            catch(Exception)
            {
                MessageBox.Show("Error auth!");
            }
        }

        private void CancelBth_Click(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Text = "";
            PasswordPasswordBox.Password = "";
            MessageBox.Show("u are clicked on 'Cancel'!","Warning!");
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
