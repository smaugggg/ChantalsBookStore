using ChantalsBooks.DataAccess.Repository.IRepository;
using ChantalsBooks.Models;
using ChantalsBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ChantalsBooks.DataAccess;

namespace ChantalsBooks.DataAccess.Repository {
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository {
        
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
        
        public void Update(CoverType coverType) {


            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if(objFromDb != null) {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}
