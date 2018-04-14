using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Restaurant
{
    class admin
    {
        private string username, password;
        public admin(string name , string pass)
        {
            username = name;
            password = pass;
        }
        public bool login(admin user)
        {
            bool found = false;
            XmlDocument adminFile = new XmlDocument();
            adminFile.Load("admins.xml");
            XmlNodeList admins = adminFile.GetElementsByTagName("admin");
            for (int i = 0; i < admins.Count; i++)
            {
                XmlNodeList childerns = admins[i].ChildNodes;
                string savedName      = childerns[0].InnerText;
                string savedPassword  = childerns[1].InnerText;
                found = (savedName == user.username && savedPassword == user.password) ? true : false;
                if (found) { break; }
            }
            return found;
        }
    }
}
