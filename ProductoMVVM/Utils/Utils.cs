﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVM.Utils
{
    public class Utils
    {
        private const string DBFileName = "Producto.db";

        public const SQLiteOpenFlags Flags =
           SQLiteOpenFlags.ReadWrite |
           SQLiteOpenFlags.Create |
           SQLiteOpenFlags.SharedCache;

        public static string DataBasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
