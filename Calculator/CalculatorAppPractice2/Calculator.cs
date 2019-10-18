using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public double firstnumber;
        public double secondnumber;
        public double result;
        public double add()
        {
            result = firstnumber + secondnumber;
            return result;
        }
        public double subtract()
        {
            if (firstnumber > secondnumber)
            {
                result = firstnumber - secondnumber;
            }
            else
            {
                result =(secondnumber - firstnumber);
            }
            
            return result;

        }
        public double multiply()
        {
            result = firstnumber* secondnumber;
            return result;

        }
        public double division()
        {
            result = firstnumber / secondnumber;
            return result;

        }

    }
}
