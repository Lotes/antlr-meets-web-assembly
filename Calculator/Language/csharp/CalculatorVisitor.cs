//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calculator.antlr4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CalculatorParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface ICalculatorVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd([NotNull] CalculatorParser.AddContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>skipAdd</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkipAdd([NotNull] CalculatorParser.SkipAddContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="CalculatorParser.multiplyingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMul([NotNull] CalculatorParser.MulContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>skipMul</c>
	/// labeled alternative in <see cref="CalculatorParser.multiplyingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkipMul([NotNull] CalculatorParser.SkipMulContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.powExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPowExpression([NotNull] CalculatorParser.PowExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>plusAtom</c>
	/// labeled alternative in <see cref="CalculatorParser.signedAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlusAtom([NotNull] CalculatorParser.PlusAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>minusAtom</c>
	/// labeled alternative in <see cref="CalculatorParser.signedAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMinusAtom([NotNull] CalculatorParser.MinusAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcAtom</c>
	/// labeled alternative in <see cref="CalculatorParser.signedAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncAtom([NotNull] CalculatorParser.FuncAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atomAtom</c>
	/// labeled alternative in <see cref="CalculatorParser.signedAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomAtom([NotNull] CalculatorParser.AtomAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>scientificAtom</c>
	/// labeled alternative in <see cref="CalculatorParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScientificAtom([NotNull] CalculatorParser.ScientificAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesisAtom</c>
	/// labeled alternative in <see cref="CalculatorParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesisAtom([NotNull] CalculatorParser.ParenthesisAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.scientific"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScientific([NotNull] CalculatorParser.ScientificContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.func_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc_([NotNull] CalculatorParser.Func_Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncname([NotNull] CalculatorParser.FuncnameContext context);
}
