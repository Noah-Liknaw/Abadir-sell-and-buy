using Abadir_buy_and_sell_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abadir_buy_and_sell_app
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredEmail = textBox2.Text, enteredPasswd = textBox4.Text;
            bool correctInfo = false;
            using (var dbContext = new forLabEntities())
            {
                var myData = dbContext.users.ToList();
                foreach (var user in myData)
                {
                    string emailFromTable = user.email.Trim();
                    string passwordFromTable = user.password.Trim();
                    if (emailFromTable.Equals(enteredEmail) && passwordFromTable.Equals(enteredPasswd)){
                        correctInfo = true;
                    }
                }
            }

            if (correctInfo == true)
            {
                MessageBox.Show("Login successful!!");
            }
            else
            {
                MessageBox.Show("Login failed..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
