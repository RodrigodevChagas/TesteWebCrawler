using HtmlAgilityPack;
using System.Net;

namespace TesteWebCrawler
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Paginacao paginacao = new Paginacao();
            paginacao.CrawlUrl();
        }
    }
}
