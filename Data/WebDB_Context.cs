using Microsoft.EntityFrameworkCore;
using Web.CarDealership.BMW.Models;

namespace Web.CarDealership.BMW.Data
{
    public class WebDB_Context :DbContext
    {
        public WebDB_Context(DbContextOptions<WebDB_Context> options) : base(options) { }

        public DbSet<Web.CarDealership.BMW.Models.AdditionalEquipment> AdditionalEquipment { get; set; }

        public DbSet<Web.CarDealership.BMW.Models.Manufactures> Manufactures { get; set; }
        public DbSet<Web.CarDealership.BMW.Models.Customers> Customers { get; set; }    
        public DbSet<Web.CarDealership.BMW.Models.Auto> Auto { get; set; }  
        public DbSet<Web.CarDealership.BMW.Models.BodyType> BodyType { get; set; }  
        public DbSet<Web.CarDealership.BMW.Models.Position> Position { get; set; } 

        public DbSet<Web.CarDealership.BMW.Models.Staff> Staff { get; set; }
    }
}
