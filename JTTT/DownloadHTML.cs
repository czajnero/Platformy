using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using ScrapySharp.Core;
using ScrapySharp.Html.Parsing;
using ScrapySharp.Extensions;
using System.Net.Mail;
using System.IO;


namespace JTTT
{
    class DownloadHTML
    {

        public HtmlDocument DownloadHTMLDoc(String htmlAddressTextBox)
        {
            try
            {
                WebClient webClient = new WebClient();
                String data = webClient.DownloadString(htmlAddressTextBox);
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(data);
                return htmlDocument;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Blad");
            }

            return null;
        }
    }
}