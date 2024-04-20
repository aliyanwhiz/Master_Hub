using System.ComponentModel.DataAnnotations;

namespace DashBoard2.Models
{
    public class Feedback
    {
        [Key]
        public int Feedback_Id { get; set; }
        public String Feedback_name { get; set; }
        public String Feedback_Message { get; set; }
    }
}
