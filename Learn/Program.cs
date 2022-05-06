using System;
using System.Collections.Generic;


namespace Learn
{
    internal static class Program
    {
        static void Main()
        {
            int x = int.MaxValue;
            long y = long.MaxValue;
            short z = short.MaxValue;
            ulong c;
            c = (ulong)x + (ulong)y + (ulong)z;
            Console.WriteLine(c);
        }
    }
}
