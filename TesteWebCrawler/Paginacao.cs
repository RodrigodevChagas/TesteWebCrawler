using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWebCrawler
{
    public class Paginacao
    {
        string url = "https://www.infojobs.com.br/vagas-de-emprego-adm.aspx?page=";

        public void CrawlUrl() {

            ListaVaga listaVaga = new ListaVaga();
            
            for (int i = 1; i <= 3; i++) 
            {
                string novaUrl = url + i;
                listaVaga.CrawlUrl(novaUrl);
            
            }
        
        }
    }
}
