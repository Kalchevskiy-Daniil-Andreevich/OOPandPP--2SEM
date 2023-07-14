using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//самовалидация модели
namespace Лабораторная_работа___2
{
    public class Publ : IValidatableObject
    {
        [Required(ErrorMessage = "Отсутствует Countr")]
        public string Countr { get; set; }
        [Required(ErrorMessage = "Отсутствует City")]
        [StringLength(19, MinimumLength = 2, ErrorMessage = "Недопустимая длина времени")]
        public string City { get; set; }
        [Required(ErrorMessage = "Отсутствует YearOfGrounds")]
        public string YearOfGrounds { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(Countr))
                errors.Add(new ValidationResult("Не указана страна"));

            if (string.IsNullOrWhiteSpace(City))
                errors.Add(new ValidationResult("Не указан город"));
            return errors;
        }
    }
}
