using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class Admin
    {
        [Key]

        public int Adm_id { get; set; }
        public String Adm_name { get; set; }
        public String Adm_email { get; set; }
        public String Adm_password { get; set; }
        public String Adm_image { get; set; }

    }
}
