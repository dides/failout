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
        public string[] grup = new string[2];
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
                        
                        foreach (XmlNode level4 in level3.SelectNodes("name"))
                        {
                            grup[0] = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("id"))
                        {
                            grup[1] = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("photo_50"))
                        {
                            pictureBox2.Load(level4.InnerText);
                        }
                       listView1.Items.Add(id,name,imageList1.Images.Count-1);
                       imageList1.Images.Add(pictureBox2.Image);
                        Application.DoEvents();
                       
                        ListViewItem grups = new ListViewItem(grup,imageList1.Images.Count - 1);
                        listView1.Items.Add(grups);
                    }
                    
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listView1.SelectedItems[0].SubItems[1].Text; 
            //listView1.SelectedItems[0].SubItems[0].Text;
           //listView3 = listView1.SelectedItems[0].SubItems[1].Text;
          // listView3.Items.Add(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text); //listView1.SelectedItems[0].SubItems[0].Text;
            
            if (listView1.SelectedItems.Count > 0)
            {
                listView3.Items.Add(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[0].Text); //listView1.SelectedItems[0].SubItems[0].Text;
                XmlDocument ser = new XmlDocument();
                string groupsmembers = "https://api.vk.com/method/groups.getMembers.xml?user_id=" + user_id + "&access_token=" + "&fields=photo_100,first_name,last_name" + access_token + "&group_id=" + grup[1] + "&v=5.62"; 
//foreach (XmlNode ud in ser.SelectNodes("response")) 
                ser.Load(groupsmembers);
                //listView1.SelectedItems.Count = listView1.SelectedItems.Count + 1;
               

                foreach (XmlNode level1 in ser.SelectNodes("response"))
                {
                    //listView2.Items.Clear();
                    foreach (XmlNode level2 in level1.SelectNodes("items"))
                    {
                        string name = "";
                        string id = "";
                        foreach (XmlNode level3 in level2.SelectNodes("user"))
                        {
                        foreach (XmlNode level4 in level3.SelectNodes("id"))
                        {
                            id = level4.InnerText;
                           
                            // listView1.Items.Add(id,name,imageList1.Images.Count-1);
                            //imageList1.Images.Add(pictureBox2.Image);
                           //Application.DoEvents();
                        }
                        foreach(XmlNode level4 in level3.SelectNodes("first_name"))
                        {
                            name = level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("last_name"))
                        {
                            name = name + level4.InnerText;
                        }
                        foreach (XmlNode level4 in level3.SelectNodes("photo_100"))
                        {
                            pictureBox2.Load(level4.InnerText);
                        }
                        listView2.Items.Add(id, name, imageList2.Images.Count - 1);
                        imageList2.Images.Add(pictureBox2.Image);
                        Application.DoEvents();
                        ListViewItem grups = new ListViewItem(name,id);
                        
                           // Application.DoEvents();
                            
                            //listView2.Items.Add(grups);

                            foreach (ListViewItem item in listView2.Items)
                            {
                              string filter = "https://api.vk.com/method/groups.groups.isMember.xml?group_id" + grup[1] + "&user_id=" + user_id + "&v=5.62";
                            }
                           
                        }

                    }
                }
                
                
            }
            
        }    
    }
}
