﻿using AuthenticationServices;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVM.Models
{
    [Table("Productos")]
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int IdProducto { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("descripcion")]
        public string Description { get; set; }
        [Column("cantidad")]
        public int Cantidad { get; set; }
    }
}