using System;
namespace MDemo
{
    public abstract class AbstractItem
    {
        
    }

    public class Item : AbstractItem, IComparable<Item>
    {
        public int Id { set; get; }
        public double Price { set; get; }
        public string Name { set; get; }
        public string Mode { set; get; }

        public int CompareTo(Item other)
        {
            return Convert.ToInt32(this.Price - other.Price);
        }
    }

    public class Iphone : Item {
        public Iphone(int Id, double Price, string Name, string Mode) {
            this.Id = Id;
            this.Price = Price;
            this.Name = Name;
            this.Mode = Mode;
        }
    }

    public class Ipad : Item {
        public Ipad(int Id, double Price, string Name, string Mode)
        {
            this.Id = Id;
            this.Price = Price;
            this.Name = Name;
            this.Mode = Mode;
        }
    }

    public class MacBook : Item {
        public MacBook(int Id, double Price, string Name, string Mode)
        {
            this.Id = Id;
            this.Price = Price;
            this.Name = Name;
            this.Mode = Mode;
        }
    }
}
