namespace SPM.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TaskStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
