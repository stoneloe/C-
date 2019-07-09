using System;
using System.Collections.Generic;
namespace MDemo
{
    public abstract class AbstractStore
    {
        //public AbstractStore()
        //{
        //}

        public abstract void AddItem(AbstractItem item);
        public abstract void AddEmployee(Employee e);

        public abstract void SortInventory();
        public abstract void SortEmployees();

        public abstract void ShowInventory();
        public abstract void ShowEmployees();
    }

    public class Store : AbstractStore
    {
        private List<Employee> Employees { set; get; }
        private List<AbstractItem> Items { set; get; }

        public override void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }

        public override void AddItem(AbstractItem item)
        {
            Items.Add(item);
        }

        public override void ShowEmployees()
        {
            Employees.ForEach(e => Console.WriteLine(e.Id + " " + e.FirstName + " " + e.LastName + " " + e.Age));
        }

        public override void ShowInventory()
        {
            Items.ForEach(i => Console.WriteLine())
        }

        public override void SortEmployees()
        {
            throw new NotImplementedException();
        }


        public override void SortInventory()
        {
            throw new NotImplementedException();
        }
    }

    public class AppleStore : Store {

        public static void Demo() {
            Console.WriteLine("\n\t AppleStore.Demo()...");
            AppleStore obj = new AppleStore();

            obj.AddEmployee(new Employee(1, 18, "Worker", "Joe", 0.00));
            obj.AddEmployee(new Employee(2, 17, "Dan", "Peters", 63.45));
            obj.AddEmployee(new Employee(3, 67, "Ann", "Mason", 93.45));
            obj.AddEmployee(new Employee(4, 47, "Sam", "Jones", 53.45));
            obj.ShowEmployees();
            obj.SortEmployees();
            obj.ShowEmployees();



            obj.AddItem(new Iphone(1, 999.99, "IPHONE X MAX", "Verizon"));
            obj.AddItem(new Iphone(2, 899.99, "IPHONE X", "Sprint"));
            obj.AddItem(new Iphone(3, 849.99, "IPHONE X MAX", "TMobile"));

            obj.AddItem(new Ipad(4, 1049.99, "IPad Pro 256 GB", "WIFI"));
            obj.AddItem(new Ipad(5, 349.99, "IPad mini 32 GB", "WIFI"));
            obj.AddItem(new Ipad(6, 749.99, "IPad 128 GB", "4G"));

            obj.AddItem(new MacBook(7, 1799.99, "17 inch MacBook Pro", "Back-lite Keyboard"));
            obj.AddItem(new MacBook(8, 1299.99, "13 inch MacAir", "Back-lite Keyboard"));
            obj.ShowInventory();

            Console.WriteLine($"Sort Inventory [] BY PRICE");
            obj.SortInventory();
            obj.ShowInventory();

            Console.WriteLine("\n\t AppleStore.Demo()...done!");
        }
    }
}
