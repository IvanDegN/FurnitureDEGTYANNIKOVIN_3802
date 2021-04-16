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

            // while(String.IsNullOrEmpty(NameTextBox.Text))
            // {
            //     MessageBox.Show("Enter value in field 'Name'!", "Input error!");
            //     reg = false;
            //     NameTextBox.Focus();
            //     break;
            // }


            // while (String.IsNullOrEmpty(FirstNameTextBox.Text))
            // {
            //     MessageBox.Show("Enter value in fiele 'First name'!", "Input error!");
            //     reg = false;
            //     FirstNameTextBox.Focus();
            //     break;
            // }



            // while (String.IsNullOrEmpty(LastNameTextBox.Text))
            // {
            //     MessageBox.Show("Enter value in field 'last name'!", "Input error!");
            //     reg = false;
            //     LastNameTextBox.Focus();
            //     break;
            // }

            //while(String.IsNullOrEmpty(PasswordBox.Password))
            // {
            //     MessageBox.Show("Enter value in field 'Password'!", "Input error!");
            //     reg = false;
            //     PasswordBox.Focus();
            //     break;
            // }

            //while(String.IsNullOrEmpty(LoginTextBox.Text))
            // {
            //     MessageBox.Show("Enter value in field 'Login'!", "Input error!");
            //     reg = false;
            //     LoginTextBox.Focus();
            //     break;
            // }

            List<TextBox> textBoxes = new List<TextBox>() { First_Name, Name, Last_Name, Login  };
            List<String> rusWords = new List<string>() { "Имя", "Фамилия", "Отчество", "Логин" };

            
            
           

            foreach(TextBox tb in textBoxes)
            {
                if(tb.Text.Length == 0)
                {
                    MessageBox.Show("Field " + tb.Name + " is empty!");
                    reg = false;
                    tb.Focus();
                    
                }
            }


            


            if (!String.IsNullOrEmpty(Login.Text) && !String.IsNullOrEmpty(PasswordBox.Password))
            {

                foreach (var user in FurnityreBD.db.Fur_User)
                {
                    if (Login.Text == user.Login && PasswordBox.Password == user.Password)
                    {

                        MessageBox.Show("This user is exits yet!", "Error!");
                        reg = false;

                    }
                    else
                    {
                        MessageBox.Show("Not all important field is filled!", "Error!");
                        reg = false;
                    }
                }
                   
            }    
                   
       
                if (reg)
                {

                    Fur_User user = new Fur_User
                    {
                        FirstName = First_Name.Text,
                        LastName = Last_Name.Text,
                        Name = Name.Text,
                        Login = Login.Text,
                        Password = PasswordBox.Password,
                        Fur_Role = CbRoles.SelectedItem as Fur_Role,
                    };
                    FurnityreBD.db.Fur_User.Add(user);
                    FurnityreBD.db.SaveChanges();





                }
                else
                {
                    CheckRegistr(ref counter, charac);
                    MessageBox.Show("Error registration!", "Error!");
                }






            //  MessageBox.Show("U are entered incorrect data!", "Error!");



            //    MessageBox.Show("U are registered!","UwU:3");




           // CheckRegistr(ref counter, charac);
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