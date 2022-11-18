using System;
using System.Collections.Generic;
using System.Text;
using ChantalsBooks.Models;

namespace ChantalsBooks.DataAccess.Repository.IRepository {
    public interface IProductRepository : IRepository<Product> {
        void Update(Product product);
    }
}
