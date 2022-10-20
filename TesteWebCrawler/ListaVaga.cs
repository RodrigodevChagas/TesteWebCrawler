using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TesteWebCrawler
{
    public class ListaVaga
    {
        public void CrawlUrl(string url) 
        {
            Vaga vaga = new Vaga();
            var client = new WebClient();
            var html = new HtmlDocument();

            string htmlString = client.DownloadString(url);

            html.LoadHtml(htmlString);

            var listaDeUrl = html.DocumentNode.SelectNodes("//a[@class='text-decoration-none']/@href");

            foreach(var urlVaga in listaDeUrl)
            {
                string urlPadrao = "https://www.infojobs.com.br";
                string novaUrlVaga = urlPadrao + urlVaga.GetAttributeValue("href", null);
                vaga.CrawlUrl(novaUrlVaga);

            }
        }
    }
}
