using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class HolidayDate
    {
        public int HolidayDateId { get; set; }

        [Column("HolidayDate", TypeName = "date")]
        public DateTime HolidayDate1 { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }
    }
}