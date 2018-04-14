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
    public partial class Checkout : Form
    {
        List<CartItem> foodList;
        float total;
        public Checkout(List<CartItem> l, float t)
        {
            InitializeComponent();
            foodList = l;
            total = t;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
