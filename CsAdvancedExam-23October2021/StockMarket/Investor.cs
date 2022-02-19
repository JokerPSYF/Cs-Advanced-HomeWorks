using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {

        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count => Portfolio.Count;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new List<Stock>();
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                MoneyToInvest -= stock.PricePerShare;
                Portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock stock = Portfolio.FirstOrDefault(x => x.CompanyName == companyName);

            if (stock == null)
            {
                return $"{companyName} does not exist.";
            }

            if (sellPrice < stock.PricePerShare)
            {
                return $"Cannot sell {stock.CompanyName}.";
            }

            Portfolio.Remove(stock);
            MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string name)
        {
            Stock stock = Portfolio.FirstOrDefault(x => x.CompanyName == name);

            if (stock != null)
            {
                return stock;
            }

            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count > 0)
            {
                Stock stock = Portfolio.OrderByDescending(x => x.MarketCapitalization).First();
                return stock;
            }

            return null;
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (Stock stock in Portfolio)
            {
                sb.AppendLine(stock.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
