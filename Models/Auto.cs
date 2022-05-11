using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Web.CarDealership.BMW.Models
{
    public class Auto
    {
        [Display(Name = "Код автомобиля")]
        public long ID { get; set; }
        [Display(Name = "Марка")]
        public string Brand { get; set; }
        [Display(Name = "Код производителя")]
        public long? ManufID { get; set; }
        [Display(Name = "Производитель")]
        public Manufactures Manuf { get; set; }
        [Display(Name = "Код типа кузова")]
        public long? BTID { get; set; }
        [Display(Name = "Тип кузова")]
        public BodyType BT { get; set; }
        [Display(Name = "Дата производства")]
        public DateTime DateManufacture { get; set; }
        [Display(Name = "Цвет")]
        public string COLOR { get; set; }
        [Display(Name = "Номер кузова")]
        public string NumBody { get; set; }
        [Display(Name = "Номер двигателя")]
        public string NumEngine { get; set; }
        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }
        [Display(Name = "Код оборудования 1")]
        public long? AE1 { get; set; }
        [Display(Name = "Код оборудования 2")]
        public long? AE2 { get; set; }
        [Display(Name = "Код оборудования 3")]
        public long? AE3 { get; set; }

        [Display(Name = "Доп. оборудование")]
        public IList<AdditionalEquipment> AdditionalEquipment { get; set; }
        [Display(Name = "Цена")]
        public int Cost { get; set; }
        [Display(Name = "Код сотрудника")]
        public long? StaffID { get; set; }
        [Display(Name = "Сотрудник")]
        public Staff Staff { get; set; }

        public IList<Customers> Customers { get; set; }
    }
}
