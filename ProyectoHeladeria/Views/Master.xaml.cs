using ProyectoHeladeria.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoHeladeria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {

        public Master(string usuario, int Perfil_idPerfil)
        {
            InitializeComponent();
             lblUsuario.Text = usuario;
            if (Perfil_idPerfil == 1)
            {
                listadoPerfiles.IsVisible = true;
                listadoUsuarios.IsVisible = true;
                listadoClientes.IsVisible = true;
                listadoProductos.IsVisible = true;
                listadoVentas.IsVisible = true;
                listadoDetalles.IsVisible = true;
            }
            else if (Perfil_idPerfil == 2) {
                listadoPerfiles.IsVisible = false;
                listadoUsuarios.IsVisible = false;
                listadoClientes.IsVisible = false;
                listadoProductos.IsVisible = true;
                listadoVentas.IsVisible = true;
                listadoDetalles.IsVisible = true;
            }
            else if (Perfil_idPerfil == 3)
            {
                listadoPerfiles.IsVisible = false;
                listadoUsuarios.IsVisible = false;
                listadoClientes.IsVisible = false;
                listadoProductos.IsVisible = true;
                listadoVentas.IsVisible = false;
                listadoDetalles.IsVisible = true;
            }
        }

        private async void listadoPerfiles_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaPerfil());
        }

        private async void listadoUsuarios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaUsuario());
        }

        private async void listadoClientes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaCliente());
        }

        private async void listadoProductos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaProducto());
        }

        private async void listadoVentas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaVenta());
        }

        private async void listadoDetalles_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaDetalle());
        }

        private async void btnCerrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}