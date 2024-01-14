using ProductoMVVM.Services;
using ProductoMVVM.Views;

namespace ProductoMVVM
{
    public partial class App : Application
    {
        public static ProductRepository ProductRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductRepository = new ProductRepository();
            MainPage = new NavigationPage(new ProductoPage1());
        }
    }
}