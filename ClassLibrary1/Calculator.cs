using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        private Stack<string> Operators;
        private Stack<double> Operands;
        private int level;
        string stringFormula;

        public Calculator()
        {
            Operators = new Stack<string>();
            Operands = new Stack<double>();
            stringFormula = "";
            level = 0;
        }

        public double Evaluate()
        {
            Levels lev = new Levels(1);
            switch (level)
            {
                case 1:
                    lev =  new Levels(1);
                    break;

            }
            foreach (double s in lev.GetOperandStack())
            {
                Operands.Push(s);
            }
            foreach(string t in lev.GetOperatorStack())
            {
                Operators.Push(t);
            }
            


            while (Operands.Count > 1)
            {
                Operate();
            }
            return Operands.Pop();
        }

        public Boolean Operate()
        {
            double  a = Operands.Pop();
            double b = Operands.Pop();

            string oper = "";
            if(Operators.Count > 0)
            {
                oper = Operators.Pop();
            }
            switch (oper)
            {
                case "+":
                    if (Operators.Count > 0)
                    {
                        if (Operators.Peek() == "*") 
                        {
                            return false;
                        }
                        else if(Operators.Peek() == "/")
                        {
                            return false;
                        }
                        else
                        {
                            stringFormula += a + "+" + b;
                            Operands.Push(a + b);
                        }
                    }
                    else
                    {
                        stringFormula += a + "+" + b;
                        Operands.Push(a + b);
                    }
                    return true;
                case "-":
                    if (Operators.Count > 0)
                    {
                        if (Operators.Peek() == "*")
                        {
                            stringFormula += a + "*" + b;
                            Operands.Push(a * b);
                        }
                        else if (Operators.Peek() == "/")
                        {
                            stringFormula += a + "/" + b;
                            Operands.Push(a / b);
                        }
                        else
                        {
                            stringFormula += a + "-" + b;
                            Operands.Push(a - b);
                        }
                    }
                    else
                    {
                        stringFormula += a + "-" + b;
                        Operands.Push(a - b);
                    }
                    return true;
                case "*":
                    stringFormula += a + "*" + b;
                    Operands.Push(a * b);
                    return true;
                case "/":
                    if (b == 0)
                    {
                        return false;
                    }
                    stringFormula += a + "/" + b;
                    Operands.Push(a / b);
                    return true;
            }
            return true;
            
        }

        public Boolean SetLevel(int lev)
        {
            level = lev;
            return true;
        }

        override
        public string ToString()
        {
            string result = "";
            Stack<double> numbers = Operands;
            Stack<string> temp = Operators;
            foreach(double d in numbers)
            {
                result += d;
                if(Operators.Count > 0)
                {
                    result += Operators.Pop();
                }
                
            }
            return result;
        }

        public string GetString()
        {
            return stringFormula;
        }
        

    }
}
