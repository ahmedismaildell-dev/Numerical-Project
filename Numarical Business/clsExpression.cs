using System;
using System.Collections.Generic;
using System.Linq;
using NCalcExpression = NCalc.Expression;
using System.Text;
using System.Threading.Tasks;
using NCalc;
using System;
namespace Numarical_Business
{
   

    public class FunctionEvaluator
    {
        private NCalcExpression expression;

        public FunctionEvaluator(string exprStr)
        {
            expression = new NCalcExpression(exprStr);
        }

        public double Evaluate(double x)
        {
            expression.Parameters["x"] = x;
            return Convert.ToDouble(expression.Evaluate());
        }
    }
}
