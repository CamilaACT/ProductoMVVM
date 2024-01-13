using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoMVVM.Models;

namespace ProductoMVVM.ViewModels
{
    public class ProductoViewModel
    {
        public List<Producto> ListaProductos { get; set; }

        public ProductoViewModel()
        {
            ListaProductos = new List<Producto>();
        }


            

    }
    
}
