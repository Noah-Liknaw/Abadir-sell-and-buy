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
    public partial class Form1 : Form
    {
        public Form1()
        {
                InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var dbContext = new forLabEntities())
            {
                var myData = dbContext.users.ToList();
                foreach (var table in myData)
                {
                    
                }
            }
        }
    }
}
