using System;
namespace ProjectBasics
{
    public class CalcInteger : AbstractCalc
    {
        public int ArgA { get; set; }
        public int ArgB { get; set; }
        public int CalcResult { get; set; }

        public CalcInteger()
        {
        }
        /*
         * Parse CSV string:
         *      "ArgA, ArgB"
         * for example:
         *  "9,3"        
         */       
        public CalcInteger(string csvData)
        {
            string[] tokens = csvData.Split(',');
            ArgA = ParseInt(tokens[0]);     // string "9" parse to integer 9
            ArgB = ParseInt(tokens[1]);     // string "3" parse to integer 3
        }
        public int ParseInt(string s)
        {
            int n = 0;
            try
            {
                n = int.Parse(s);   // string to int
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*** Error: Can't Parse '{s}' to int. ***");
                Console.WriteLine(ex);
            }
            return n;
        }
        // AbstractCalc API implementation
        public override void Add()
        {
            CalcResult = ArgA + ArgB;
        }
        public override string ToString()
        {
            return $"{ArgA} + {ArgB} = {CalcResult}";
        }
        public static void Demo()
        {
            Console.WriteLine("\n\t CalcInteger.Demo()...");

            AbstractCalcFactory f = new CalcIntegerFactory();   // create a factory

            AbstractCalc obj = f.GetObject("9,3");  // use Factory Design Pattern
            //AbstractCalc obj = new CalcInteger() { ArgA = 9, ArgB = 3 };
            obj.Add();  // AbstractCalc API usage
            Console.WriteLine(obj); // ToString API usage

            //CalcInteger calcIntObj = new CalcInteger();
            //calcIntObj.ArgA = 9;
            //calcIntObj.ArgB = 3;
            //obj.Add();  // AbstractCalc API usage
            //Console.WriteLine($"{calcIntObj.ArgA} + {calcIntObj.ArgB} = {calcIntObj.CalcResult}");

            Console.WriteLine("\n\t CalcInteger.Demo()... done!");
        }
    }
}
