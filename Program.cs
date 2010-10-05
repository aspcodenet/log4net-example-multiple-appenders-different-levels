using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace log4netexample
{
    class Program
    {
        public static ILog Log = log4net.LogManager.GetLogger("log4netexample.Program");
        
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            Log.Info("To console and file");
            Log.Debug("Just to file");
        }
    }
}
