using System;
namespace ProjectBasics
{
    public class CalcDouble : AbstractCalc
    {
        public double ArgA { get; set; }
        public double ArgB { get; set; }
        public double CalcResult { get; set; }

        public CalcDouble()
        {
        }
        /*
         * Parse CSV string:
         *      "ArgA, ArgB"
         * for example:
         *  "9.6,3.2"        
         */
        public CalcDouble(string csvData)
        {
            string[] tokens = csvData.Split(',');
            ArgA = ParseDouble(tokens[0]);     // string "9.6" parse to double 9.6
            ArgB = ParseDouble(tokens[1]);     // string "3.2" parse to double 3.2
        }
        public double ParseDouble(string s)
        {
            double n = 0;
            try
            {
                n = double.Parse(s);   // string to double
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*** Error: Can't Parse '{s}' to double. ***");
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
            Console.WriteLine("\n\t CalcDouble.Demo()...");

            AbstractCalc obj = new CalcDouble() { ArgA = 9.3, ArgB = 3.3 };
            obj.Add();  // AbstractCalc API usage
            Console.WriteLine(obj); // ToString API usage

            //Console.WriteLine($"{obj.ArgA} + {obj.ArgB} = {obj.CalcResult}");

            Console.WriteLine("\n\t CalcDouble.Demo()... done!");
        }
    }
}
