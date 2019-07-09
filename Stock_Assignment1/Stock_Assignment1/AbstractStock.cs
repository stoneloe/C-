using System;
namespace Stock_Assignment1
{
    public abstract class AbstractStock
    {
        public AbstractStock()
        {
        }

        public abstract double Update(int percentChange);
    }
}
