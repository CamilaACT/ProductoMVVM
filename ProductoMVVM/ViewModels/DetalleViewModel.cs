using ProductoMVVM.Models;
using ProductoMVVM.Views;
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
    public partial class DetalleViewModel
    {
        private  Producto _producto;
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public DetalleViewModel(Producto productp) //Constructor
        { 
            _producto = productp;
        }
        public void cargarDetalles()
        {
            Producto proctoactual= App.ProductRepository.Get(_producto.IdProducto);
            Nombre=proctoactual.Nombre;
            Descripcion=proctoactual.Descripcion;
            Cantidad=proctoactual.Cantidad;
            IdProducto = proctoactual.IdProducto;
            _producto=proctoactual;

                
        }
        

        public ICommand EditarProducto =>
         new Command(async () =>
         {
             
             await App.Current.MainPage.Navigation.PushAsync(new Editar(_producto)); //no cacho porque poner APP
         });
        public ICommand BorrarProducto =>
        new Command(async () =>
        {
            App.ProductRepository.Delete(_producto.IdProducto);
            await App.Current.MainPage.Navigation.PopAsync(); //no cacho porque poner APP
        });
    }
}
