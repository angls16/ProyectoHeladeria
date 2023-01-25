using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoHeladeria.Models;

namespace ProyectoHeladeria.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaUsuario : ContentPage
	{
        private const string Url = "http://10.20.20.251/heladeria/postUsuario.php";

        private readonly HttpClient client = new HttpClient();
        public ObservableCollection<Usuario> _post;
        public int idUsuario = -1;
        public string nombres,cedula,apellidos,telefono,direccion,correo,usuario;
        public int estado;
        public ListaUsuario()
        {
            InitializeComponent();
            Get();
        }

        private void lstUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Usuario)e.SelectedItem;
            idUsuario = obj.idUsuario;
            nombres = obj.nombres;
            apellidos = obj.apellidos;
            cedula = obj.cedula;
            telefono = obj.telefono;    
            direccion = obj.direccion;
            usuario = obj.usuario;
            correo = obj.correo;
            estado = obj.estado;

            
        }


        public async void Get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<Usuario> post =
                    JsonConvert.DeserializeObject<List<Usuario>>(content);
                _post = new ObservableCollection<Usuario>(post);
                lstUsuarios.ItemsSource = post;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}