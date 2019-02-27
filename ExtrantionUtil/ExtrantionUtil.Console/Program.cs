using System;
using System.Configuration;
using System.Data.SqlClient;
using MigrationUtils.Bll.Services;
using MigrationUtils.Dal;

namespace MigrationUtils.ExtractionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var models = EntitySetUtil.GetEntityDictionary();
                if (models.Keys.Count > 0)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["Horizon"].ConnectionString;
                    var basePath = ConfigurationManager.AppSettings["ExtractPath"];
                    Console.WriteLine("-----  Beginning extraction process -----");

                    using (var connection = new SqlConnection(connectionString))
                    {
                        foreach (var key in models.Keys)
                        {
                            Console.WriteLine($"    Processing {key.Name} models...");
                            var foundModels =RepositoryUtil.Get(models[key], connection);
                            JsonFileUtil.WriteToFile(basePath, key.Name,foundModels);
                        }
                    }
                    Console.WriteLine("-----  Extraction process complete -----");
                }
                else
                {
                    Console.WriteLine("No models to process...");
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
