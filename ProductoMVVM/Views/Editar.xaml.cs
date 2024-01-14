using ProductoMVVM.Models;
using ProductoMVVM.ViewModels;

namespace ProductoMVVM.Views;

public partial class Editar : ContentPage
{
    private readonly EditarViewModel _viewModel;
    public Editar(Producto producto)
	{
		InitializeComponent();
        _viewModel = new EditarViewModel();
        BindingContext = _viewModel;
        _viewModel.cargarDetalles(producto);
    }
    //public Editar(EditarViewModel viewModel)
    //{
    //    InitializeComponent();
    //    _viewModel = viewModel;
    //    BindingContext = _viewModel;
    //}
}