using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XVG_Bot
{
    class GetHTML
    {
        private async void getPage(string webpage)
        {
            webpage = "http://www.zpool.ca/?address=DS84yaFaMn5HBJgiTMF9FQKkS17CytjKmn";
            HttpClient http = new HttpClient();
            var response = await http.GetByteArrayAsync(webpage);
            String source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
            source = WebUtility.HtmlDecode(source);
            //HtmlDocument doc = new HtmlDocument();

            //HtmlWeb web = new HtmlWeb();
        }
        
    }
}
