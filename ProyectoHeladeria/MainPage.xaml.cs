using ProyectoHeladeria.Models;
using ProyectoHeladeria.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProyectoHeladeria
{
    public partial class MainPage : MasterDetailPage
    {
        Usuario inicioSesion;
        public MainPage(Usuario post)
        {
            
            InitializeComponent();
            inicioSesion = post;
            this.Master = new Master(post.usuario, post.Perfil_idPerfil);
            this.Detail = new NavigationPage(new Principal());
            App.MasterDetail = this;
        }


    }
}
