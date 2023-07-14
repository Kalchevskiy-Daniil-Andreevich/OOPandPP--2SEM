using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа___2
{
    public class Authors 
    {
        [Required(ErrorMessage = "Отсутствует OtchestvoAuthor")]
        public string OtchestvoAuthor { get; set; }
        [Required(ErrorMessage = "Отсутствует Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Отсутствует Id")]
        [Range(1, 10000)]
        public string Id { get; set; }
        public string NubmerPassport { get; set; }
    }
}
