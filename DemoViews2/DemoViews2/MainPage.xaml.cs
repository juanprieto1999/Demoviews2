using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoViews2
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }
        async void Handle_Navigated(object sender, WebNavigatingEventArgs e){
            await DisplayAlert("Completado", "Se ha completado la cargar de la Pagina", "OK");

        }

    }
}
