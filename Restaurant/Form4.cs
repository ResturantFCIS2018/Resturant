using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Restaurant
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            //add Food to xml file Menu.xml
        }

        private void dbAddBtn_Click(object sender, EventArgs e)
        {
            //add DeliveryBoy to xml file DeliveryBoys.xml
        }

        private void login_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Take a deep breath then think", "Sorry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void username_OnTextChange(object sender, EventArgs e)
        {
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void password_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            admin user = new admin(username.text , password.text);
            if (user.login(user))
            {
                adminPanel form = new adminPanel();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error with Username OR Password \t\t\n Try Again !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
