using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class Services
    {

        [Key]
        public int Service_Id { get; set; }
        public String Services_Name { get; set; }
		public String Services_Image { get; set; }

	}
}
