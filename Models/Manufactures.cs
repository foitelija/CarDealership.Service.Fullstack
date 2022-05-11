using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.CarDealership.BMW.Models
{
    public class Manufactures
    {
        [Display(Name = "Код производителя")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Страна")]
        public string Country { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Код сотрудника")]
        public long? StaffID { get; set; }
        [Display(Name = "Сотрудник")]
        public Staff Staff { get; set; }


        public IList<Auto> Auto { get; set; }
    }
}
