using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Web.CarDealership.BMW.Models
{
    public class Position
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }
        [Display(Name = "Наименование должности")]
        public string Name { get; set; }
        [Display(Name = "Оклад")]
        public int Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Duties { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }
        public IList<Staff> Staff { get; set; }
    }
}
