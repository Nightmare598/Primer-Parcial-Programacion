using System;
using System.ComponentModel.DataAnnotations;

namespace Sebastian.Models
{
    public enum TypeTricks { Sandia, Sofa, Sierra }
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, ErrorMessage = "Entre 2 a 24 caracteres", MinimumLength = 2)]
        public string NickName { get; set; }
        [Required]
        public TypeTricks Tricks { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}