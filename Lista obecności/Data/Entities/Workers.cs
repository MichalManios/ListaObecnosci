using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lista_obecności.Data.Entities;

namespace Lista_obecności.Data
{
    public class Workers:BaseEntity
    {
        
        [Required(ErrorMessage = "Imię pracownika jest wymagane!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwisko pracownika jest wymagane!!!")]
        public string Surname { get; set; }
        public bool IsManager { get; set; }
        [Required(ErrorMessage = "Nazwa działu jest wymagana!!!")]
        public string Section { get; set; }
    }
}
