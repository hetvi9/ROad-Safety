using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RodeSafetyTool.Models
{
    public class guardian
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Relation { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Contact { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string City { get; set; }
        
    }
}
