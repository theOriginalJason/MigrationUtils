using System;
using System.Configuration;
using MigrationUtils.Bll.Services;

namespace MigrationUtils.ComparisonConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var modelDictionary = EntitySetUtil.GetEntityDictionary();
                var reportPath = ConfigurationManager.AppSettings["reportPath"];
                var reportFileName = ConfigurationManager.AppSettings["reportFileName"];
                if (modelDictionary.Keys.Count > 0)
                {
                    Console.WriteLine("Generating report....");
                    ComparisonUtil.GenerateReport(modelDictionary,reportPath,reportFileName);
                    Console.WriteLine($"Report complete. File can be found at {reportPath}{reportFileName}");
                }
                else
                {
                    Console.WriteLine("No models to report on process ended...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
