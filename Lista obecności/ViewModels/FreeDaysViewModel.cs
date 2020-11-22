using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.ViewModels
{
    public class FreeDaysViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [IntegerValidator(MinValue = 1, MaxValue = 31)]
        [Required(ErrorMessage = "Dzień jest wymagany!!!")]
        public int Day { get; set; }
        [Required(ErrorMessage = "Nazwa miesiąca jest wymagana!!!")]
        [IntegerValidator(MinValue = 1, MaxValue = 12)]
        public int Month { get; set; }
        [Required(ErrorMessage = "Nazwa święta jest wymagana!!!")]
        public string NameOfHoliday { get; set; }
    }
}
