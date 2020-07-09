using System;
using System.Collections.Generic;
using System.Text;

namespace Cahmann.Interpreter.Token {

    /// <summary>
    /// Contains all keywords
    /// </summary>
    public enum KeywordType {

        /// <summary>
        /// Denotes the beginning of an option statement, must come before any other statements!
        /// </summary>
        /// <remarks >
        /// <code >
        /// option
        /// </code>
        /// </remarks>
        Option,

        /// <summary>
        /// Denotes the beginning of an import statement, used to import code from other module files/scripts.
        /// </summary>
        /// <remarks >
        /// <code >
        /// import
        /// use
        /// </code>
        /// </remarks>
        Import,

        /// <summary>
        /// Indicates that the following object is local to the current script and may not be seen by scripts importing the current module.
        /// </summary>
        /// <remarks >
        /// <code >
        /// local
        /// module
        /// </code>
        /// </remarks>
        Local,

        /// <summary>
        /// Indicates that the following function object is inline.
        /// </summary>
        /// <remarks >
        /// <code >
        /// inline
        /// </code>
        /// </remarks>
        Inline,

        /// <summary>
        /// Denotes the beginning of a function object.
        /// </summary>
        /// <remarks >
        /// <code >
        /// func
        /// </code>
        /// </remarks>
        Function,

        /// <summary>
        /// Indicates that the preceeding funciton has a return value.
        /// </summary>
        /// <remarks >
        /// <code >
        /// ret
        /// </code>
        /// </remarks>
        FunctionReturnType,

        /// <summary>
        /// Explicitely indicates that the preceeding function has no return type.
        /// This keyword is optional.
        /// </summary>
        /// <remarks >
        /// <code >
        /// noret
        /// </code>
        /// </remarks>
        FunctionNoReturnType,

        /// <summary>
        /// Terminates a function and (if applicable) returns a given value.
        /// </summary>
        /// <remarks >
        /// <code >
        /// return
        /// </code>
        /// </remarks>
        FunctionReturnValue,

        /// <summary>
        /// Denotes the end of a function object.
        /// </summary>
        /// <remarks >
        /// <code >
        /// endfunc
        /// </code>
        /// </remarks>
        FunctionEnd,

        /// <summary>
        /// Denotes the beginning of a conditional object.
        /// </summary>
        /// <remarks >
        /// <code >
        /// if
        /// </code>
        /// </remarks>
        ConditionalBegin,

        /// <summary>
        /// Indicates the the current conditional object is inline (consists of a single line)
        /// </summary>
        /// <remarks >
        /// <code >
        /// then
        /// </code>
        /// </remarks>
        ConditionalInline,

        /// <summary>
        /// Denotes another branch in the current conditional object, with a separate condition.
        /// This branch is executed if the initial condition evaluated to <c >false</c>.
        /// </summary>
        /// <remarks >
        /// <code >
        /// elseif
        /// </code>
        /// </remarks>
        ConditionalBranchIf,

        /// <summary>
        /// Denotes another branch in the current conditional object.
        /// This branch is executed if all preceeding branches evaluate to <c >false</c>
        /// </summary>
        /// <remarks >
        /// <code >
        /// else
        /// </code>
        /// </remarks>
        ConditionalBranch,

        /// <summary>
        /// Denotes the end of a conditional object.
        /// </summary>
        /// <remarks >
        /// <code >
        /// endif
        /// </code>
        /// </remarks>
        ConditionalEnd,

        /// <summary>
        /// Denotes the beginning of a head-controlled conditional loop.
        /// The condition of the loop must evaluate to <code >true</code> for the loop to continue.
        /// </summary>
        /// <remarks >
        /// <code >
        /// while [condition]
        /// </code>
        /// </remarks>
        ConditionalLoopBegin,

        /// <summary>
        /// Indicates the end of a loop's head.
        /// </summary>
        /// <remarks >
        /// <code >
        /// do
        /// </code>
        /// </remarks>
        EndLoopHead,

        /// <summary>
        /// Denotes the end of a conditional loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// endwhile
        /// </code>
        /// </remarks>
        ConditionalLoopEnd,

        /// <summary>
        /// Denotes the beginning of an inverted (foot-controlled) conditional loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// repeat
        /// </code>
        /// </remarks>
        InvertedConditionalLoopBegin,

        /// <summary>
        /// Marks the beginning of the end of an inverted conditional loop.
        /// The condition for the loop must evaluate to <c >false</c> for the 
        /// </summary>
        /// <remarks >
        /// <code >
        /// until [condition]
        /// </code>
        /// </remarks>
        InvertedConditionalLoopEnd,

        /// <summary>
        /// Denotes the beginning of a head-controlled counter loop.
        /// This is essentially a classic for-loop where you may vary the expression used to count the counter variable.
        /// </summary>
        /// <remarks >
        /// <code >
        /// for i = 0
        /// </code>
        /// </remarks>
        ControlledCounterLoopBegin,

        /// <summary>
        /// Marks the value to count to, in a head-controlled or automatic counter loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// to 255
        /// </code>
        /// </remarks>
        ControlledCounterLoopCountTo,

        /// <summary>
        /// Marks the expression to execute to manipulate the counter variable.
        /// </summary>
        /// <remarks >
        /// <code >
        /// comp {expression}
        /// </code>
        /// </remarks>
        ControlledCounterLoopCompute,

        /// <summary>
        /// Denotes the end of a head-controlled counter loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// endfor
        /// </code>
        /// </remarks>
        ControlledCounterLoopEnd,

        /// <summary>
        /// Denotes the beginning of an automatic counter loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// count i = 0
        /// </code>
        /// </remarks>
        CounterLoopBegin,

        /// <summary>
        /// Denotes the end of an automatic counter loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// endcount
        /// </code>
        /// </remarks>
        CounterLoopEnd,

        /// <summary>
        /// Breaks out of the current loop.
        /// </summary>
        /// <remarks >
        /// <code >
        /// break
        /// </code>
        /// </remarks>
        LoopBreak,

        /// <summary>
        /// Terminates the execution of the current script and returns the desired value to the import function.
        /// </summary>
        ModuleExport

    }
}
