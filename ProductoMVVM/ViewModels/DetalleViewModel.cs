﻿using ProductoMVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class DetalleViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public DetalleViewModel() //Constructor
        { 
            
        }
        public void cargarDetalles(Producto productp)
        {
            Nombre=productp.Nombre;
            Descripcion=productp.Descripcion;
            Cantidad=productp.Cantidad;
        }
      

    }
}
