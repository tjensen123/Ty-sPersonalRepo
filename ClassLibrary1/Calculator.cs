using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        private Stack<char> Operators;
        private Stack<double> Operands;
        private int level;

        public Calculator()
        {
            Operators = new Stack<char>();
            Operands = new Stack<double>();
            level = 0;
        }

        public double Evaluate()
        {
            switch (level)
            {
                case 1:

            }
        }

        public double Operate()
        {
            double  a = Operands.Pop();
            double b = Operands.Pop();


            switch (Operators.Pop())
            {
                case '+':
                    
            }
            
        }

        public void level1()
        {

        }

    }
}
