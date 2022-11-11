﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChantalsBooks.DataAccess.Repository.IRepository {
    public interface ISP_Call : IDisposable {

        // e. g. first column of first row in the result set
        T Single<T>(string procedurename, DynamicParameters param = null);

        //execute something to the database but not retrieve.
        void Execute(string procedurename, DynamicParameters param = null);

        // retrieves the row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);

        // get all rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);

        // stored procedure that returns two tables
        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }

}
