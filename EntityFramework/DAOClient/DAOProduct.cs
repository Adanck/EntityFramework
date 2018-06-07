using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace DAOClient
{
    class DAOProduct
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        private StoreEntities store = new StoreEntities();

        public DAOProduct() { }

        public DAOProduct(string code, string description, decimal price, int amount) {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            this.Amount = amount;
        }

        public void insert(TObject.Product p)
        {
            Product pro = new Product(p.Code,p.Description,p.Price,p.Amount);
            store.Products.Add(pro);
            store.SaveChanges();
        }

        //public TObject.Product selectProduct(string code)
        //{
         //   store.Database.
       // }
    }
}
