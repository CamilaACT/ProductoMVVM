using ProductoMVVM.Models;
using ProductoMVVM.ViewModels;


namespace ProductoMVVM.Views;

public partial class ProductoPage1 : ContentPage
{
    private readonly ProductoViewModel _viewModel;
    public ProductoPage1()
	{
        
        InitializeComponent();
        _viewModel = new ProductoViewModel();
        BindingContext = _viewModel;
    }
    protected override async void OnAppearing()
    {
        _viewModel.CargarLista();
    }
    private async void SeleccionarProducto(object sender, SelectedItemChangedEventArgs e)
    {

        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new Detalle(producto));
    }


}