using System;

namespace Operators
{
    class Program
    {
        static void Main(String[] args)
        {
            // Declare some variables to exercise the opeartors
            int x=10, y=5;
            string a="abcd", b="efgh";

            // ToDo: Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            // ToDo: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // ToDo: Operators can be shorthand: a = a + b
            a += b;
            Console.WriteLine(a);

            // ToDo: Logical operators &&, ||
            // Console.WriteLine("----- Logic Operators -----");
            Console.WriteLine(x > y && y >= 5);
            Console.WriteLine(x > y || y >= 5);

            // null-coalescing operators
            string str = null;
            // ToDo: the ?? operator uses left operand if not null or right if it is not null
            Console.WriteLine(str ?? "Unknown string");

            // ToDo: the ??= operator assigns the right operand if the left one is null
            // it relplaces the code:
            // if (variable is null) {
            //     variable = somevalue;
            // }
        str ??= "New String";
        Console.WriteLine(str);
        }
    }
}