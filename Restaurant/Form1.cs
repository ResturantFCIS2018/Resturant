using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Menu : Form
    {
        List<CartItem> cart;
        float total;
        public Menu()
        {
            InitializeComponent();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Checkout f = new Checkout(cart,total);
            f.Show();
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            //add selected food to cart
            //update cartgridview
            //calculate total
        }
    }
}
