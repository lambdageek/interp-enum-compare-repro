using System;
using System.Runtime.CompilerServices;

// public interface InterfaceOne
// {
//     string Value { get; }
// }

// public interface InterfaceTwo
// {
//     string Value { get; }
// }

// public class BaseBaseTestClass : InterfaceOne
// {
//     public string Value { get; }
// }

// public class BaseTestClass : BaseBaseTestClass, InterfaceOne
// {
//     string InterfaceOne.Value => Value;
// }

// public class TestClass : BaseTestClass, InterfaceTwo
// {
// }

public class P
{
    public static void Main()
    {
        long a = 254;
        long b = 254;
        var x = Bitcast<BoolEnum>(a);
        var y = Bitcast<BoolEnum>(b);
        Console.WriteLine (Foo<BoolEnum>(x, y));
    }

    static T Bitcast<T>(long l) => Unsafe.As<long, T>(ref l);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Foo<T>(T a, T b) where T : Enum
    {
        return a.CompareTo(b);
    }
}
