using ProductoMVVM.ViewModels;

namespace ProductoMVVM.Views;

public partial class Detalle : ContentPage
{
	public Detalle()
	{
		InitializeComponent();
		BindingContext = new DetalleViewModel();
	}
}