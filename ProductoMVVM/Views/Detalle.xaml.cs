using ProductoMVVM.Models;
using ProductoMVVM.ViewModels;

namespace ProductoMVVM.Views;

public partial class Detalle : ContentPage
{
    private readonly DetalleViewModel _viewModel;
    public Detalle(Producto producto)
	{
		InitializeComponent();
		_viewModel = new DetalleViewModel();
        BindingContext = _viewModel;
        _viewModel.cargarDetalles(producto);

    }

}