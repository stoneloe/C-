using System;
using System.Linq;
using System.Collections.Generic;
namespace ProjectBasics
{
    public class DemoLambda
    {
        public delegate string GetAString();
        public delegate int ScaleBy10(int n);
        public int Id { get; set; } = 7;
        public DemoLambda()
        {
            Id = 1;
        }
        public void SimpleDelagate()
        {
            Console.WriteLine("\n\t DemoLambda.SimpleDelagate()...");

            // init delegate using delegate declaration:
            // public delegate string GetAString(); // declared in class above
            GetAString fM1 = new GetAString(ToString); // init delegate
            Console.WriteLine($"use GetAString() via fM1 delegate: '{fM1()}' ");
            GetAString fM2 = ToString;  // init delegate without 'new'
            Console.WriteLine($"use GetAString() via fM2 delegate: '{fM2()}' ");

            // init delegate using delegate declaration:
            // public delegate int ScaleBy10(int n); // declared in class above
            ScaleBy10 fM3 = new ScaleBy10(MultiplyByTen);
            Console.WriteLine($"use MultiplyByTen(27) via fM3 delegate: '{fM3(27)}' ");
            ScaleBy10 fM4 = MultiplyByTen;  // init delegate without 'new'
            Console.WriteLine($"use MultiplyByTen(27) via fM4 delegate: '{fM4(27)}' ");

            Console.WriteLine("\n\t DemoLambda.SimpleDelagate()... done!");
        }
        public void SimpleDelagateLambda()
        {
            Console.WriteLine("\n\t DemoLambda.SimpleDelegateLambda()...");

            // init delegate using delegate declaration:
            // public delegate string GetAString(); // declared in class above
            GetAString fL1 = () => "Lambda implements delegate GetAString";
            Console.WriteLine($"use GetAString() via fL1 delegate: '{fL1()}' ");

            // init delegate using delegate declaration:
            // public delegate string GetAString(); // declared in class above
            GetAString fM2 = () => this.ToString();
            Console.WriteLine($"use GetAString() via fM2 delegate: '{fM2()}' ");

            // init delegate using delegate declaration:
            // public delegate string GetAString(); // declared in class above
            GetAString fL2 = () => $"Lambda #{Id} implements delegate GetAString";
            Console.WriteLine($"use GetAString() via fL2 delegate: '{fL2()}' ");

            // init delegate using delegate declaration:
            // public delegate int ScaleBy10(int n); // declared in class above
            ScaleBy10 fL3 = n => n * 10;
            Console.WriteLine($"use ScaleBy10(27) via fL3 delegate: '{fL3(27)}' ");

            // init delegate using delegate declaration:
            // public delegate int ScaleBy10(int n); // declared in class above
            ScaleBy10 fM4 = n => this.MultiplyByTen(n);
            Console.WriteLine($"use MultiplyByTen(27) via fM4 delegate: '{fM4(27)}' ");

            Console.WriteLine("\n\t DemoLambda.SimpleDelegateLambda()... done!");
        }
        public void SimpleFuncDelagateLambda()
        {
            Console.WriteLine("\n\t DemoLambda.SimpleFuncDelegateLambda()...");

            Func<string> MyFunc = new Func<string>(ToString);
            Console.WriteLine($"use MyFunc() Func<string> delegate: '{MyFunc()}' ");

            Func<string> fL4 = () => ToString();
            Console.WriteLine($"use fL4() Func<string> delegate: '{fL4()}' ");

            int x = 7;
            // Funct< outType > delegate for method accepting no parameters and return
            Func<string> GetAStringF = () => $"Func<string> Lambda implementation '{x}'";
            Console.WriteLine($"use GetAStringF() Func<string> delegate: '{GetAStringF()}' ");

            // Funct< inType, outType > delegate: 1 param and return
            Func<int, int> ScaleBy10F2 = new Func<int, int>(MultiplyByTen);
            Console.WriteLine($"use ScaleBy10F2() Func<int,int> delegate: '{ScaleBy10F2(27)}' ");

            // Funct< inType, outType > delegate: 1 param and return
            Func<int, int> ScaleBy10F = (n) => n * 10;
            Console.WriteLine($"use ScaleBy10F() Func<int,int> delegate: '{ScaleBy10F(27)}' ");

            Console.WriteLine("\n\t DemoLambda.SimpleFuncDelegateLambda()... done!");
        }
        public void SimpleActionDelagateLambda()
        {
            Console.WriteLine("\n\t DemoLambda.SimpleActionDelagateLambda()...");

            // Action delegate for method accepting no parameters returning void
            Action MyActionFunc1 = () => Show();
            Console.Write($"use MyActionFunc1() Action delelgate: ");
            MyActionFunc1();

            // Action delegate for method accepting no parameters returning void
            Action MyActionFunc = new Action(Show);
            Console.Write($"use MyActionFunc2() Action delelgate: ");
            MyActionFunc();

            // Action delegate for method accepting no parameters returning void
            Action<string> MyActionFunc3 = (s) => ShowTitle(s);
            Console.Write($"use MyActionFunc3() Action<string> delegate: ");
            MyActionFunc3("ShowTitle");

            // Action delegate for method accepting no parameters returning void
            Action<string> MyActionFunc4 = new Action<string>(ShowTitle);
            Console.Write($"use MyActionFunc4() Action<string> delegate: ");
            MyActionFunc4("ShowTitle");

            Console.WriteLine("\n\t DemoLambda.SimpleActionDelagateLambda()... done!");
        }
        public int MultiplyByTen(int n)
        {
            return n * 10;
        }
        public void Show()
        {
            Console.WriteLine($"Show(): '{ToString()}'");
        }
        public void ShowTitle(string title)
        {
            Console.WriteLine($"{title}: '{ToString()}'");
        }
        public override string ToString()
        {
            return "DemoLambda.ToString() nothing here";
        }
        public void BasicSort()
        {
            Console.WriteLine("\n\t DemoLambda.BasicSort()...");
            List<int> numbers = new List<int>() { 2, 5, 1, 4, 3 };
            numbers.Sort();
            Console.Write("Sort DEFAULT ASCENDING: ");
            foreach (var n in numbers)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();
            numbers.Sort((n1, n2) => n2.CompareTo(n1));
            Console.Write("Sort DESCENDING: ");
            numbers.ForEach((n) => Console.Write($"{n}, "));
            Console.WriteLine("\n\t DemoLambda.BasicSort()... done!");
        }
        public void BasicFindAll()
        {
            Console.WriteLine("\n\t DemoLambda.BasicSort()...");
            List<int> numbers = new List<int>() { 2, 5, 1, 4, 3 };
            //numbers.Sort();
            Console.Write("FindAll ODD: ");
            foreach (var n in numbers.FindAll(e => (e % 2) == 1))
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();
            Console.WriteLine("\n\t DemoLambda.BasicSort()... done!");
        }
        public void BasicForEach()
        {
            Console.WriteLine("\n\t DemoLambda.BasicForEach()...");
            List<int> numbers = new List<int>() { 2, 5, 1, 4, 3 };
            numbers.Sort((n1, n2) => n2.CompareTo(n1));
            Console.Write($"{numbers.Count} numbers: ");
                foreach (var n in numbers)
            {
                Console.Write($"{n}, ");
            }
            int scale = 100;

            Console.Write($"SCALE by {scale}: ");
            // Lambda as Closure (using local variable scale)
            numbers.ForEach(e => Console.Write($"{e * scale}, "));

            Console.Write($"SCALE by 10: ");
            numbers.ForEach(e => { Console.Write($"{e * 10}, "); });

            scale = 1000;
            Console.Write($"SCALE by {scale}: ");
            // Lambda as Closure (using local variable scale)
            numbers.ForEach((e) => { Console.Write($"{e * scale}, "); });

            Console.Write($"SCALE by 10: ");
            numbers.ForEach((int e) => { Console.Write($"{e * 10}, "); });

            Console.Write($"{numbers.Count} numbers: ");
            foreach (var n in numbers)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();
            Console.WriteLine("\n\t DemoLambda.BasicForEach()... done!");
        }
        public void LambdaLINQ()
        {
            string[] words = { "bot", "apple", "apricot" };
            int minimalLength = words
              .Where(w => w.StartsWith("a"))
              .Min(w => w.Length);
            Console.WriteLine(minimalLength);   // output: 5

            int[] numbers = { 1, 4, 7, 10 };
            int product = numbers.Aggregate(1, (interim, next) => interim * next);
            Console.WriteLine(product);   // output: 280
        }
        public static void Demo()
        {
            Console.WriteLine("\n\t DemoLambda.Demo() ...");
            DemoLambda obj = new DemoLambda();
            obj.SimpleDelagate();
            obj.SimpleDelagateLambda();
            obj.SimpleFuncDelagateLambda();
            obj.SimpleActionDelagateLambda();
            obj.BasicSort();
            obj.BasicFindAll();
            obj.BasicForEach();
            obj.LambdaLINQ();

            Console.WriteLine("\n\t DemoLambda.Demo() ... done!");
        }
    }
}
