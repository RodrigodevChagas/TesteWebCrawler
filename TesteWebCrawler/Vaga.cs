using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TesteWebCrawler
{
    public class Vaga
    {
        public void CrawlUrl(string urlDaVaga) 
        {
            //url, descrição, função, cidade
            //data, email, salario, empresa, home office

            WebClient client = new WebClient();
            HtmlDocument html = new HtmlDocument();

            string htmlString = client.DownloadString(urlDaVaga);
            html.LoadHtml(htmlString);

            var desc = html.DocumentNode.SelectSingleNode("//p[@class='mb-16 text-break white-space-pre-line']").InnerText;
            var funcao = html.DocumentNode.SelectSingleNode("//h2[@class='font-weight-bolder mb-4']").InnerText;
            var cidade = html.DocumentNode.SelectSingleNode("//div[@class='text-medium mb-4']").InnerText;
            string[] cidadeFormat = cidade.Split(',');

            Console.WriteLine($"{desc}");
            Console.WriteLine($"{funcao}");
            Console.WriteLine($"{cidadeFormat[0]}");
            Console.WriteLine();
        }
    }
}
