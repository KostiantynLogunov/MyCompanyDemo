using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page name (title)")]
        public override string Title { get; set; } = "Page info";

        [Display(Name = "Page inside")]
        public override string Text { get; set; } = "Inside of page is maked of Admin";
    }
}
