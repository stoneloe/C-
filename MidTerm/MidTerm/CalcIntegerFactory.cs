using System;
namespace ProjectBasics
{
    public class CalcIntegerFactory : AbstractCalcFactory
    {
        public override AbstractCalc GetObject(string csvData)
        {
            return new CalcInteger(csvData);
        }
    }
}
