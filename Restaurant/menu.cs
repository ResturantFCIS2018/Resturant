using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace Restaurant
{
    class menu
    {
        public menu() { }
        public void addTomenu(Food item)
        {

            string filename = "menu.xml";
            if (!File.Exists(filename))
            { //First time to write
                XmlWriter writer = XmlWriter.Create(filename);
                writer.WriteStartElement("Menu");
                writer.WriteStartElement("item");

                writer.WriteStartElement("id");
                writer.WriteString(item.id);
                writer.WriteEndElement();

                writer.WriteStartElement("name");
                writer.WriteString(item.name);
                writer.WriteEndElement();

                writer.WriteStartElement("price");
                writer.WriteString(item.price.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("quantity");
                writer.WriteString(item.quantity.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("discount");
                writer.WriteString(item.discount.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.Close();
            }
            else
            { // Add to file
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);
                XmlElement Item = doc.CreateElement("item");
                XmlElement node = doc.CreateElement("id");
                node.InnerText = item.id;
                Item.AppendChild(node);

                node = doc.CreateElement("name");
                node.InnerText = item.name;
                Item.AppendChild(node);

                node = doc.CreateElement("price");
                node.InnerText = item.price.ToString();
                Item.AppendChild(node);

                node = doc.CreateElement("quantity");
                node.InnerText = item.price.ToString();
                Item.AppendChild(node);

                node = doc.CreateElement("discount");
                node.InnerText = item.discount.ToString();
                Item.AppendChild(node);

                XmlElement root = doc.DocumentElement;
                root.AppendChild(Item);

                doc.Save(filename);
            }
        }
        public List<Food> showMenu()
        {
            List<Food> Menu = new List<Food>();
            XmlDocument doc = new XmlDocument();
            string filename = "menu.xml";
            doc.Load(filename);
            XmlNodeList list = doc.GetElementsByTagName("item");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;
                string id_value = childerns[0].InnerText;
                string name_value = childerns[1].InnerText;
                string price_value = childerns[2].InnerText;
                string quantity_value = childerns[3].InnerText;
                string discount_value = childerns[4].InnerText;
                Food food = new Food(id_value, name_value, quantity_value, price_value, discount_value);
                Menu.Add(food);
            }
            return Menu;
        }
    }
}
