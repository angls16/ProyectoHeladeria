using Newtonsoft.Json;
using ProyectoHeladeria.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoHeladeria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaVenta : ContentPage
    {
        private const string Url = "http://10.20.20.251/heladeria/postVentas.php";

        private readonly HttpClient client = new HttpClient();
        public ObservableCollection<Ventas> _post;
        public int idVentas = -1;
        public string fecha;
        public int numeroVenta, Usuario_idUsuario, Clientes_idUsuario;
        public double precioTotal;

        public ListaVenta()
        {
            InitializeComponent();
            Get();
        }

        private void lstVentas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Ventas)e.SelectedItem;
            idVentas = obj.idVentas;
            numeroVenta = obj.numeroVenta;
            fecha = obj.fecha;
            precioTotal = obj.precioTotal;
            Usuario_idUsuario = obj.Usuario_idUsuario;
            Clientes_idUsuario = obj.Clientes_idUsuario;
            
        }
        public async void Get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<Ventas> post =
                    JsonConvert.DeserializeObject<List<Ventas>>(content);
                _post = new ObservableCollection<Ventas>(post);
                lstVentas.ItemsSource = post;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}