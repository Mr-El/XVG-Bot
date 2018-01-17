using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XVG_Bot
{
    public partial class XVGWindow : Form
    {
        public XVGWindow()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLAdd ua = new URLAdd();
            ua.ShowDialog();
        }

        private void elementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiveElements ge = new GiveElements();
            ge.ShowDialog();
        }

        private void uRLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            URLAdd ua = new URLAdd();
            ua.ShowDialog();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author ar = new Author();
            ar.ShowDialog();
        }

        private async void getPage(string webpage)
        {
            webpage = "http://www.zpool.ca/?address=DS84yaFaMn5HBJgiTMF9FQKkS17CytjKmn";
            HttpClient http = new HttpClient();
            var response = await http.GetByteArrayAsync(webpage);
            String source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
            source = WebUtility.HtmlDecode(source);
            //HtmlDocument doc = new HtmlDocument();

        }
    }
}
