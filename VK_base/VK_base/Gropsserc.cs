using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Gropsserc : Form
    {
       public string access_token;
       public string user_id;
       string text;
        public Gropsserc()
        
            
        {
            
            InitializeComponent();
        }

        private void Gropsserc_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string request = "https://api.vk.com/method/users.get.xml?fields=photo_100&access_token=" + access_token + "&v=5.62";
            doc.Load(request);
            if (doc.InnerXml.Contains("error"))
            {
                MessageBox.Show("Ошибка получения данных о пользователе!");
            }
            foreach (XmlNode level1 in doc.SelectNodes("response"))
            {
                foreach (XmlNode level2 in level1.SelectNodes("user"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("first_name"))
                    {
                        label1.Text = level3.InnerText;
                    }
                    foreach (XmlNode level3 in level2.SelectNodes("last_name"))
                    {
                        label2.Text = level3.InnerText;
                    }
                    foreach (XmlNode level3 in level2.SelectNodes("photo_100"))
                    {
                        pictureBox1.ImageLocation = level3.InnerText;
                    }
                }
            }
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDocument serh = new XmlDocument();
            string ser = "https://api.vk.com/method/groups.search.xml?q=" + text + "&access_token=" + access_token + "&v=5.62";
            ser = ser.Replace("#", "%23");
            ser = ser.Replace(" ", "%20");
            serh.Load(ser);
            if (serh.InnerXml.Contains("error"))
            {
                MessageBox.Show("Ошибка получения данных о пользователе!");
            }
            foreach (XmlNode level1 in serh.SelectNodes("response"))
            {
                listView1.Items.Clear();
                foreach (XmlNode level2 in level1.SelectNodes("items"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("group"))
                    {
                        string name = "";
                        string id = "";
                        foreach (XmlNode level4 in level3.SelectNodes("id"))
                        {
                            id = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("name"))
                        {
                            name = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("photo_50"))
                        {
                            pictureBox2.Load(level4.InnerText);
                        }
                        listView1.Items.Add(id,name,imageList1.Images.Count-1);
                        imageList1.Images.Add(pictureBox2.Image);
                        Application.DoEvents();
                        //https://api.vk.com/method/groups.getMembers?group_id=" + id + "&access_token=" + access_token + "&v=5.62";
                           
                    }
                    
                }
            }
        }    
    }
}
