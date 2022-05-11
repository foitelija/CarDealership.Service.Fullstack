using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.CarDealership.BMW.Models
{
    public class AdditionalEquipment
    {
        [Display(Name = "Код оборудования")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name ="Характеристика")]
        public string Characteristics { get; set; }
        [Display(Name ="Цена")]
        public int cost { get; set; }

        public IList<Auto> Auto { get; set; }
    }
}
