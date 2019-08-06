﻿using System;
using System.Diagnostics;
using System.Threading;

namespace EnumDescription
{
    class Program
    {
        private static readonly int EmployeeTypeMemberCount = Enum.GetNames(typeof(EmployeeType)).Length - 1;

        static void Main(string[] args)
        {
            int typeValue = 0;

            Console.WriteLine("Comparing: ");

            for (var i = 0; i < 100; i++)
            {
                typeValue = ++typeValue > EmployeeTypeMemberCount ? 0 : typeValue;
                var type = ((EmployeeType) typeValue);

                // Initial execution
                type.GetEnumDescriptionWithoutGenerics();
                type.GetEnumDescriptionWithGenerics();

                // Comparing two methods
                Thread.Sleep(10);
                Executor(() => type.GetEnumDescriptionWithoutGenerics(), false);
                Thread.Sleep(10);
                Executor(() => type.GetEnumDescriptionWithGenerics(), true);
               
            }
        }

        private static void Executor(Action executeMethod, bool withGeneric)
        {
            var timer = Stopwatch.StartNew();
            executeMethod();
            timer.Stop();
            Console.WriteLine(
                $"{(withGeneric ? Constants.TimerRecordWithGenericLabel : Constants.TimerRecordWithoutGenericLabel)}: {timer.Elapsed}");
        }


    }
}
