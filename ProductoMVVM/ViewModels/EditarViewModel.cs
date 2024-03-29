﻿using ProductoMVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    
    public partial class EditarViewModel
    {
        private Producto _producto;
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public void cargarDetalles(Producto productp)
        {

            Nombre=productp.Nombre;
            Descripcion=productp.Descripcion;
            Cantidad=productp.Cantidad;
            _producto=productp;
        }
        public ICommand EditarProducto =>
         new Command(async () =>
         {
             Producto producto = new Producto
             {
                 IdProducto=_producto.IdProducto,
                 Nombre = Nombre,
                 Descripcion = Descripcion,
                 Cantidad = Cantidad
             };
             App.ProductRepository.Update(producto);
             await App.Current.MainPage.Navigation.PopAsync(); //no cacho porque poner APP
         });
    }
}
