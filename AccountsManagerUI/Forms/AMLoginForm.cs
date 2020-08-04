using AccountsManagerUI.Classes;
using AccountsManagerUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsManagerUI
{
    public partial class AccountsManagerLoginForm : Form
    {
        UserManager UM = new UserManager();
        public AccountsManagerLoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpSubmitButton_Click(object sender, EventArgs e)
        {
            UM.CreateUser(SignUpFirstNameTextBox.Text, SignUpLastNameTextBox.Text, SignUpUsernameTextBox.Text, SignUpPasswordTextBox.Text, SignUpConfirmPasswordTextBox.Text, SignUpEmailAddressTextBox.Text);

        }

        private void LogInSubmitButton_Click(object sender, EventArgs e)
        {
            Form amHubForm = new AMHubForm(UM);
            amHubForm.Show();
            this.Hide();
        }
    }
}
