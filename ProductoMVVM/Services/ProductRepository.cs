using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVM.Services
{
   
    public class ProductRepository

    {
        SQLiteConnection connection;
        public ProductRepository()
        {
            connection = new SQLiteConnection(Utils.DataBasePath, Utils.Flags);
            connection.CreateTable<Producto>();
        }

        
    }
}
