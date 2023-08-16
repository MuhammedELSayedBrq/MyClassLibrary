using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class operations
    {
        float num1,num2;
        public operations(float x,float y)
        {
            num1 = x;
            num2 = y;
        }
        public float sum()
        {
            return num1 + num2;
        }
        public float sub()
        {
            return num1 - num2;
        } 
        public float mul()
        {
            return num1 * num2;
        } 
        public float div()
        {
            return num1 / num2;
        }
        public string AllOperations()
        {
            string returnValue = "Sum = " + sum() + "\n";
            returnValue += "Sub = " + sub() + "\n";
            returnValue += "Multiply = " + mul() + "\n";
            returnValue += "Divide = " + div() + "\n";

            return returnValue;
        }
    }
}
