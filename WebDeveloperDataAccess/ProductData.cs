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
        public List<Product> getFakeProducts() {
            return new List<Product>
            {
                new Product {ID=1,Description="Cristal",Price =3.0,ManufacturingDate=DateTime.Now },
                new Product {ID=2,Description="Pilsen",Price =0.0 },
                new Product {ID=3,Description="Malca",Price =4.0 },
                new Product {ID=4,Description="Caral",Price =3.5 },
                new Product {ID=5,Description="Inka cola",Price =6.0,ManufacturingDate=DateTime.Now },
                new Product {ID=6,Description="Guarana",Price =0.0 }
            };

        }
     
        public Product GetProduct(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Products.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
