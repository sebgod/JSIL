﻿using System;

public class Program
{
    public const long TEST_CONST = 1000L;
    public readonly long TEST_READONLY_FIELD = 2000L;
    public static long TEST_STATIC_FIELD = 3000L;
    public long TEST_NORMAL_FIELD = 4000L;

    public static void Main(string[] args)
    {
        // litterals
        Console.WriteLine(0L);
        Console.WriteLine(1000000000000L);
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        // fields
        Console.WriteLine(TEST_CONST);
        Console.WriteLine(new Program().TEST_READONLY_FIELD);
        Console.WriteLine(TEST_STATIC_FIELD);
        Console.WriteLine(new Program().TEST_NORMAL_FIELD);

        // addition
        Console.WriteLine(1000000000000L + 100000000000L);
        Console.WriteLine(1L + 0L);
        Console.WriteLine(1L + 100000000000L);
        Console.WriteLine(1L + -100000000000L);
        Console.WriteLine(1 + 0L);
        Console.WriteLine(1 + 100000000000L);
        Console.WriteLine(1 + -100000000000L);

        // subtraction
        Console.WriteLine(1000000000000L - 100000000000L);
        Console.WriteLine(1L - 0L);
        Console.WriteLine(1L - 100000000000L);
        Console.WriteLine(1L - -100000000000L);
        Console.WriteLine(1 - 0L);
        Console.WriteLine(1 - 100000000000L);
        Console.WriteLine(1 - -100000000000L);

        var x = 100000000000L;
        var y = 10000053450L;

        Console.WriteLine(-x);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(x + y);
        Console.WriteLine(x - y);
        Console.WriteLine(x * y);
        Console.WriteLine(x / y);
        Console.WriteLine(x % y);
        Console.WriteLine(x & y);
        Console.WriteLine(x | y);
        Console.WriteLine(x >> 3);
        Console.WriteLine(y << 3);
        Console.WriteLine(2 * x + 3 * y / 7);

        int z = 2;
        Console.WriteLine(((long)z) * x);

        // check JS to see if this uses long operations or not
        int a = 5;
        int b = 6;
        long w = a - b;
        Console.WriteLine(w);

        int days = 100, hours = 20, minutes = 1, seconds = 1, milliseconds = 20;
        int hrssec = (hours * 3600); // break point at (Int32.MaxValue - 596523)
        int minsec = (minutes * 60);
        long t = ((long)(hrssec + minsec + seconds) * 1000L + (long)milliseconds);
        t *= 10000;
        Console.WriteLine(t);

        //object box = x;
        //Console.WriteLine(x * (long)box);

        var n = 634590720000000000L;
        var m = 864000000000L;
        Console.WriteLine(n);
        Console.WriteLine(m);
        Console.WriteLine(1 + (int)(n / m));
    }
}