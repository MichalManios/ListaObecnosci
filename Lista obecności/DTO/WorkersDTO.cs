using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.DTO
{
    public class WorkersDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Imię pracownika jest wymagane!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwisko pracownika jest wymagane!!!")]
        public string Surname { get; set; }
        public bool IsManager { get; set; }
        [Required(ErrorMessage = "Nazwa działu jest wymagana!!!")]
        public string Section { get; set; }
    }
}
