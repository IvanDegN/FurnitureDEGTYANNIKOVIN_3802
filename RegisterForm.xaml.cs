using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            int counter = 1;
            bool reg = true;
            char[] charac = { '*', '&', '{', '}', '|', '+' };
            CheckRegistr(ref counter, charac);

            if (reg)
            {
                try
                {
                    Fur_User user = new Fur_User
                    {
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        Name = NameTextBox.Text,
                        Login = LoginTextBox.Text,
                        Password = PasswordBox.Password,
                        Fur_Role = CbRoles.SelectedItem as Fur_Role,
                    };
                    FurnityreBD.db.Fur_User.Add(user);
                    FurnityreBD.db.SaveChanges();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error registration!", "Error!");

                }
                finally
                {
                    MessageBox.Show("Registration is successful!", "Successfull!");
                    Close();
                }
            }
            else
            {
                CheckRegistr(ref counter, charac);
            }

            
        }
   

        private bool CheckRegistr(ref int counter, char[] charac)
        {
            bool reg;
            if (PasswordBox.Password.Length < 6 || PasswordBox.Password.Length > 18)
            {
                MessageBox.Show("Password is should contains from 6 before 18 chars!", "Warning!"); reg = false;
            }

            else if (!PasswordBox.Password.Any(c => charac.Contains(c)))
            {
                MessageBox.Show("Password is should contains follow symbols: * & {} | +", "Warning!"); reg = false; ;
            }

            else if (!PasswordBox.Password.Any(d => char.IsDigit(d)))
            {
                MessageBox.Show("Password is should contains numbers!", "Warning!"); reg = false;
            }
            else reg = true;

            for(int i = 1; i < PasswordBox.Password.Length; i++)
            {
                if (PasswordBox.Password[i] == PasswordBox.Password[i - 1]) counter++;
                else counter = 1;
                if (counter >= 3)
                {
                    MessageBox.Show("Password is contains three repeat in a row symbols!", "Warning!"); reg = false;
                }
                else reg = true;
            }

            return reg;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FurnityreBD.db.Fur_Role.Load();
            FurnityreBD.db.Fur_User.Load();
            CbRoles.ItemsSource = FurnityreBD.db.Fur_Role.ToList();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
    }