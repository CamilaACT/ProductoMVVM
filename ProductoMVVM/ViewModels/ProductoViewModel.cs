using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using ProductoMVVM.Models;
using ProductoMVVM.Views;
using PropertyChanged;


namespace ProductoMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ProductoViewModel 
    {
        public ObservableCollection<Producto> ListaProductos { get; set; }

        public ProductoViewModel()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductRepository.GetAll());
        }
        public void CargarLista()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductRepository.GetAll());
        }



        public ICommand CrearProducto =>
            new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new NuevoProducto());
            });
        
        
    }
    
}
