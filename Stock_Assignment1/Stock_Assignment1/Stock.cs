using System;
namespace Stock_Assignment1
{
    public class Stock : AbstractStock
    {
        public int Id;
        public double Price;
        public string Symbol;
        public string Name;

        public Stock()
        {
        }

        public Stock(int Id, double Price, string Symbol, string Name) {
            this.Id = Id;
            this.Price = Price;
            this.Symbol = Symbol;
            this.Name = Name;
        }

        public override double Update(int percentChange)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"#Id: {Id} Price: ${Price} Symbol:{Symbol} Name:{Name} ";
        }
    }
}
