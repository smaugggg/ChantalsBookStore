using System;
using System.Collections.Generic;
using System.Text;
using ChantalsBooks.Models;

namespace ChantalsBooks.DataAccess.Repository.IRepository {
    public interface ICategoryRepository {
        void Update(Category category);
    }
}
