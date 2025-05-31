using CadastroEventos.Views;

namespace CadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.CadastroEventos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var windows = base.CreateWindow(activationState);
            windows.Width = 400;
            windows.Height = 700;
            return windows;
        }
    }

}
