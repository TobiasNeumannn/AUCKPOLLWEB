using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace AUCKPOLLWEB.Models
{
    public class estuaryQuality

    {
        [Key]
        [Display(Name = "Sample ID")]
        public int sampleID { get; set; }
        [Display(Name = "Region ID")]
        public int ID { get; set; }
        [Display(Name = "Collection ID")]
        public DateTime collection_date { get; set; }
        [Display(Name = "Indicator")]
        public string indicator { get; set; }
        [Display(Name = "Value")]
        public float value { get; set; }

        public regions Region { get; set; }

    }
}
