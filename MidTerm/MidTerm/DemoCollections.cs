using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace ProjectBasics
{
    public class DemoCollections
    {
        // private list of persons in model (DemoCollections)
        public List<MyPerson> DemoCollectionsPersonsList { set; get; } =
            new List<MyPerson>() {
                new MyPerson {Id=1,Age=18,FirstName="Dan",LastName="Peters"},
                new MyPerson {Id=2,Age=67,FirstName="George",LastName="Washington"},
                new MyPerson {Id=3,Age=65,FirstName="John",LastName="Adams"}
            };

        // private list of students in model (DemoCollections)
        public List<MyStudent> DemoCollectionsStudents { set; get; } =
            new List<MyStudent>() {
                new MyStudent {Id=1,Age=18,FirstName="Dan",LastName="Peters",StudentId=4001,Gpa=3.9},
                new MyStudent {Id=2,Age=17,FirstName="Pam",LastName="Jones",StudentId=4002,Gpa=4.0},
                new MyStudent {Id=3,Age=25,FirstName="Sam",LastName="Adams",StudentId=4003,Gpa=3.7}
            };

        private struct MyItem
        {
            public int Id { get; set; }
            public Decimal Price { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return $"#{Id} ${Price:F2} {Name}";
            }
        }
        //public class PhoneNumber {
        //    public List<int> AreaCode { get; set; } = new List<int> { 6,0,3 };
        //    public List<int> Number = new List<int> { 5, 5, 5, 1, 2, 1, 2 };

        //    public override string ToString()
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.Append("(");
        //        AreaCode.ForEach(n => sb.Append(n));
        //        sb.Append(") ");
        //        Number.ForEach(n => sb.Append(n));

        //        return sb.ToString();
        //    }
        //}

        public class PhoneNumber {
            public List<int> AreaCode { set; get; } = new List<int> { 6, 0, 3 };
            public List<int> Number = new List<int> { 5, 5, 5, 1, 2, 1, 2 };

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                AreaCode.ForEach(a => sb.Append(a));
                sb.Append(")");
                Number.ForEach(n => sb.Append(n));

                return sb.ToString();
            }
        }

        //public class MyPerson : IComparable<MyPerson>
        //{
        //    public int Id { get; set; }
        //    public int Age { get; set; }
        //    public String FirstName { get; set; }
        //    public String LastName { get; set; }
        //    public class PersonComparer : IComparer<MyPerson>
        //    {
        //        public int Compare(MyPerson p1, MyPerson p2)
        //        {
        //            return string.Compare(p1.LastName, p2.LastName);
        //        }
        //    }

        //    // Comparison<T> to customize Sort(Comparison<T>);
        //    public static int CompareById(MyPerson p1, MyPerson p2)
        //    {
        //        return p1.Id.CompareTo(p2.Id);
        //    }
        //    // Comparison<T> to customize Sort(Comparison<T>);
        //    public static int CompareByAge(MyPerson p1, MyPerson p2)
        //    {
        //        return p1.Age.CompareTo(p2.Age);
        //    }
        //    // Comparison<T> to customize Sort(Comparison<T>);
        //    public static int CompareByFirstName(MyPerson p1, MyPerson p2)
        //    {
        //        return string.Compare(p1.FirstName, p2.FirstName);
        //    }
        //    // Comparison<T> to customize Sort(Comparison<T>);
        //    public static int CompareByLastName(MyPerson p1, MyPerson p2)
        //    {
        //        return string.Compare(p1.LastName, p2.LastName);
        //    }

        //    public int CompareTo(MyPerson other)
        //    {
        //        return string.Compare(this.LastName, other.LastName);
        //        //throw new NotImplementedException();
        //    }
        //    public override string ToString()
        //    {
        //        return $"#{Id} {FirstName} {LastName}, age {Age}";
        //    }
        //}

        public class MyPerson : IComparable<MyPerson>
        {
            public int Id { set; get; }
            public int Age { set; get; }
            public string FirstName { set; get; }
            public string LastName { set; get; }

            public class PersonComparer : IComparer<MyPerson>
            {
                public int Compare(MyPerson p1, MyPerson p2)
                {
                    return string.Compare(p1.LastName, p2.LastName);
                }
            }

            public int CompareTo(MyPerson other)
            {
                return string.Compare(this.LastName, other.LastName);
            }

            public static int CompareById(MyPerson p1, MyPerson p2) {
                return p1.Id.CompareTo(p2.Id);
            }

            public static int CompareByAge(MyPerson p1, MyPerson p2) {
                return p1.Age.CompareTo(p2.Age);
            }

            public static int CompareByLastName(MyPerson p1, MyPerson p2) {
                return string.Compare(p1.LastName, p2.LastName);
            }

            public static int CompareByFirstName(MyPerson p1, MyPerson p2) {
                return string.Compare(p1.FirstName, p2.FirstName);
            }

            public override string ToString()
            {
                return $"#{Id} {FirstName} {LastName}, age {Age}";
            }
        }

        public class MyStudent : MyPerson, IComparable<MyStudent>
        {
            public int StudentId { get; set; }
            public double Gpa { get; set; }
            public class StudentComparer : IComparer<MyStudent>
            {
                public int Compare(MyStudent s1, MyStudent s2)
                {
                    return s1.Gpa.CompareTo(s2.Gpa);
                }
            }
            // For Natural Default order IComparable<T>
            public int CompareTo(MyStudent other)
            {
                return this.Gpa.CompareTo(other.Gpa);
                //throw new NotImplementedException();
            }
            public override string ToString()
            {
                return $"#{Id} {FirstName} {LastName} [{StudentId}], age {Age}, GPA {Gpa:#.0} ";
                //return $"#{Id} {FirstName} {LastName} [{StudentId}], age {Age}, GPA {Gpa:F2} ";
            }
        }

        public interface IEmployable
        {
            int EmployeeID { get; set; }
            string Name { get; set; }
            Decimal Wage { get; set; }
            string GetCompanyName();
            string SetCompanyName();
            int GetEmployeeId();
            int SetEmployeeId();
            Decimal GetWage();
            Decimal SetWage();
        }

        //public DemoCollections()
        //{
        //}

        public void UseArray()
        {
            // Boxing value types for non-generic collections is time consuming
            Console.WriteLine("DemoCollections.UseArray()...");
            int[] numbers = { 2, 1, 3 };

            int n2 = (int)numbers[0];
            foreach (var n in numbers) { Console.Write($"{n}, "); }

            Console.WriteLine("DemoCollections.UseArray()... done!");
        }
        public void UpdateArray()
        {
            // Boxing value types for non-generic collections is time consuming
            Console.WriteLine("DemoCollections.UpdateArray()...");

            int[] numbers = { 2, 1, 3 };
            foreach (var n in numbers) { Console.Write($"{n}, "); }

            for (int i = 0; i < numbers.Length; i++) { numbers[i] = ++numbers[i]; }
            foreach (var n in numbers) { Console.Write($"{n}, "); }

            int[] updatedNumbers = new int[3];
            for (int i = 0; i < numbers.Length; i++) { updatedNumbers[i] = ++numbers[i]; }
            foreach (var n in updatedNumbers) { Console.Write($"{n}, "); }

            Console.WriteLine("\n\t DemoCollections.UpdateArray()... done!");
        }
        public void UseArrayList()
        {
            // Boxing value types for non-generic collections is time consuming
            Console.WriteLine("DemoCollections.UseArrayList()...");
            var numbers = new ArrayList(); // non-generic Collection
            // boxing: Value Type to Reference Type
            numbers.Add(7);         // Literal Int

            // Add Objects
            //numbers.Add("Danny");
            //numbers.Add(new MyPerson {Id=1,Age=18,FirstName="Dan",LastName="Peters" } );

            // unboxing: Reference type to Value type
            int n2 = (int)numbers[0];
            foreach (var n in numbers) { Console.WriteLine($"{n}"); }
        }
        public void ListNumbers()
        {
            Console.WriteLine("\n\t DemoCollections.ListNumbers()...");
            List<int> numbers = new List<int>() { 5,3,2,4,1 };
            Console.WriteLine($" List contains {numbers.Count} of {numbers.Capacity}");
            numbers.Add(0);
            Console.WriteLine($" List contains {numbers.Count} of {numbers.Capacity}");
            foreach (var number in numbers) Console.Write($"{number}, ");
            Console.WriteLine($" First {numbers[0]} Last {numbers[numbers.Count - 1]}");
            numbers.Sort();
            foreach (var number in numbers) Console.Write($"{number}, ");
            Console.WriteLine($" First {numbers[0]} Last {numbers[numbers.Count - 1]}");
        }
        public void ListNames()
        {
            Console.WriteLine("\n\t DemoCollections.ListNames()...");
            List<string> names = new List<string>() { "Dan", "Ann" };
            Console.WriteLine($" List contains {names.Count} of {names.Capacity}");
            names.Add("Sam");
            Console.WriteLine($" List contains {names.Count} of {names.Capacity}");
            names.Add("Joe");
            Console.WriteLine($" List contains {names.Count} of {names.Capacity}");
            names.Add("Sue");
            Console.WriteLine($" List contains {names.Count} of {names.Capacity}");
            foreach (var name in names) Console.Write($"{name}, ");
            Console.WriteLine($" First {names[0]} Last {names[names.Count - 1]}");
            names.Sort();
            foreach (var name in names) Console.Write($"{name}, ");
            Console.WriteLine($" First {names[0]} Last {names[names.Count - 1]}");
        }
        public void ListPersons()
        {
            Console.WriteLine("\n\t DemoCollections.ListPersons()...");
            List<MyPerson> persons = DemoCollectionsPersonsList;
            //List<MyPerson> persons = new List<MyPerson>() {
            //    new MyPerson() {Id=1,Age=18,FirstName="Dan",LastName="Peters"},
            //    new MyPerson() {Id=2,Age=67,FirstName="George",LastName="Washington"},
            //    new MyPerson() {Id=3,Age=65,FirstName="John",LastName="Adams"}
            //};
            Console.WriteLine($" List contains {persons.Count} of {persons.Capacity} {typeof(MyPerson)} {persons.GetType()}");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]}, Last: {persons[persons.Count - 1]}");
            string sortTitle = null;
            persons.Sort();
            Console.WriteLine("\n\t Sort by Default Order (IComparable)");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]} Last: {persons[persons.Count - 1]}");

            persons.Sort(MyPerson.CompareById);
            Console.WriteLine("\n\t Sort by ID (Comparison<T>)");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]} Last: {persons[persons.Count - 1]}");

            persons.Sort(MyPerson.CompareByAge);
            Console.WriteLine("\n\t Sort by Age (Comparison<T>)");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]} Last: {persons[persons.Count - 1]}");

            persons.Sort((p1, p2) => p2.Age.CompareTo(p1.Age));
            Console.WriteLine("\n\t Sort by Age (Comparison<T> Lambda Oldest first)");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]} Last: {persons[persons.Count - 1]}");

            sortTitle = "\n\t Sort by First Name (Comparison<T>)";
            Console.WriteLine($"{sortTitle}");

            persons.Sort(MyPerson.CompareByFirstName);
            SortPersons(persons, "SortPersons: " + sortTitle, MyPerson.CompareByFirstName);

            //Console.WriteLine("\n\t Sort by First Name (Comparison<T>)");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]} Last: {persons[persons.Count - 1]}");

            persons.Sort(MyPerson.CompareByLastName);
            sortTitle = "\n\t Sort by Last Name (Comparison<T>)";
            SortPersons(persons, "SortPersons: " + sortTitle, (MyPerson p1, MyPerson p2) => p1.LastName.CompareTo(p2.LastName));
            Console.WriteLine($"{sortTitle}");
            foreach (var person in persons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {persons[0]} Last: {persons[persons.Count - 1]}");
        }
        // Supply a Comparison delegate to customize Sort(Comparison<T>)
        public void SortPersons(List<MyPerson> list, string title, Comparison<MyPerson> c)
        {
            Console.WriteLine("\n\t DemoCollections.SortPersons()...");

            Console.WriteLine($"{title} {list.Count} elements in list.");
            DemoCollectionsPersonsList = list;  // initialize private list in model 
            SortPersons(title, c);  // sort the private list in the model
            //list.Sort(c);   // sort using supplied Comparison<T> delegate
            //foreach (var person in list) Console.Write($"{person}, ");
            //Console.WriteLine($" First: {list[0]} Last: {list[list.Count - 1]}");

            //Console.WriteLine("\n\t DemoCollections.SortPersons()... done!");
        }
        // Sort the private list in the model
        // Supply a Comparison delegate to customize Sort(Comparison<T>)
        public void SortPersons(string title, Comparison<MyPerson> c)
        {
            Console.WriteLine("\n\t DemoCollections.SortPersons()...");

            Console.WriteLine($"{title} {DemoCollectionsPersonsList.Count} elements in list.");
            DemoCollectionsPersonsList.Sort(c);   // sort using supplied Comparison<T> delegate
            DemoCollectionsPersonsList.ForEach(person => Console.Write($"{person}; "));
            //foreach (var person in DemoCollectionsPersons) Console.Write($"{person}, ");
            Console.WriteLine($" First: {DemoCollectionsPersonsList[0]} Last: {DemoCollectionsPersonsList[DemoCollectionsPersonsList.Count - 1]}");

            Console.WriteLine("\n\t DemoCollections.SortPersons()... done!");
        }
        public void UpdatePersons()
        {
            Console.WriteLine("\n\t DemoCollections.UpdatePersons()... ");
            int offset = 100;
            Console.WriteLine($"{DemoCollectionsPersonsList.Count} persons in list.");
            DemoCollectionsPersonsList.ForEach(person => Console.Write($"{person}; "));
            Console.WriteLine($"\nAge by {offset} years:");
            DemoCollectionsPersonsList.ForEach(p => p.Age = p.Age+offset);
            DemoCollectionsPersonsList.ForEach(person => Console.Write($"{person}; "));

            Console.WriteLine("\n\t DemoCollections.UpdatePersons()... done!");
        }
        public void UseDictionary()
        {
            Console.WriteLine("\n\t DemoCollections.UseDictionary()... ");
            Dictionary<string, string> states = new Dictionary<string, string>
            {
                { "NH", "New Hampshire" } ,
                { "NV", "Nevada" },
                { "NE", "Nebraska" },
                { "NY", "New York" },
                { "NM", "New Mexico" },
                { "NJ", "New Jersey" },
                { "ND", "North Dakota" },
                { "NC", "North Carolina" }
            };
            string state = "NH";
            Console.WriteLine($"{state} is {states[state]}");

            Console.WriteLine("\n\t DemoCollections.UseDictionary()... done!");
        }
        public void UseStudentDictionary()
        {
            Console.WriteLine("\n\t DemoCollections.UseStudentDictionary()... ");
            Dictionary<int, MyPerson> personMap = new Dictionary<int, MyPerson>();
            Dictionary<int, MyStudent> studentMap = new Dictionary<int, MyStudent>();

            foreach (MyStudent s in DemoCollectionsStudents)
            {
                personMap.Add(s.Id, s);     // person dictionary
                studentMap.Add(s.Id, s);    // student dictionary
            }
            int personId = 2;
            Console.WriteLine($"Person ID {personId} is {personMap[personId]}");
            Console.WriteLine($"Person ID {personId} is {studentMap[personId]}");

            Console.WriteLine("\n\t DemoCollections.UseStudentDictionary()... done!");
        }
        public void UsePhoneNumber()
        {
            Console.WriteLine("\n\t DemoCollections.UsePhoneNumber()... ");

            PhoneNumber myNumber = new PhoneNumber();
            Console.WriteLine(myNumber);
            Console.WriteLine("\n\t DemoCollections.UsePhoneNumber()... done!");
        }

        /*
         * UpdatePhoneNumber: 
         *         
         * Update a list of reference values using a for loop.
         * 
         * 
         * Why can't change value in foreach?
         * https://social.msdn.microsoft.com/Forums/vstudio/en-US/a90c87be-9553-4d48-9892-d482ee325f02/why-cant-change-value-in-foreach?forum=csharpgeneral       
         * 
         * As my mother would say, "Because I said so."  ;)
         * 
         * This is all about IEnumerable<T>  You are given access to the items, but not the container -- there may not even be a container.
         * 
         * But seriously, start by reading what the MSDN page has to say about foreach, in.  Assuming you read that, then you are now aware that foreach is used to access an IEnumerable, which is all about "here is each item" and abstracts away the notion of where each item came from.  This means that you are presented with each item from a collection, but the containing collection itself is not part of the IEnumerable abstraction.  It also means that you are not aware of the variable, or storage that stored each item of the collection (if it is a value type) or the variable or storage that stored the reference to each item of the collection (if it is a reference type) and you are certainly not aware of the collection itself (to add / remove / re-index items in the collection).
         * 
         * So again, try to remember this.  As soon as you say foreach you are talking about just the items in the collection, and not the collection itself.
         * 
         * foreach does not say "for each storage location in an array". And you'll be better off if you avoid thinking that it does.  And it's not even like saying "make a list of all the things in the array, and now talk about that list" because there is no list.  It simply iterates over each item in a collection.  In C# we call that "enumerating" but that's a terrible word because there is no number associated with this so-called "enumeration". IEnumerable should really be called something like IIteratable.  It's just something where you can say "Give me the next thing" and "are there any more things?"  -- and so whenever you say "foreach", you are only able to say those two things.
         * ---
         * 
         * Now if you'd rather examine and possibly modify each storage location in an array, then just use a regular for loop. 
         * 
         *      int[] intArray = { 1, 2, 3, 4, 5 };
         *      for( int index = 0; index < intArray.Length; ++index ) {
         *          // intArray[index] is the storage location of the item
         *          // at the given index
         *      }
         *
         */
        public void UpdatePhoneNumber()
        {
            Console.WriteLine("\n\t DemoCollections.UpdatePhoneNumber()... ");

            List<PhoneNumber> myNumberList = new List<PhoneNumber>()
            {
                 // U.S. Naval Observatory's time-by-phone line (202-762-1401
                 new PhoneNumber { AreaCode= new List<int>() { 2,0,2 }, Number= new List<int>() { 7,6,2,1,4,0,1 } },
                 // The Telecompute Corporation provides transport and content for local and national weather and information lines (603-266-1212)
                 new PhoneNumber { AreaCode= new List<int>() { 2,1,2 }, Number= new List<int>() { 2,6,6,1,2,1,2} },
                 // The Telecompute Corporation provides transport and content for local and national weather and information lines (617-266-1212)
                 new PhoneNumber { AreaCode= new List<int>() { 6,1,7 }, Number= new List<int>() { 2,6,6,1,2,1,2} }
            };

            List<PhoneNumber> newNumberList = new List<PhoneNumber>()
            {
                 // Weather Ready Nation NH (603-225-5191)
                 new PhoneNumber { AreaCode= new List<int>() { 6,0,3 }, Number= new List<int>() { 2,2,5,5,1,9,1 } },
                 // Weather Ready Nation Long Island, NY (631-924-0517)
                 new PhoneNumber { AreaCode= new List<int>() { 6,3,1 }, Number= new List<int>() { 9,2,4,0,5,1,7} },
                 // Weather Ready Nation Mass (508-822-0634)
                 new PhoneNumber { AreaCode= new List<int>() { 5,0,8 }, Number= new List<int>() { 8,2,2,0,6,3,4} }
            };
            Console.WriteLine($"{myNumberList.Count} phone numbers in original list");
            myNumberList.ForEach(n => Console.WriteLine(n));

            // use for loop to update List<T>
            for (int i=0; i < myNumberList.Count; i++)
            {
                myNumberList[i] = newNumberList[i];
                //n.AreaCode = new List<int>() { 6,0,3 };
                //n.Number = new List<int>() { 2, 2, 5, 5, 1, 9, 1 };
            }
            Console.WriteLine($"{myNumberList.Count} phone numbers in UPDATED list");
            myNumberList.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("\n\t DemoCollections.UpdatePhoneNumber()... done!");
        }
        public void UseStructure()
        {
            Console.WriteLine("\n\t DemoCollections.UseStructure()... ");

            MyItem myItem = new MyItem() { Id = 1, Price = 1.39M, Name = "Bread" };
            Console.WriteLine(myItem);
            Console.WriteLine("\n\t DemoCollections.UseStructure()... done!");
        }
        public void UpdateStructure()
        {
            Console.WriteLine("\n\t DemoCollections.UpdateStructure()... ");

            List<MyItem> list = new List<MyItem>
            {
                new MyItem {Id=1,Price=1.39M,Name="Bread"},
                new MyItem {Id=2,Price=3.69M,Name="OJ"},
                new MyItem {Id=3,Price=2.49M,Name="Milk"}
            };
            Console.WriteLine($"{list.Count} Items in ORIGINAL shopping list:");
            list.ForEach(e => Console.WriteLine(e));

            // CAN NOT modify a list of value types
            Console.WriteLine("CAN NOT modify a list of value types with ForEach loop:");
            Console.WriteLine($"{list.Count} 10% INFLATED Items in shopping list:");
            list.ForEach(e => e.Price = e.Price * 1.10M);
            list.ForEach(e => Console.WriteLine(e));

            // CAN NOT modify a list of value types
            Console.WriteLine("CAN NOT modify a list of value types with ForEach loop:");
            Console.WriteLine($"{list.Count} 10% DISCOUNTED Items in shopping list:");
            list.ForEach(e => e.Price = e.Price * 0.90M);
            list.ForEach(e => Console.WriteLine(e));

            // CAN NOT modify a list of value types
            Console.WriteLine("CAN NOT modify a list of value types with for loop:");
            Console.WriteLine($"{list.Count} 10% INFLATED Items FOR shopping list:");
            // list of struct so var e is a value type and a ONLY copy of list entry value type
            for (int i = 0; i < list.Count; i++) { var e = list[i]; e.Price = e.Price * 1.10M; }
            // COMPILER ERROR: Cannot modify the return value of list[i] as it is NOT a variable.
            //for (int i = 0; i < list.Count; i++) { list[i].Price = e.Price * 1.10M; }
            list.ForEach(e => Console.WriteLine(e));

            // CAN NOT modify a list of value types
            Console.WriteLine("CAN NOT modify a list of value types with for loop:");
            Console.WriteLine($"{list.Count} 10% DISCOUNTED Items FOR shopping list:");
            // list of struct so var e is a value type and a ONLY copy of list entry value type
            for (int i = 0; i < list.Count; i++) { var e = list[i]; e.Price = e.Price * 0.90M; }
            // COMPILER ERROR: Cannot modify the return value of list[i] as it is NOT a variable.
            //for (int i = 0; i < list.Count; i++) { list[i].Price = e.Price * 0.90M; }

            list.ForEach(e => Console.WriteLine(e));

            // must create a new list of value types with modified entries
            Console.WriteLine("must create a new list of value types with modified entries:");
            Console.WriteLine($"{list.Count} 10% INFLATED Items in shopping list:");
            List<MyItem> listInflated = new List<MyItem>();
            list.ForEach(e => { e.Price = e.Price * 1.10M; listInflated.Add(e); });
            listInflated.ForEach(e => Console.WriteLine(e));

            // must create a new list of value types with modified entries
            Console.WriteLine("must create a new list of value types with modified entries:");
            Console.WriteLine($"{list.Count} 10% DISCOUNTED Items in shopping list:");
            List<MyItem> listDiscounted = new List<MyItem>();
            list.ForEach(e => { e.Price = e.Price * 0.90M; listDiscounted.Add(e); });
            listDiscounted.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\n\t DemoCollections.UpdateStructure()... done!");
        }
        public static void Demo()
        {
            Console.WriteLine("\n\t DemoCollections.Demo()...");
            DemoCollections obj = new DemoCollections();
            obj.UseArray();
            obj.UpdateArray();
            obj.UseArrayList();

            obj.ListNames();
            obj.ListNumbers();
            obj.ListPersons();  // IComparable
            obj.UpdatePersons();

            obj.UseDictionary();
            obj.UseStudentDictionary();
            obj.UsePhoneNumber();
            obj.UseStructure();
            obj.UpdateStructure();
            obj.UpdatePhoneNumber();

            Console.WriteLine("\n\t DemoCollections.Demo()... done!");
        }
    }
}
