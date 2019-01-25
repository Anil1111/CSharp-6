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

namespace WindowsFormsApp2
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {



            XmlDocument rssXmlDoc = new XmlDocument();
            //rssXmlDoc.Load("http://feeds.feedburner.com/techulator/articles");
            rssXmlDoc.Load(txtLink.Text);

            txtLink.Text = rssXmlDoc.InnerXml;

            
            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            StringBuilder rssContent = new StringBuilder();

        
            foreach (XmlNode rssNode in rssNodes)
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("link");
                string link = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("description");
                string description = rssSubNode != null ? rssSubNode.InnerText : "";

                lbConteudo.Items.Add("Titulo: " + title);
                lbConteudo.Items.Add("Link: " + link);
                lbConteudo.Items.Add("Descrição: " + description);


            }
        }
    }
}
