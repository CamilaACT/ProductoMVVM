using ProductoMVVM.Models;
using ProductoMVVM.ViewModels;

namespace ProductoMVVM.Views;

public partial class Detalle : ContentPage
{
    private readonly DetalleViewModel _viewModel;
    private Producto _producto;
    public Detalle(Producto producto)
	{
		InitializeComponent();
		_viewModel = new DetalleViewModel();
        BindingContext = _viewModel;
        _viewModel.cargarDetalles(producto);
        _producto = producto;

    }
    protected override async void OnAppearing()
    {
        _viewModel.cargarDetalles(_producto);
    }

}