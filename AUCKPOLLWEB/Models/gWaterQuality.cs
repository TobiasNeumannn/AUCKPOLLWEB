using System.ComponentModel.DataAnnotations;

namespace AUCKPOLLWEB.Models
{
    public class gWaterQuality
    {
        [Key]
        public int sampleID { get; set; }
        public ICollection<regions> regionID { get; set; }
        public DateTime collection_date { get; set; }
        public string indicator { get; set; }
        public float value { get; set; }
        public string unit { get; set; }
    }
}

