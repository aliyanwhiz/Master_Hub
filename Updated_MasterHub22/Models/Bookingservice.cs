using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class Bookingservice
    {

        [Key]
        public int Book_id { get; set; }
		/*[Required(ErrorMessage = "Customer Name is required.")]
		[StringLength(10, MinimumLength = 3, ErrorMessage = "Customer Name must be between 3 and 10 characters.")]*/
		public String customer_name { get; set; }

		/*[Required(ErrorMessage = "Customer Email is required.")]
		[StringLength(30, MinimumLength = 3, ErrorMessage = "Customer Email must be between 3 and 30 characters.")]
		[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Invalid email format.")]*/
		public String customer_email { get; set; }

	/*	[Required(ErrorMessage = "Customer Phone Number is required.")]
		[StringLength(11, MinimumLength = 11, ErrorMessage = "Customer Phone number  must be between 0 and 11 characters.")]
		[RegularExpression(@"^(?:(?:\+|00)92|0)[1-9]\d{9}$", ErrorMessage = "Invalid Pakistani phone number.")]*/
		public String customer_phone { get; set; }

		/*[Required(ErrorMessage = "Service Date is required.")]*/
		public String customer_date { get; set; }

		public String service_name { get; set; }
        public String city_name { get; set; }


		/*[Required(ErrorMessage = "Customer Message is required.")]
		[StringLength(150, MinimumLength = 10, ErrorMessage = "Customer Message must be between 10 and 150 characters.")]
		[RegularExpression(@"^(?:(?:\+|00)92|0)[1-9]\d{9}$", ErrorMessage = "Invalid Pakistani phone number.")]*/
		public String customer_message { get; set; }

    }
}
