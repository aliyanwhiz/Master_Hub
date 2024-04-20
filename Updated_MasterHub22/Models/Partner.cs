using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class Partner
    {


        [Key]
        public int Partner_Id { get; set; }
        public String Partner_name { get; set; }
        public String Partner_phonr { get; set; }
        public String Partner_experties { get; set; }
    }
}
