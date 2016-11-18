using System.ComponentModel.DataAnnotations;


namespace Travel_Blog.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}