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

            
            List<TextBox> textBoxes = new List<TextBox>() { TbName, TbFamilyName, TbMiddleName, TbLogin  };
            


            foreach(TextBox tb in textBoxes)
            {
                if(String.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Field " + tb.Name + " is empty!");
                    reg = false;
                    tb.Focus();
                    
                }
            }


            


            if (!String.IsNullOrEmpty(TbLogin.Text) && !String.IsNullOrEmpty(PasswordBox.Password))
            {

                foreach (var user in BD.db.Fur_User)
                {
                    if (TbLogin.Text == user.Login && PasswordBox.Password == user.Password)
                    {

                        MessageBox.Show("This user is exits yet!", "Error!");
                        reg = false;

                    }
                    else
                    {
                        MessageBox.Show("You are registered!", "UwU:3");
                        break;
                    }
                    
                }
                   
            }    
                   
       
                if (reg)
                {

                    Fur_User user = new Fur_User
                    {
                        FamilyName = TbFamilyName.Text,
                        Name = TbName.Text,
                        MiddleName = TbName.Text,
                        Login = TbLogin.Text,
                        Password = PasswordBox.Password,
                        Fur_Role = CbRoles.SelectedItem as Fur_Role,
                    };
                    BD.db.Fur_User.Add(user);
                    BD.db.SaveChanges();





                }
                else
                {
                    CheckRegistr(ref counter, charac);
                    MessageBox.Show("Error registration!", "Error!");
                }






            
        }
   

        private bool CheckRegistr(ref int counter, char[] charac)
        {
            while(String.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Field 'Password' is should filled! ");
                break;
            }
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
            BD.db.Fur_Role.Load();
            BD.db.Fur_User.Load();
            CbRoles.ItemsSource = BD.db.Fur_Role.ToList();
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
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