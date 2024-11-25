namespace Ejercicio_NET_MAUI.Pages;

public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage
            {
                Children =
            {
                new AreaCuadradoPage(),
                new AreaCirculoPage(),
                new AreaRectanguloPage()
            }
            };
        }
    }

