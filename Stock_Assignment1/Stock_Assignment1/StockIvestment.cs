using System;
using System.Collections;

namespace Stock_Assignment1
{
    class StockInvestment
    {
        static void Main(string[] args)
        {
            Stock stockOne = new Stock(1, 151.1, "GOOGLE", "Google Inc");
            Stock stockTwo = new Stock(2, 200.1, "IBM", "IBM Inc");
            Stock stockThree = new Stock(3, 35.2, "APPLE", "Apple Inc");

            ArrayList portfolio = new ArrayList();
            portfolio.Add(stockOne);
            portfolio.Add(stockTwo);
            portfolio.Add(stockThree);

            foreach (Stock s in portfolio)
            {
                Console.WriteLine(s);
            }
        }
    }
}
