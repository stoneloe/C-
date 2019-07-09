using System;
namespace demo
{
//    public abstract class Calculator<T>
//    {
        

//    public abstract T Add(T a, T b);
    
//}

    //class ScientificCalculator: Calculator<int> { 

    //    public override int Add(int a, int b) {
    //        return a + b;
    //    }
    //}

    //class ComplexCalculator: Calculator<Complex> { 
    //    public override Complex Add(Complex a, Complex b) {
    //        Complex res = new Complex();
    //        res.re = a.re + b.re;
    //        res.im = a.im + b.im;

    //        return res;
    //    }
    
    //}


        //public class Calculator {
        //public IAddition addition;

        //public Calculator(IAddition i) {
        //    addition = i;
        //}

        //public void Add() { 
        //    addition.
        //}
        //}
    public abstract class Calculator<T> {

        public abstract T Add(T a, T b); 
    }

    class Complex
    {
        public int re;
        public int im;

        public Complex() { }

    }

    public interface IAddition<T> {
        T Addition(T a, T b);
    }

    class ScientificCalculator : Calculator<int>, IAddition<int> { 

        public int Addition(int a, int b) {
            return a + b; 
        }

        public override int Add(int a , int b)
        {
            return Addition(a, b);
        }
 
    }

    class ComplexCalculator : Calculator<Complex>, IAddition<Complex> {

        public Complex Addition(Complex a, Complex b) {
            Complex res = new Complex();
            res.re = a.re + b.re;
            res.im = a.im + b.im;

            return res;
        }

        public override Complex Add(Complex a, Complex b)
        {
            return Addition(a, b);
        }
    }



}
