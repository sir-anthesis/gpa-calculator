using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ihza_T1
{
    internal class Module
    {
        public string module_name;
        public double module_test;
        public double assignment;
        public double credit_value;
        public double result;
        public string grade;
        public double grade_value;

        public double Calculate()
        {
            double num1 = module_test * 0.6;
            double num2 = assignment * 0.4;
            result = num1 + num2;
            return result;
        }
    }
}
