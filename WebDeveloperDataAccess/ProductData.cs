using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloperDataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        //public List<Client> getFakeData() ahi va sin el : BaseDataAccess
        //{
        //    return new List<Client>
        //    {

        //        new Client {ID=1,Name="Juan",LastName="Perez" },
        //        new Client {ID=2,Name="Raul",LastName="Ruidiaz" }
        //    };
        //}
        //public List<Client> getList()
        //{
        //    using (var dbContext = new WebContextDb())
        //    {
        //        return dbContext.Clients.ToList();
        //    }
        //}

        public Product GetProduct(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Products.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
