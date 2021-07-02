using System;
using System.IO;
using System.Linq;
using System.Text;
using Antlr4.Runtime;

namespace Calculator.Language
{
    public class Calculator
    {
        public double Calculate(string input)
        {
            Console.WriteLine($"input: {input}");
            var stream = new MemoryStream(Encoding.Default.GetBytes(input));
            var lexer = new CalculatorLexer(new AntlrInputStream(stream));
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new CalculatorParser(tokenStream);
            var parseTree = parser.expression();
            var evaluator = new Evaluator();
            return evaluator.Visit(parseTree);
        }

        private class Evaluator: //ICalculatorVisitor<double>
                                 CalculatorBaseVisitor<double>
        {
            public override double VisitPlusAtom(CalculatorParser.PlusAtomContext context)
            {
                return Visit(context.operand);
            }

            public override double VisitMinusAtom(CalculatorParser.MinusAtomContext context)
            {
                return -Visit(context.operand);
            }

            public override double VisitAtomAtom(CalculatorParser.AtomAtomContext context)
            {
                return Visit(context.atm);
            }

            public override double VisitScientificAtom(CalculatorParser.ScientificAtomContext context)
            {
                return Visit(context.scientific());
            }

            public override double VisitParenthesisAtom(CalculatorParser.ParenthesisAtomContext context)
            {
                return Visit(context.expr);
            }

            public override double VisitFuncAtom(CalculatorParser.FuncAtomContext context)
            {
                return Visit(context.fnc);
            }

            public override double VisitAdd(CalculatorParser.AddContext context)
            {
                var lhs = Visit(context.lhs);
                if (context.rhs == null)
                {
                    return lhs;
                }
                var rhs = Visit(context.rhs);
                if (context.op.Text == "+")
                {
                    return lhs + rhs;
                }
                return lhs - rhs;
            }

            public override double VisitMul(CalculatorParser.MulContext context)
            {
                var lhs = Visit(context.lhs);
                if (context.rhs == null)
                {
                    return lhs;
                }
                var rhs = Visit(context.rhs);
                if (context.op.Text == "*")
                {
                    return lhs * rhs;
                }
                return lhs / rhs;
            }

            public override double VisitPowExpression(CalculatorParser.PowExpressionContext context)
            {
                var lhs = Visit(context.lhs);
                if (context._rhs == null)
                {
                    return lhs;
                }
                return context._rhs
                    .Select(Visit)
                    .Aggregate(lhs, Math.Pow);
            }

            public override double VisitScientific(CalculatorParser.ScientificContext context)
            {
                return double.Parse(context.GetText());
            }

            public override double VisitFunc_(CalculatorParser.Func_Context context)
            {
                var parameters = context._ps.Select(Visit).ToArray();

                switch (context.fnc.GetText())
                {
                    case "cos": return Math.Cos(parameters[0]);
                    case "sin": return Math.Sin(parameters[0]);
                    case "tan": return Math.Tan(parameters[0]);
                    case "acos": return Math.Acos(parameters[0]);
                    case "asin": return Math.Asin(parameters[0]);
                    case "atan": return Math.Atan(parameters[0]);
                    case "ln": return Math.Log(parameters[0]);
                    case "log": return Math.Log10(parameters[0]);
                    case "sqrt": return Math.Sqrt(parameters[0]);
                }

                throw new NotSupportedException(context.fnc.GetText());
            }
        }
    }
}