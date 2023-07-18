using System.ComponentModel.DataAnnotations;

namespace AUCKPOLLWEB.Models
{
    public class regions
    {
        [Key]
        public int regionID { get; set; }
        public string region_name { get; set; }
        public int region_pop { get; set; }
    }
}
