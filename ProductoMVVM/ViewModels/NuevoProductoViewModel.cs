using ProductoMVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace ProductoMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public partial class NuevoProductoViewModel
    {
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public int Cantidad {  get; set; }

       
        public ICommand GuardarProducto =>
            new Command(async ()=>
            {
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad
                };
                App.ProductRepository.Add(producto);
                await App.Current.MainPage.Navigation.PopAsync(); //no cacho porque poner APP
            });
        

    }
}
