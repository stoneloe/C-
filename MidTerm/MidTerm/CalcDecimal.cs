using System;
namespace ProjectBasics
{
    //public class CalcDecimal : AbstractCalc
    //{
    //    public Decimal ArgA { get; set; }
    //    public Decimal ArgB { get; set; }
    //    public Decimal CalcResult { get; set; }

    //    public CalcDecimal()
    //    {
    //    }
    //    /*
    //     * Parse CSV string:
    //     *      "ArgA, ArgB"
    //     * for example:
    //     *  "9.6,3.2" 
    //     */
    //    public CalcDecimal(string csvData)
    //    {
    //        string[] tokens = csvData.Split(',');
    //        ArgA = ParseDecimal(tokens[0]);     // string "9.6" parse to integer 9.6
    //        ArgB = ParseDecimal(tokens[1]);     // string "3.2" parse to integer 3.2
    //    }
    //    public decimal ParseDecimal(string s)
    //    {
    //        decimal n = 0;
    //        try
    //        {
    //            n = decimal.Parse(s);   // string to decimal
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"*** Error: Can't Parse '{s}' to decimal. ***");
    //            Console.WriteLine(ex);
    //        }
    //        return n;
    //    }
    //    // AbstractCalc API implementation
    //    public override void Add()
    //    {
    //        CalcResult = ArgA + ArgB;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{ArgA} + {ArgB} = {CalcResult}";
    //    }
    //    public static void Demo()
    //    {
    //        Console.WriteLine("\n\t CalcDecimal.Demo()...");

    //        AbstractCalc obj = new CalcDecimal() { ArgA = 9.6M, ArgB = 3.3M };
    //        obj.Add();  // AbstractCalc API usage
    //        Console.WriteLine(obj); // ToString API usage
    //        //Console.WriteLine($"{obj.ArgA:F2} + {obj.ArgB:F2} = {obj.CalcResult:F2}");

    //        Console.WriteLine("\n\t CalcDecimal.Demo()... done!");
    //    }
    //}

    public class CalcDecimal : AbstractCalc
    {
        public decimal ArgA { set; get; }
        public decimal ArgB { set; get; }
        public decimal CalcResult { set; get; }

        public CalcDecimal()
        {
        }

        public CalcDecimal(string csvData)
        {
            string[] tokens = csvData.Split(',');
            ArgA = ParseDecimal(tokens[0]);
            ArgB = ParseDecimal(tokens[1]);
        }

        private decimal ParseDecimal(string s)
        {
            decimal d = 0;
            try
            {
                d = decimal.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurs " + e);
            }

            return d;
        }

        public override void Add()
        {
            CalcResult = ArgA + ArgB;
        }

        public override string ToString()
        {
            return $"{ArgA} + {ArgB} = {CalcResult}";
        }

        public void Demo() {
            Console.WriteLine("\n\t Decimal Calc demo()");
            AbstractCalc obj = new CalcDecimal() { ArgA = 9.6M, ArgB = 3.3M };
            obj.Add();
            Console.WriteLine(obj);
        }
    }
}