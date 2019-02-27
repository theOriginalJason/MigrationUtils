using System;

namespace MigrationUtils.Dal.Models
{
    public class SchemaVersion
    {
        public int Id { get; set; }

        public string ScriptName { get; set; }

        public DateTime Applied { get; set; }
    }
}