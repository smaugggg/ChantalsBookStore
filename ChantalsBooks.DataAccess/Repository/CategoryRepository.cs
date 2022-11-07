using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ChantalsBooks.DataAccess;
using ChantalsBooks.DataAccess.Repository.IRepository;
using ChantalsBooks.Models;
using ChantalsBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace ChantalsBooks.DataAccess.Repository {
    class CategoryRepository : Repository<CategoryRepository>, ICategoryRepository {

        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }

        public void Update(Category category) {
            // use .NET LINQ to Retrive the first or default category object, 
            // then pass the id as a generic entity which matyches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }

        public void Add(Category entity) {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderby = null, string includeProperties = null) {
            throw new NotImplementedException();
        }

        public Category GetFirstOrDefault(Expression<Func<Category, bool>> filter = null, string includeProperties = null) {
            throw new NotImplementedException();
        }

        public void Remove(Category entity) {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Category> entity) {
            throw new NotImplementedException();
        }

        Category IRepository<Category>.Get(int id) {
            throw new NotImplementedException();
        }
    }
}
