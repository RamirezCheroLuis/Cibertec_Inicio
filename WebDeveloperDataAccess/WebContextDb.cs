using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloperDataAccess
{
    //escribimos DbContext y luego con la ayuda importamos using System.Data.Entity;
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
            //Database.SetInitializer(new WebDeveloperInitializer());
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        //Vamos a conf para que no salga en plural
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
