using ChantalsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace ChantalsBooks.DataAccess.Repository.IRepository {
    public interface ICategoryRepository : IRepository<Category> {
        void Update(Category category);
    }
}
