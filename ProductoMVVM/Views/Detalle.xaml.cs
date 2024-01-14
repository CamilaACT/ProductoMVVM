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
		_viewModel = new DetalleViewModel(producto);
        BindingContext = _viewModel;
        _viewModel.cargarDetalles();
        _producto = producto;

    }
    protected override async void OnAppearing()
    {

        _viewModel.cargarDetalles();
    }

}