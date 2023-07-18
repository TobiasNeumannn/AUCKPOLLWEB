using System.ComponentModel.DataAnnotations;

namespace AUCKPOLLWEB.Models
{
    public class estuaryQuality

    {
        [Key]
        public int sampleID { get; set; }
        public ICollection<regions> regionID { get; set; }
        public DateOnly collection_date { get; set; }
        public string indicator { get; set; }
        public float value { get; set; }
    }
}
