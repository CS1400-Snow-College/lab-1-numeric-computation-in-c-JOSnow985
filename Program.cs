// See https://aka.ms/new-console-template for more information
Console.Clear();

// Step 1: Integer Math 1
Console.WriteLine("18 + 6 =");
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

// Step 2: Integer Math 2
// Remember to update which variable is writing!
// Can't use 'int c' again, just 'c =' instead
Console.WriteLine("18 - 6 =");
c = a - b;
Console.WriteLine(c);

Console.WriteLine("18 * 6 =");
c = a * b;
Console.WriteLine(c);

// Step 3: Order of Operations 1
Console.WriteLine("5 + 4 * 2 =");
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine(d);

// Step 4: Order of Operations 2
Console.WriteLine("(5 + 4) * 2 =");
a = 5;
b = 4;
c = 2;
d = (a + b) * c;
Console.WriteLine(d);

// Step 5: Order of Operations 3
Console.WriteLine("(5 + 4) - 6 * 2 + (12 * 4) / 3 + 12 =");
a = 5;
b = 4;
c = 2;
d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

// Step 6: Order of Operations 4
// Integer precision example
Console.WriteLine("(7 + 4) / 3 =");
a = 7;
b = 4;
c = 3;
d = (a + b) / c;
Console.WriteLine(d);

// Step 7: Integer Precision and Limits 1
// Can place a $ before the string to use {} instead of inputting the literal numbers?
Console.WriteLine($"({a} + {b}) / {c} =");
a = 7;
b = 4;
c = 3;
d = (a + b) / c;
Console.WriteLine($"quotient: {d}");
// % is the remainder operator, shows whatever the remainder would be
Console.WriteLine($"({a} + {b}) % {c} =");
int e = (a + b) % c;
Console.WriteLine($"remainder: {e}");

// Step 8: Integer Precision and Limits 2
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}!");

// Step 9: Integer Precision and Limits 3
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Step 10: Double Type 1
// can't redefine a so using aa instead
// Obviously, can't use 
double aa = 5;
double bb = 4;
double cc = 2;
Console.WriteLine($"Using double type instead, ({aa} + {bb}) / {cc}");
double dd = (aa + bb) / cc;
Console.WriteLine(dd);

// Step 11: Double Type 2
aa = 19;
bb = 23;
cc = 8;
Console.WriteLine($"Double type with bigger numbers! ({aa} + {bb}) / {cc}");
dd = (aa + bb) / cc;
Console.WriteLine(dd);

// Step 12: Double Type 3
// max and min already defined for int, using d as a prefix
double dmax = double.MaxValue;
double dmin = double.MinValue;
Console.WriteLine($"The range of double is {dmin} to {dmax}!");

// Step 13: Double Type 4
Console.WriteLine("1.0 / 3.0 =");
double third = 1.0 / 3.0;
Console.WriteLine(third);

// Step 14: Double Type Challenge
Console.WriteLine();
aa = 220;
bb = 60;
cc = 9;
dd = -2;
double ee = (aa * dd) + (aa / bb) + (cc * bb) - aa;
Console.WriteLine($"({aa} * {dd}) + ({aa} / {bb}) + ({cc} * {bb}) - {aa} =");
Console.WriteLine(ee);

// Step 15: Decimal Types 1
decimal decmin = decimal.MinValue;
decimal decmax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decmin} to {decmax}!");

// Step 16: Decimal Types 2
aa = 1.0;
bb = 3.0;
Console.WriteLine("Using double, 1.0 / 3.0 =");
Console.WriteLine(aa / bb);
// M suffix on the numbers indicates the constant should use the decimal type, otherwise it assumes it is double
decimal deca = 1.0M;
decimal decb = 3.0M;
Console.WriteLine("Using decimal, 1.0 / 3.0 =");
Console.WriteLine(deca / decb);