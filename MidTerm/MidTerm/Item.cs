using System;
using System.Collections.Generic;
namespace ProjectStockMarket
{
    public class Item : IComparable<Item>
    {
        public int Id { get; set; }
        public Decimal Price { get; set; }
        public String Name { get; set; }
        //public Item()
        //{
        //}

        public int CompareTo(Item other)
        {
            return Price.CompareTo(other.Price);
            //throw new NotImplementedException();
        }

        public static int CompareById(Item e1, Item e2)
        {
            return e1.Id.CompareTo(e2.Id);
            //throw new NotImplementedException();
        }

        public static int CompareByPrice(Item e1, Item e2)
        {
            return e1.Price.CompareTo(e2.Price);
            //throw new NotImplementedException();
        }

        public static int CompareByName(Item e1, Item e2)
        {
            return string.Compare(e1.Name, e2.Name);
            //throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"#{Id} ${Price} {Name}";
        }

        public static void Show(List<Item> items, string title)
        {
            Console.WriteLine($"{items.Count} elements: {title} ");
            foreach (var e in items)
            {
                Console.WriteLine(e);
            }

        }
        public static void Demo()
        {
            Console.WriteLine("\n\t Item.Demo()...");

            List<Item> items = new List<Item>
            {

                new Item {Id=1,Price=7.99M,Name="Chocolate"},
                new Item {Id=4,Price=1.99M,Name="Bread"},
                new Item {Id=3,Price=2.99M,Name="Milk"},
                new Item {Id=2,Price=3.99M,Name="Oj"}
            };
            foreach (var e in items)
            {
                Console.WriteLine(e);
            }

            items.Sort();
            Item.Show(items, "\n\t Sort items by Natural (IComparable default) order");

            items.Sort(Item.CompareByPrice);
            Item.Show(items, "\n\t Sort items by Price (IComparison) order");

            items.Sort(Item.CompareById);
            Item.Show(items, "\n\t Sort items by ID (IComparison) order");

            items.Sort(Item.CompareByName);
            Item.Show(items, "\n\t Sort items by Name (IComparison) order");

            Console.WriteLine("\n\t Item.Demo()... done!");
        }
    }
}
/* Console Output
ProjectStockMarket Program Main()...

     Item.Demo()...
#1 $7.99 Chocolate
#4 $1.99 Bread
#3 $2.99 Milk
#2 $3.99 Oj
4 elements: 
     Sort items by Natural (IComparable default) order 
#4 $1.99 Bread
#3 $2.99 Milk
#2 $3.99 Oj
#1 $7.99 Chocolate
4 elements: 
     Sort items by Price (IComparison) order 
#4 $1.99 Bread
#3 $2.99 Milk
#2 $3.99 Oj
#1 $7.99 Chocolate
4 elements: 
     Sort items by ID (IComparison) order 
#1 $7.99 Chocolate
#2 $3.99 Oj
#3 $2.99 Milk
#4 $1.99 Bread
4 elements: 
     Sort items by Name (IComparison) order 
#4 $1.99 Bread
#1 $7.99 Chocolate
#3 $2.99 Milk
#2 $3.99 Oj

     Item.Demo()... done!

    ProjectStockMarket Program Main()... done!


 */
