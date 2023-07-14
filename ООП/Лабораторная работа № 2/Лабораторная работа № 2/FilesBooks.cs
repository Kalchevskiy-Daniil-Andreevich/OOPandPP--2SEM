using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа___2
{
    public class FilesBooks : ValidationAttribute
    {
        [Required(ErrorMessage = "Отсутствует FormatBook")]
        public string FormatBook { get; set; }
        [Required(ErrorMessage = "Отсутствует SizeFileBook")]
        public string SizeFileBook { get; set;  }
        [Required(ErrorMessage = "Отсутствует NameBook")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string NameBook { get; set; }
        [Required(ErrorMessage = "Отсутствует Code")]
        [FilesBooks]
        public string Code { get; set; }
        [Required(ErrorMessage = "Отсутствует CountOfPages")]
        public string CountOfPages { get; set; }
        [Required(ErrorMessage = "Отсутствует Publishing")]
        public string Publishing { get; set; }
        [Required(ErrorMessage = "Отсутствует Years")]
        [RegularExpression(@"[0-9]{2}", ErrorMessage = "Неверный формат")]
        public string Years { get; set; }
        [Required(ErrorMessage = "Отсутствует ListOfAuthor")]
        public string ListOfAuthor { get; set; }
        public Authors author;
        public Publ pub;
        public Search search;
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string code = value.ToString();
                if (code.StartsWith("0"))
                    return true;
                else this.ErrorMessage = "Номер кода должен начинаться с 0";
            }
            return false;
        }
    }
}
