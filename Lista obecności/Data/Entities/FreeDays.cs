using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lista_obecności.Data.Entities;
using System.Configuration;

namespace Lista_obecności.Data
{
    public class FreeDays : BaseEntity
    {
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
