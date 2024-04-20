using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class City
    {
        [Key]

        public int City_id { get; set; }
        public String City_name { get; set; }
        public String City_image { get; set; }

    }
}
