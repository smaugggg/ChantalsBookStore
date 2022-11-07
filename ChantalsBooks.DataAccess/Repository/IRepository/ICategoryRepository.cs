using System;
using System.Collections.Generic;
using System.Text;
using ChantalsBooks.Models;

namespace ChantalsBooks.DataAccess.Repository.IRepository {
    interface ICategoryRepository {
        void Update(Category category);
    }
}
