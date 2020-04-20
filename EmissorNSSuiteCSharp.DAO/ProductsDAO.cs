using EmissorNSSuiteCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EmissorNSSuiteCSharp.DAO
{
    public class ProductsDAO : IDisposable
    {
        private NSSuiteContext Context;
        public ProductsDAO()
        {
            this.Context = new NSSuiteContext();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
        public void Add(Product p)
        {
            Context.Product.Add(p);
            Context.SaveChanges();
        }
        public void Update(Product p)
        {
            Context.Product.Update(p);
            Context.SaveChanges();
        }
        public void Delete(Product p)
        {
            Context.Product.Remove(p);
            Context.SaveChanges();
        }
        public List<Product> Products()
        {
            return Context.Product.ToList();
        }
    }
}
