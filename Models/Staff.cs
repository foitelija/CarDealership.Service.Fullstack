using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Web.CarDealership.BMW.Models
{
    public class Staff
    {
        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public long Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }
        [Display(Name = "Код должности")]
        public long? PositionID { get; set; }
        [Display(Name = "Должность")]
        public Position Position { get; set; }




        public IList<Customers> Customers { get; set; }
        public IList<Auto> Auto { get; set; }
        public IList<Manufacturers> Manufacturers { get; set; }
    }
}
