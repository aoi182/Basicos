using System;
using log4net;

namespace MyLibrary
{
    public static class MyClassA
    {
        private static readonly ILog LoggerAdoNet = LogManager.GetLogger("AdoNetLogger");
        private static readonly ILog Log1 = LogManager.GetLogger("ClassLibrary1");
        public static void Method1()
        {
            try
            {
                throw new Exception("exception details", new Exception("inner exception details"));
            }
            catch (Exception e)
            {
                Log1.Error(e);
                LoggerAdoNet.Error("processing...", e);
            }
        }
    }
}