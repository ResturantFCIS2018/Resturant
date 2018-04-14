using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace Restaurant
{
    public class DeliveryBoy
    {
        string name;
        string phone;
        string assignedArea;
        public DeliveryBoy(string name , string phone , string area)
        {
            this.name         = name;
            this.phone        = phone;
            this.assignedArea = area;
        }
        public bool validBOY()
        {
            if (this.assignedArea == "" || this.name == "" || (this.phone == "" && this.phone.Length !=11))
            {return false;}
            return true;
        }
        public void add()
        {
                string filename = "deliveryboy.xml";
                if (!File.Exists(filename))
                {
                    XmlWriter writer = XmlWriter.Create(filename);
                    writer.WriteStartElement("DeliveryBoy");
                    writer.WriteStartElement("boy");

                    writer.WriteStartElement("name");
                    writer.WriteString(this.name);
                    writer.WriteEndElement();

                    writer.WriteStartElement("phone");
                    writer.WriteString(this.phone);
                    writer.WriteEndElement();

                    writer.WriteStartElement("assignedArea");
                    writer.WriteString(this.assignedArea);
                    writer.WriteEndElement();


                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.Close();
                } else {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filename);
                    XmlElement boy = doc.CreateElement("boy");
                    XmlElement node = doc.CreateElement("name");
                    node.InnerText = this.name;
                    boy.AppendChild(node);

                    node = doc.CreateElement("phone");
                    node.InnerText = this.phone;
                    boy.AppendChild(node);

                    node = doc.CreateElement("assignedArea");
                    node.InnerText = this.assignedArea;
                    boy.AppendChild(node);

                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(boy);

                    doc.Save(filename);
                }
            
           

        }
    }
}
