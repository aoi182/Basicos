using System;
using log4net;
using MyLibrary;

namespace ConsoleApp
{
    internal static class Program
    {
        private static readonly ILog Log1 = LogManager.GetLogger("ClassLibrary1");
        private static readonly ILog Log2 = LogManager.GetLogger("ClassLibrary2");
        private static readonly ILog Logger = LogManager.GetLogger("WindowsApplication1");
        //private static readonly log4net.ILog LoggerAdoNet = log4net.LogManager.GetLogger("AdoNetLogger");

        private static void Main(string[] args)
        {
            Log1.Debug("ProcessingC1");
            Log2.Debug("ProcessingC2");
            Logger.Error("processing");
            
            Call();

            Console.Read();
        }

        private static void Call()
        {
            MyClassA.Method1();
        }
    }
}