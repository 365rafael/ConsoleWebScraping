using ConsoleWebScraping.DTOs;
using HtmlAgilityPack;

namespace ConsoleWebScraping
{
    public class IbovespaWebScraping
    {
        public IbovespaInfoDTO GetIbovespaInfo()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.infomoney.com.br/cotacoes/ibovespa/");

            var ibovespaPointsNode = doc.DocumentNode.SelectNodes("//div[@class='value']/p");
            var ibovespaPercentageNode = doc.DocumentNode.SelectNodes("//div[@class='percentage']/p");
            var ibovespaTotalPoints = ibovespaPointsNode[0].InnerText.Trim();//trim remove espaços
            var ibovespaPercentageVariation = ibovespaPercentageNode[0].InnerText.Trim();
            return new IbovespaInfoDTO(ibovespaTotalPoints, ibovespaPercentageVariation);
        }
    }
}