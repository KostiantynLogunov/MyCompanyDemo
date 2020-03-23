using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Input service name")]
        [Display(Name = "Service name")]
        public override string Title { get; set; }

        [Display(Name = "Short service discription")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full service discription")]
        public override string Text { get; set; }
    }
}
