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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text, email = textBox2.Text, phone = textBox3.Text, passwd = textBox4.Text;
            var newUser = new user { name = name, email = email, phone = phone, password = passwd };
            
            using (var dbContext = new forLabEntities())
            {
                var myData = dbContext.users.Add(newUser);
                dbContext.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
