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
using System.IO;
namespace Restaurant
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        public void Menu_show()
        {
            menu.Rows.Clear();
            menu.Columns.Clear();
            XmlDocument doc = new XmlDocument();
            string filename = "menu.xml";
            doc.Load(filename);
            XmlNodeList list = doc.GetElementsByTagName("item");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;
                string id_value = childerns[0].InnerText;
                string id = childerns[0].Name;

                string name_value = childerns[1].InnerText;
                string name = childerns[1].Name;

                string price_value = childerns[2].InnerText;
                string price = childerns[2].Name;

                string quantity_value = childerns[3].InnerText;
                string quantity = childerns[3].Name;

                string discount_value = childerns[4].InnerText;
                string discount = childerns[4].Name;
                if (menu.ColumnCount == 0)
                {
                    menu.Columns.Add("ID", id);
                    menu.Columns.Add("NAME", name);
                    menu.Columns.Add("PRICE", price);
                    menu.Columns.Add("Quantity", quantity);
                    menu.Columns.Add("Discount", discount);
                }
                menu.Rows.Add(new string[] { id_value, name_value, price_value, quantity_value, discount_value });

            }
        }

        public void Boys_show()
        {
            menu.Rows.Clear();
            menu.Columns.Clear();
            XmlDocument doc = new XmlDocument();
            string filename = "deliveryboy.xml";
            doc.Load(filename);
            XmlNodeList list = doc.GetElementsByTagName("boy");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;

                string name_value = childerns[0].InnerText;
                string name = childerns[0].Name;

                string phone_value = childerns[1].InnerText;
                string phone = childerns[1].Name;

                string assignedArea_value = childerns[2].InnerText;
                string assignedArea = childerns[2].Name;
                if (menu.ColumnCount == 0)
                {
                menu.Columns.Add("NAME", name);
                menu.Columns.Add("PRICE", phone);
                menu.Columns.Add("assignedArea", assignedArea);
                }
                menu.Rows.Add(new string[] { name_value, phone_value, assignedArea_value });

            }
        }
        private void adminPanel_Load(object sender, EventArgs e)
        {
            Boys_show(); // Defult
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
        
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            string ID = id.text;
            string name = itemname.text;
            string Quan = quan.text;
            string Price = price.text;
            string disc = discount.text;

            Food item = new Food(ID, name,Quan, Price, disc);
            menu MENU = new menu();
            if (item.validFOOD())
            {
                MENU.addTomenu(item);
                MessageBox.Show("Item has been Added Successfully\t\t", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Please Enter Valid Data\t\t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 

            }
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void del_boy_Click(object sender, EventArgs e)
        {
        }

        private void addBoy_Click(object sender, EventArgs e)
        {
            string boyname  = name.text;
            string phonenum = phonenumber.text;
            string boy_area = ass_area.SelectedValue.ToString();
          
            DeliveryBoy new_boy = new DeliveryBoy(boyname, phonenum, boy_area);
            if (new_boy.validBOY())
            {
                new_boy.add();
                MessageBox.Show("Delivery Boy has been Added Successfully\t\t", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Enter Valid Data\t\t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            Menu_show();
        }

        private void showboyes_Click(object sender, EventArgs e)
        {
            Boys_show();
        }
    }
}
