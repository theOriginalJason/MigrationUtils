using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class systranschema
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tabid { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public byte[] startlsn { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(10)]
        public byte[] endlsn { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int typeid { get; set; }
    }
}