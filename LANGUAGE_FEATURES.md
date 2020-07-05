# Cahmann Language Features

The Cahmann scripting languages aims to provide a full feature-set, while keeping the language
easy-to-use and simple enough for beginner programmers to learn and understand the langauge.

All data types, keywords, statements and constants are reserved and cannot be used by the programmer.

## Data types

Cahmann is designed to use static datatypes. While type inference is supported at a language level, in the background, the usual classic datatypes are supported.

| Data types     |  Description |
|----------------|--------------|
| Booleans
| **bool/boolean** | 8bit signed (<= 0 = false, > 0 = true)
| Numbers
| **byte/uint8** | 8bit unsigned (0 -> 255)
| **sbyte/int8** | 8bit signed (-128 -> +127)
| **short/int16** | 16 bit signed (-32,768 -> 32,767)
| **ushort/uint16** | 16 bit unsigned (0 -> 65,535)
| **int/int32** | 32 bit signed (-2,147,483,648 -> 2,147,483,647)
| **uint/uint32** | 32 bit unsigned (0 -> 4,294,967,295)
| **long** | 64 bit signed (-9,223,372,036,854,775,808 -> 9,223,372,036,854,775,807)
| **ulong** | 64 bit unsigned (0 -> 18,446,744,073,709,551,615)
| **float/single** | 32 bit floating point (-3.40282347E+38 -> 3.40282347E+38)
| **double** | 64 bit floating point (-1.7976931348623157E+308 -> 1.7976931348623157E+308)
| **decimal/longdouble** | 128 bit floating point (-79,228,162,514,264,337,593,543,950,335 -> 79,228,162,514,264,337,593,543,950,335)
| Characters and strings
| **char** | 16bit unsigned (0 -> 65,535)
| **string** | character string (max. allocated memory)
| Meta
| **table** | A dynamic space in memory which may act as an array, an object, a list or a map.

## Statements and Keywords

Instead of being a bracket-language like C and its derivatives, Cahmann uses statements, like BASIC and Lua.

| Statement / Keyword | Description |
|---------------------|-------------|
| **import/use** |  Import another Cahmann script in to the current module
| **local/module** | Indicates that the following object is local to the current file. Other files may not see the object.
| **inline** | Indicates that the following function object is inline (AKA a single-line function)
| **func** | Denotes the beginning of a function object
| **ret** | Indicates that a function object has a return type. The return type must immediately follow
| **noret** | (Optional) Indicates that a function object doesn't have a return type
| **endfunc** | Denotes the ending of a function object
| **return** | Terminates the current function object and returns a given value
| **if** | Denotes the beginning of a conditional object
| **then** | Indicates the current conditional object is inline
| **elseif** | Denotes a seperate, conditioned, branch in a conditional object
| **else** | Denotes a separate branch in a conditional object
| **endif** | Denotes the end of a conditional object
| **while** | Denotes the beginning of a head-controlled conditional loop; is also used to denote the end of a foot-controlled conditional loop
| **endwhile** | Denotes the end of a head-controlled conditional loop
| **do** | Denotes the end of a loop head
| **repeat** | Denotes the beginning of a foot-controlled conditional loop
| **until** | Denotes the end of a foot-controlled conditional loop and the beginning of said loop's condition. Must evaluate to true.
| **for** | Denotes the beginnning of a head-controlled counter loop
| **to** | Used to describe the value to count to in a head-controller counter loop
| **comp** | Used to indicate the value to compute in a head-controlled counter loop
| **endfor** | Denotes the end of a head-controller counter loop
| **count** | Denotes the beginning of a counting loop
| **endcount** | Denotes the end of a counting loop
| **break** | Breaks out of a loop


## Operators

As any language, Cahmann requires operators in order to function correctly and produce the outputs you, as a programmer, may require.

There are several types of operator supported by Cahmann, they are listed below.

| Operator Type     | Operator      | Description                   |   Applicable to |
|-------------------|---------------|-------------------------------|-----------------|
|   Unary           |   true        |   True expression             |   Boolean
|   Unary           |   false       |   False expression            |   Boolean
|   Unary           |   cnt         |   Count expression            |   Tables
|
| Arithmetic        |   ++          |   Increment (by one)          |   Numbers and chars
| Arithmetic        |   --          |   Decrement (by one)          |   Numbers and chars
| Arithmetic        |   **          |   Exponentiate                |   Numbers and chars
| Arithmetic        |   +           |   Addition                    |   Numbers and chars
| Arithmetic        |   -           |   Subtraction                 |   Numbers and chars
| Arithmetic        |   *           |   Multiplication              |   Numbers and chars
| Arithmetic        |   /           |   Division                    |   Numbers and chars
| Arithmetic        |   %           |   Modulo (remainder)          |   Numbers and chars
|
| Logical           |   !           |   Negation                    |   Booleans
| Logical           |   &&          |   Short-circuit AND           |   Booleans
| Logical           |   ||          |   Short-circuit OR            |   Booleans
|
| Bitwise           |   &           |   Bitwise AND                 |   Booleans, numbers and chars
| Bitwise           |   |           |   Bitwise OR                  |   Booleans, numbers and chars
| Bitwise           |   ^           |   Bitwise XOR                 |   Booleans, numbers and chars
| Bitwise           |   ~           |   Bitwise complement          |   Numbers and chars
| Bitwise           |   >>          | Bitwise shift to the right    |   Numbers and chars
| Bitwise           |   <<          | Bitwise shift to the left     |   Numbers and chars
|
| Equality          |   ==          |   Equality check              |   Booleans, numbers, chars, tables, strings
| Inequality        |   !=          |   Inequality check            |   Booleans, numbers, chars, tables, strings
| Inequality        |   <>          |   Inequality check            |   Booleans, numbers, chars, tables, strings
|
| Comparison        |   <           |   Less than Comparison        |   Numbers and chars
| Comparison        |   <=          |   Less than or equal to       |   Numbers and chars
| Comparison        |   >           |   Greater than Comparison     |   Numbers and chars
| Comparison        |   >=          |   Greater than or equal to    |   Numbers and chars
|
| Member access     |   []          |   Array access                |   Tables
| Member access     |   .           |   Member access               |   Tables

## Comments

A multitude of different comment syntaxes are supported by Cahmann.
These comment syntaxes are inspired by and sometimes taken from other languages, 
such as Bash, C and Lua

### Single-line comments

Single-line comments may be defined as follows:

```c
    // Single-line comment
```

```bash
    # Single-line comment
```

```lua
    -- Single-line commnt
```

### Multi-line comments

While you may use single-line comments in as many lines as you wish to have multi-line comments,
Cahmann also supported the following multi-line comment syntaxes.

```
    --[[
        Lua multi-line comment
    ]]

    -- [[
        Lua-like multi-line comment
    ]] --
```
