using PrimeraMaiuApp.Pages;

namespace PrimeraMaiuApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InicioPages();
        }
    }
}
