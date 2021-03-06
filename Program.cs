﻿using System;

namespace T4GenericsExample
{
    class Program
    {
        static void Main()
        {
            Print(new UInt64Class().ReturnResult());
            Print(new UInt32Class().ReturnResult());
            Print(new UInt16Class().ReturnResult());
            Print(new UInt8Class().ReturnResult());
        }

        static void Print(object @object) => Console.WriteLine($"{@object.GetType()}: 1 + 3 = {@object}");
    }
}
