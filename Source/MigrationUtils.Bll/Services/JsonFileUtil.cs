using System;
using System.IO;
using Newtonsoft.Json;

namespace MigrationUtils.Bll.Services
{
    public static class JsonFileUtil
    {
        public static void WriteToFile(string basePath, string fileName, object data)
        {
            using (var file = File.CreateText($"{basePath}{fileName}.json"))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        public static object ReadFromFile(string basePath, string fileName, Type type)
        {
            using (var file = File.OpenText($"{basePath}{fileName}.json"))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize(file, type);
            }
        }
    }
}