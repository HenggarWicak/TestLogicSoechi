using System.ComponentModel.DataAnnotations;

namespace _10112022_Soechi.Models
{
    public class UomModel
    {
        [Key]
        public long UOMID { get; set; }
        public string? UOMName { get; set; }
        public int UOMRate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
    }
}
