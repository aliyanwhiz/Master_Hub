using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class Customer
    {
        [Key]

        public int Cus_id { get; set; }
        public String Cus_name { get; set; }
        public String Cus_email { get; set; }
        public String Cus_password { get; set; }
        public String Cus_phone { get; set; }
        public String Cus_city { get; set; }
        public String Cus_address { get; set; }
    }
}
