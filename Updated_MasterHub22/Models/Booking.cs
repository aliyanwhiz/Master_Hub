using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
	public class Booking
	{
		[Key]

		public int Book_Id { get; set; }
		public string Custmers_name { get; set; }
		public string Custmers_email { get; set; }
		public string Custmers_phone { get; set; }
		public string Service_name { get; set; }
		public String Messages { get; set; }
	}
}
