using System;
namespace ProjectBasics
{
    public class CalcComplex : AbstractCalc
    {
        public struct Complex
        {
            public int Real { set; get; }
            public int Imaginary { set; get; }

            public Complex Parse(string csvData)
            {
                int real = 0;
                int imaginary = 0;
                string[] tokens = csvData.Split(',');
                return new Complex { Real = real, Imaginary = imaginary };
            }
            public static Complex operator +(Complex a, Complex b)
            {
                Complex obj = new Complex
                { Real = a.Real + b.Real, Imaginary = a.Imaginary + b.Imaginary };
                return obj;
            }
            // overload operator - (minus)
            public static Complex operator - (Complex a, Complex b)
            {
                return new Complex
                { Real = a.Real - b.Real, Imaginary = a.Imaginary - b.Imaginary };
            }
            /* Expression Body method Definition
             *            
             * Syntax:
             * method Declaration => method single-statement body
             */            
            public override string ToString() => $"{Real} + {Imaginary}i (Real={ Real }, Imaginary={Imaginary})";
            //public override string ToString()
            //{
            //    return $"{Real} + {Imaginary}i (Real={ Real }, Imaginary={Imaginary})";
            //}
        }
        public Complex A { set; get; }
        public Complex B { set; get; }
        public Complex Result { set; get; }

        public Complex ArgA { get; set; }
        public Complex ArgB { get; set; }
        public Complex CalcResult { get; set; }

        public CalcComplex()
        {
        }
        /*
         * Parse CSV string:
         *      "ArgA, ArgB"
         * for example:
         *  "9,6,3,2"        
         */
        public CalcComplex(string csvData)
        {
            string[] tokens = csvData.Split(',');
            ArgA = ParseComplex(tokens[0], tokens[1]); // strings "9" & "6" parse to Complex Real=9, Imaginary=6
            ArgB = ParseComplex(tokens[2], tokens[3]); // strings "3" & "2" parse to Complex Real=3, Imaginary=2
        }
        public Complex ParseComplex(string s1, string s2)
        {
            int real = 0;
            int imaginary = 0;
            Complex n = new Complex { Real = real, Imaginary = imaginary };
            try
            {
                real = int.Parse(s1);       // string to int
                imaginary = int.Parse(s2);  // string to int
                n = new Complex { Real = real, Imaginary = imaginary };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*** Error: Can't Parse '{s1},{s2}' to Complex. ***");
                Console.WriteLine(ex);
            }
            return n;
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
        public Complex Add(Complex a, Complex b)
        {
            A = new Complex { Real = a.Real, Imaginary = a.Imaginary };
            B = new Complex { Real = b.Real, Imaginary = b.Imaginary };
            Result = A + B;     // use overloaded Complex +

            return Result;
        }
        public Complex Sub(Complex a, Complex b)
        {
            A = new Complex { Real = a.Real, Imaginary = a.Imaginary };
            B = new Complex { Real = b.Real, Imaginary = b.Imaginary };
            Result = A - B;     // use overloaded Complex +

            return Result;
        }
        public override string ToString()
        {
            return $"{ArgA} + {ArgB} = {CalcResult}";
        }
        public static void Demo()
        {
            Console.WriteLine("\n\t Calculator.Demo() ...");

            CalcComplex calc = new CalcComplex();
            Complex a = new Complex { Real = 12, Imaginary = 20 };
            Complex b = new Complex { Real = 3, Imaginary = 5 };
            Console.WriteLine($"Complex Number Addition: ({a}) + ({b}) = {a + b}");
            Console.WriteLine($"Complex Number Subtraction: ({a}) - ({b}) = {a - b}");

            /* instantiate Complex Calculator object,
             * But use derive object as AbstractCac API
             */            
            AbstractCalc obj = new CalcComplex()
            {
                ArgA = new Complex { Real = 9, Imaginary = 3 },
                ArgB = new Complex { Real = 3, Imaginary = 3 }
            };

            obj.Add(); // AbstractCalc API usage
            Console.WriteLine(obj); // ToString() API usage

            //Console.WriteLine($"{calc.ArgA} + {calc.ArgB} = {calc.CalcResult}");

            Console.WriteLine("\n\t Calculator.Demo() ... done!");
        }
    }
}
