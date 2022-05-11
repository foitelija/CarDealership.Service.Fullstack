using System;
using System.ComponentModel.DataAnnotations;
namespace Web.CarDealership.BMW.Models
{
    public class Customers
    {
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public long Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassData { get; set; }
        [Display(Name = "Код автомобиля")]
        public long? AutoID { get; set; }
        [Display(Name = "Автомобиль")]
        public Auto Auto { get; set; }
        [Display(Name = "Дата заказа")]
        public DateTime DateOrder { get; set; }
        [Display(Name = "Дата продажи")]
        public DateTime DateSale { get; set; }
        [Display(Name = "Отметка о выполнении")]
        public bool MarkCompletion { get; set; }
        [Display(Name = "Отметка об оплате")]
        public bool MarkPrice { get; set; }
        [Display(Name = "Процент предоплаты")]
        public int PrecPrePlay { get; set; }
        [Display(Name = "Код сотрудника")]
        public long? StaffID { get; set; }
        [Display(Name = "Сотрудник")]
        public Staff Staff { get; set; }
    }
}
