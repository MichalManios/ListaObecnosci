using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.DTO
{
    public class UsersDTO : IdentityUser
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public override string Id { get; set; }
        [Required (ErrorMessage ="Nazwa użytkownika jest wymagana!!!")]
        public override string UserName { get; set; }
        
        [Required (ErrorMessage = "Musisz podać hasło!!!")]
        [DataType(DataType.Password)]
        public override string PasswordHash { get; set; }

        [Required(ErrorMessage = "Musisz podać datę urodzenia!!!")]
        [DataType(DataType.Date, ErrorMessage ="Niewłaściwe dane lub format!!!")]
        [StringLength(10, MinimumLength = 8, ErrorMessage ="Za mało znaków dla formatu daty!!!")]
        [RegularExpression(@"\d{1,2}.\d{1,2}.\d{2,4}", ErrorMessage = "Właściwy format daty to DD.MM.RRRR!!!")]
        public string sBirthdayDate { get; set; }

        [Required(ErrorMessage = "Musisz podać adres email!!!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Niewłaściwy format email!!!")]
        public override string Email { get; set; }
    }
}
