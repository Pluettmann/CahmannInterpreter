using System;
using System.Collections.Generic;
using System.Text;

namespace Cahmann.Interpreter.Token {

    /// <summary>
    /// Enum containing the different operator types supported by Cahmann.
    /// </summary>
    public enum OperatorType {

        #region Unary Operators
        /// <summary>
        /// Evaluates to true.
        /// </summary>
        /// <remarks >
        /// <code >
        /// true
        /// </code>
        /// </remarks>
        TrueExpression,

        /// <summary>
        /// Evalutates to false.
        /// </summary>
        /// <remarks >
        /// <code >
        /// false
        /// </code>
        /// </remarks>
        FalseExpression,

        /// <summary>
        /// The length of a table or string in elements
        /// OR
        /// The length (in Bytes) of a given number, char or booooooooolean (<= that's one spooky bool)
        /// </summary>
        /// <remarks >
        /// <code >
        /// len
        /// </code>
        /// </remarks>
        LengthOperator,

        /// <summary>
        /// Assigns a value to a variable
        /// </summary>
        /// <remarks >
        /// <code >
        /// =
        /// </code>
        /// </remarks>
        AssignmentOperator,
        #endregion

        #region Arithmetic
        /// <summary>
        /// Increments the preceeding number variable by one
        /// </summary>
        /// <remarks >
        /// <code >
        /// ++
        /// </code>
        /// </remarks>
        IncrementOperator,

        /// <summary>
        /// Decrements the preceeding number variable by one
        /// </summary>
        /// <remarks >
        /// <code >
        /// --
        /// </code>
        /// </remarks>
        DecrementOperator,

        /// <summary>
        /// Multiplies a given number variable by itself and assigns the value to said variable
        /// </summary>
        /// <remarks >
        /// <code >
        /// **
        /// </code>
        /// </remarks>
        ExponentiateOperator,

        /// <summary>
        /// Adds a variable or value to another variable or value.
        /// Applicable to: numbers, chars
        /// </summary>
        /// <remarks >
        /// <code >
        /// +
        /// </code>
        /// </remarks>
        AdditionOperator,

        /// <summary>
        /// Adds a variable or number and assigns the new value to another variable.
        /// Applicable to: numbers, chars
        /// </summary>
        /// <remarks >
        /// <code >
        /// +=
        /// </code>
        /// </remarks>
        AdditionAndAssignmentOperator,

        /// <summary>
        /// Subtracts a variable or number from another variable or number.
        /// Applicable to: numbers, chars
        /// </summary>
        /// <remarks >
        /// <code >
        /// -=
        /// </code>
        /// </remarks>
        SubtractionOperator,

        /// <summary>
        /// Subtracts a variable or number from another variable and assigns the new value.
        /// </summary>
        /// <remarks >
        /// <code >
        /// -=
        /// </code>
        /// </remarks>
        SubtractionAndAssignmentOperator,

        /// <summary>
        /// Multiplies a variable or number by another variable or number.
        /// </summary>
        /// <remarks >
        /// <code >
        /// *
        /// </code>
        /// </remarks>
        MultiplicationOperator,

        /// <summary>
        /// Multiplies a variable or number by another variable and assigns the new value
        /// </summary>
        /// <remarks >
        /// <code >
        /// *=
        /// </code>
        /// </remarks>
        MultiplicationAndAssignmentOperator,

        /// <summary>
        /// Divides a variable or number by another variable or number.
        /// </summary>
        /// <remarks >
        /// <code >
        /// /
        /// </code>
        /// </remarks>
        DivisionOperator,

        /// <summary>
        /// Divides a variable or number by another variable or number and assigns the new value.
        /// </summary>
        DivisionAndAssignmentOperator,

        /// <summary>
        /// Gets the remainder of a division.
        /// </summary>
        /// <remarks >
        /// <code >
        /// %
        /// </code>
        /// </remarks>
        ModuloOperator,

        /// <summary>
        /// Gets the remainder of a division and assigns the new value.
        /// </summary>
        /// <remarks >
        /// <code >
        /// %=
        /// </code>
        /// </remarks>
        ModuloAndAssignmentOperator,
        #endregion

        #region Logical
        /// <summary>
        /// Negates a boolean operation.
        /// </summary>
        /// <remarks >
        /// <code >
        /// !
        /// </code>
        /// </remarks>
        NegationOperator,

        /// <summary>
        /// Short-circuit (logical) AND operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// &amp;&amp;
        /// </code>
        /// </remarks>
        ShortCircuitAndOperator,

        /// <summary>
        /// Short-circuit (logical) OR operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// ||
        /// </code>
        /// </remarks>
        ShortCircuitOrOperator,
        #endregion

        #region Bitwise
        /// <summary>
        /// Bitwise AND operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// &amp;
        /// </code>
        /// </remarks>
        BitwiseAndOperator,

        /// <summary>
        /// Bitwise AND
        /// </summary>
        /// <remarks >
        /// <code >
        /// &amp;=
        /// </code>
        /// </remarks>
        BitwiseAndAssignmentOperator,

        /// <summary>
        /// Bitwise OR operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// |
        /// </code>
        /// </remarks>
        BitwiseOrOperator,

        /// <summary>
        /// Bitwise OR operator and assignment
        /// </summary>
        /// <remarks >
        /// <code >
        /// |=
        /// </code>
        /// </remarks>
        BitwiseOrAndAssignmentOperator,

        /// <summary>
        /// Bitwise XOR operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// ^
        /// </code>
        /// </remarks>
        BitwiseXorOperator,

        /// <summary>
        /// Bitwise XOR operator and assignment
        /// </summary>
        /// <remarks >
        /// <code >
        /// ^=
        /// </code>
        /// </remarks>
        BitwiseXorAndAssignmentOperator,

        /// <summary>
        /// Bitwise complement. (Reverses the bits)
        /// </summary>
        /// <remarks >
        /// <code >
        /// ~
        /// </code>
        /// </remarks>
        BitwiseComplementOperator,

        /// <summary>
        /// Bitwise complement (reverses the bits) and assignment.
        /// </summary>
        /// <remarks >
        /// <code >
        /// ~=
        /// </code>
        /// </remarks>
        BitwiseComplementAndAssignmentOperator,

        /// <summary>
        /// Left bitshift (by a given number of bits)
        /// </summary>
        /// <remarks >
        /// <code >
        /// &lt;&lt;
        /// </code>
        /// </remarks>
        BitwiseShiftToLeftOperator,

        /// <summary>
        /// Right bitshift (by a given number of bits)
        /// </summary>
        /// <remarks >
        /// <code >
        /// &gt;&gt;
        /// </code>
        /// </remarks>
        BitwiseShiftToRightOperator,
        #endregion

        #region (In-)Equality
        /// <summary>
        /// Equality check
        /// </summary>
        /// <remarks >
        /// <code >
        /// ==
        /// </code>
        /// </remarks>
        EqualityOperator,

        /// <summary>
        /// Inequality check
        /// </summary>
        /// <remarks >
        /// <code >
        /// !=
        /// </code>
        /// </remarks>
        InequalityOperator,

        /// <summary>
        /// BASIC inequality (not equals) operator
        /// </summary>
        /// <remarks >
        /// <code >
        /// &lt;&gt;
        /// </code>
        /// </remarks>
        BasicInequalityOperator,
        #endregion

        #region Comparison
        /// <summary>
        /// Less than comparison operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// &lt;
        /// </code>
        /// </remarks>
        LessThanOperator,

        /// <summary>
        /// Less than or equal to comparison operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// &lt;=
        /// </code>
        /// </remarks>
        LessThanOrEqualToOperator,

        /// <summary>
        /// Greater than comparison.
        /// </summary>
        /// <remarks >
        /// <code >
        /// &gt;
        /// </code>
        /// </remarks>
        GreaterThanOperator,

        /// <summary>
        /// Greater than or equal to comparison.
        /// </summary>
        /// <remarks >
        /// <code >
        /// &gt;=
        /// </code>
        /// </remarks>
        GreaterThanOrEqualToOperator,
        #endregion

        #region Member Access
        /// <summary>
        /// Array (table) access operator.
        /// Used to access tables which are actually array :)
        /// </summary>
        /// <remarks >
        /// <code >
        /// [
        /// </code>
        /// </remarks>
        ArrayAccessOperatorBegin,

        /// <summary>
        /// Array (table) access operator.
        /// Used to access tables which are actually array :)
        /// </summary>
        /// <remarks >
        /// <code >
        /// ]
        /// </code>
        /// </remarks>
        ArrayAccessOperatorEnd,

        /// <summary>
        /// Member access operator.
        /// Used to access table members.
        /// </summary>
        /// <remarks >
        /// <code >
        /// .
        /// </code>
        /// </remarks>
        MemberAccessOperator,
        #endregion

        #region Concatenation
        /// <summary>
        /// String concatenation operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// +
        /// </code>
        /// </remarks>
        StringConcatOperator,
        #endregion

        #region Function Call
        /// <summary>
        /// The first character of the function operator.
        /// The function operator may either indicate a parameter list in a function head or the beginning/end of the function call operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// (
        /// </code>
        /// </remarks>
        FunctionOperatorBegin,

        /// <summary>
        /// The second character of the function operator.
        /// The function operator may either indicate a parameter list in a function head or the beginning/end of the function call operator.
        /// </summary>
        /// <remarks >
        /// <code >
        /// )
        /// </code>
        /// </remarks>
        FunctionOperatorEnd,

        /// <summary>
        /// 
        /// </summary>
        FunctionCallOperator,
        #endregion

    }
}
