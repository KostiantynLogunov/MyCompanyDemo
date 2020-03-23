using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Name (Title)")]
        public virtual string Title { get; set; }

        [Display(Name = "Short discription")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full discription")]
        public virtual string Text { get; set; }

        [Display(Name = "Title image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO metateg Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO metateg Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO metateg Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
