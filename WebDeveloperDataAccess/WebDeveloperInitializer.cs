using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloperDataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client> {
                new Client {Name="Jose",LastName="Perez" },
                new Client {Name="Juan",LastName="Ruidiaz" },
                new Client {Name="Juanelo",LastName="Ruidiaz" },
                new Client {Name="Alan",LastName="Ruidiaz" },
                new Client {Name="Pedro",LastName="Ruidiaz" }
          };
            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var produc = new List<Product> {
                new Product {Description="Gaseosa Inka cola",Quantity=5,Stock=500,ExperiredDate="01/06/2016",Price=12.5 } 
                
          };
            produc.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}
