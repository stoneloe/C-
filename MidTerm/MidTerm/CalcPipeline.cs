using System;
using System.Collections.Generic;
using System.Text;
namespace ProjectBasics
{
    public class CalcPipeline : AbstractCalcPipeline
    {
        public List<AbstractCalc> calculators = new List<AbstractCalc>();
        public CalcPipeline()
        {
        }
        public override void Append(AbstractCalc calc)
        {
            calculators.Add(calc);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach( var calc in calculators)
            {
                calc.Add();     // use calculator
                sb.Append("\n\t").Append(calc.ToString());
            }   
            return sb.ToString();
        }
        public static void Demo()
        {
            Console.WriteLine("\n\t CalcStore.Demo()...");

            // create store of calculators
            CalcPipeline store = new CalcPipeline(); 

            AbstractCalcFactory f1 = new CalcIntegerFactory();   // create a factory
            AbstractCalc obj = f1.GetObject("9,3");  // use Factory Design Pattern
            store.Append(obj);
            store.Append(f1.GetObject("9,6"));
            store.Append(f1.GetObject("8,2"));
            store.Append(f1.GetObject("6,4"));
            AbstractCalcFactory f2 = new CalcDoubleFactory();   // create a factory
            store.Append(f2.GetObject("9.6,3.2"));
            store.Append(f2.GetObject("9.2,2.3"));
            store.Append(f2.GetObject("8.4,4.2"));
            AbstractCalcFactory f3 = new CalcDecimalFactory();   // create a factory
            store.Append(f3.GetObject("9.6,3.2"));
            store.Append(f3.GetObject("9.2,2.3"));
            store.Append(f3.GetObject("8.4,4.2"));
            AbstractCalcFactory f4 = new CalcComplexFactory();   // create a factory
            store.Append(f4.GetObject("9,6,3,2"));
            store.Append(f4.GetObject("9,2,2,3"));
            store.Append(f4.GetObject("8,4,4,2"));
            Console.WriteLine(store);   // output store state using ToString()

            Console.WriteLine("\n\t CalcStore.Demo()...done!");
        }
    }
}
