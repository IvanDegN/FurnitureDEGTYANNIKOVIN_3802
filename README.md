# FurnitureDEGTYANNIKOVIN_3802
-- Realization validation all fields through loop while:
            while (String.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Enter value in field 'Name'!", "Input error!");
                reg = false;
                NameTextBox.Focus();
                break;
            }


            while (String.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("Enter value in fiele 'First name'!", "Input error!");
                reg = false;
                FirstNameTextBox.Focus();
                break;
            }



            while (String.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Enter value in field 'last name'!", "Input error!");
                reg = false;
                LastNameTextBox.Focus();
                break;
            }

            while (String.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Enter value in field 'Password'!", "Input error!");
                reg = false;
                PasswordBox.Focus();
                break;
            }

            while (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                MessageBox.Show("Enter value in field 'Login'!", "Input error!");
                reg = false;
                LoginTextBox.Focus();
                break;
            }
--end of realization // this is bad practice, but is works:)
