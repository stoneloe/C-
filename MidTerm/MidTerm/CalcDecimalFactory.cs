using System;
namespace ProjectBasics
{
    //public class CalcDecimalFactory : AbstractCalcFactory
    //{
    //    public override AbstractCalc GetObject(string csvData)
    //    {
    //        return new CalcDecimal(csvData);
    //    }
    //}

    public class CalDecimalFactory : AbstractCalcFactory {
        public override AbstractCalc getObject(string csvData)
        {
            return new CalcDecimal(csvData);
        }
    }
}

