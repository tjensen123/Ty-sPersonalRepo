using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Levels
    {
        private Stack<string> Operators;
        private Stack<double> Operands;
        string[] op = new string[9] { "+", "-", "*", "/", "<=", ">=", "%","(",")" };
        private int level;

        public Levels(int _level)
        {
            Operators = new Stack<string>();
            Operands = new Stack<double>();

            level = _level;

        }   

        public Boolean CreateValues()
        {
            Random rnd = new Random();
            switch (level)
            {
                case 1:
                    Operands.Push(rnd.Next(1, 9));
                    Operands.Push(rnd.Next(1, 9));
                    Operators.Push(op[rnd.Next(0, 4)]);
                    break;

                    
            }
            return true;
        }

        public ISet<double> GetOperandStack()
        {
            HashSet<double> result = new HashSet<double>(Operands);
            return result;
        }

        public ISet<string> GetOperatorStack()
        {
            HashSet<string> result = new HashSet<string>(Operators);
            return result;
        }
    }
}
