using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using agenda2dev.Models;
using Android.Service.Voice;

namespace agenda2dev.Helpers
{
    public class SQLiteDatabaseHelper
    {

        readonly SQLiteAsyncConnection _conn;
        public SQLiteDatabaseHelper (string path) 
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();

        }
    public Task<int> Insert (Produto p) 
        {
            return _conn.InsertAsync(p);
        }

        public void Update (Produto p) { }
    
    public void Delete (int id) { }
         
    public void GetAll () { }

        public void Search(string q)
    }

}
