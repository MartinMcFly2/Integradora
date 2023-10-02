using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppRegistrosA.Models;

namespace AppRegistrosA.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Empleados>().Wait();
        }
    }
}
