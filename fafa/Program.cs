using System;
using System.Runtime.CompilerServices;

public class P
{
    public static void Main()
    {
        long a = 254;
        long b = 254;
        var x = Bitcast<BoolEnum>(a);
        var y = Bitcast<BoolEnum>(b);
        Console.WriteLine ("x.CompareTo(y) ===>  actual: {0} (expected: 0)", x.CompareTo(y));
    }

    static T Bitcast<T>(long l) => Unsafe.As<long, T>(ref l);
}
