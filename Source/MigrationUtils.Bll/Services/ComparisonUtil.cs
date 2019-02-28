using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using MigrationUtils.Test;

namespace MigrationUtils.Bll.Services
{
    public static class ComparisonUtil
    {
        public static void GenerateReport(Dictionary<Type, EntitySetUtil.EntityProperties> models, string reportPath, string reportFileName)
        {
            var tweModelPath = ConfigurationManager.AppSettings["tweModelPath"];
            var kcrModelPath = ConfigurationManager.AppSettings["kcrModelPath"];
            var report = new StringBuilder("======================================== Horizon Migration Report ========================================");
            report.AppendLine();

            var count = models.Keys.Count;
            var iterator = 1;
            foreach (var key in models.Keys)
            {
                Console.WriteLine($"Processing {iterator} of {count}");
                report.AppendLine($" --------------------------- Report for {key.Name} ---------------------------");
                try
                {
                    var listType = models[key].ListType;
                    var tweModels = JsonFileUtil.ReadFromFile(tweModelPath, key.Name, listType);
                    if (tweModels == null)
                    {
                        report.AppendLine("     Unable to read TWE file skipping comparison");
                        continue;
                    }

                    var kcrModels = JsonFileUtil.ReadFromFile(kcrModelPath, key.Name,listType);
                    
                    if (kcrModels == null)
                    {
                        report.AppendLine("     Unable to read KCR file skipping comparison");
                        continue;
                    }
                    ComparisonTest.Compare(tweModels,kcrModels,listType);
                    report.AppendLine("     No differences found");
                }
                catch (Exception e)
                {
                    report.AppendLine($"        {e.Message}");
                }
                iterator++;
            }
            report.AppendLine("======================================== End of Report ========================================");
            using (TextWriter writer = File.CreateText($"{reportPath}{reportFileName}"))
            {
                writer.Write(report.ToString());
            }
        }
    }
}