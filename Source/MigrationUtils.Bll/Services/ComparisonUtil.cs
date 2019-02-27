using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace MigrationUtils.Bll.Services
{
    public static class ComparisonUtil
    {
        public static void GenerateReport(Dictionary<Type,string> models, string reportPath, string reportFileName)
        {
            var tweModelPath = ConfigurationManager.AppSettings["tweModelPath"];
            var kcrModelPath = ConfigurationManager.AppSettings["kcrModelPath"];
            var report = new StringBuilder("======================================== Horizon Migration Report ========================================");
            report.AppendLine();
            foreach (var key in models.Keys)
            {
                report.AppendLine($" --------------------------- Report for {key.Name} ---------------------------");
                try
                {
                    var tweModels = JsonFileUtil.ReadFromFile(tweModelPath, key.Name, typeof(IList)) as List<object>;
                    if (tweModels == null)
                    {
                        report.AppendLine("     Unable to read TWE file skipping comparison");
                        continue;
                    }
                    var kcrModels = JsonFileUtil.ReadFromFile(kcrModelPath, key.Name, typeof(IList)) as List<object>;
                    if (kcrModels == null)
                    {
                        report.AppendLine("     Unable to read KCR file skipping comparison");
                        continue;
                    }

                    if (tweModels.Count != kcrModels.Count)
                    {
                        report.AppendLine($"        Difference found. TWE contains {tweModels.Count} records and KCR contains {kcrModels.Count} records");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    report.AppendLine($"        {e.Message}");
                }
            }
            report.AppendLine("======================================== End of Report ========================================");
            using (TextWriter writer = File.CreateText($"{reportPath}{reportFileName}"))
            {
                writer.Write(report.ToString());
            }
        }
    }
}