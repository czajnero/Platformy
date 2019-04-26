using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Core;
using ScrapySharp.Html.Parsing;
using ScrapySharp.Extensions;
using System.IO;

namespace JTTT
{
    class FindText : JTTTQuestion
    {
        public string Url { get; set; }
        public string SearchText { get; set; }
        public string EmailTo { get; set; }

        public string url;
        public string text;
        public String imageExt = null;
        public byte[] imageData = null;
        public MemoryStream stream = new MemoryStream();

        public FindText(string url, string searchtext, string emailto)
        {
            Url = url;
            SearchText = searchtext;
            EmailTo = emailto;
        }

        public override void Question()
        {
            DownloadHTML downloadHTML = new DownloadHTML();

            try
            {
                
                HtmlDocument htmlDoc = downloadHTML.DownloadHTMLDoc(Url);
                WebClient webClient = new WebClient();
                var nodes = htmlDoc.DocumentNode.Descendants("img");

                foreach (HtmlNode node in nodes)
                {
                    foreach (HtmlAttribute htmlAttribute in node.Attributes)
                    {
                        if (htmlAttribute.Value.ToLower().Contains(SearchText.ToLower()))
                        {
                            imageExt = node.GetAttributeValue("src");
                            imageData = webClient.DownloadData(imageExt);
                            stream = new MemoryStream(imageData);
                        }
                    }
                }



            }
            catch(Exception x)
            {

            }

        }

        private void GetParameters()
        {
            OutputParameters = new object[3];
            OutputParameters[0] = "Obrazek na dziś!";
            OutputParameters[1] = string.Format("Na stronie {0} znajduje się obrazek związany z hasłem '{1}'.", Url, SearchText);
            OutputParameters[2] = stream;
        }


        public override string ToString()
        {
            return string.Format("Uri={0} TextToFind={1}", Url, SearchText);
        }

    }
}
