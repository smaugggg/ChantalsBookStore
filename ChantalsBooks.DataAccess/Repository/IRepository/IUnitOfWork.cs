using System;
using System.Collections.Generic;
using System.Text;
using ChantalsBooks.DataAccess.Repository;


namespace ChantalsBooks.DataAccess.Repository.IRepository {
    public interface IUnitOfWork : IDisposable {
        ICategoryRepository Category { get;   }
        ISP_Call SP_Call { get;  }
    }
}
