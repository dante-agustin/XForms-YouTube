using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListasSimples
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        //Cuando aparezca la página
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos elementos = new ListaElementos();
            lvElementos.ItemsSource = elementos.elementosList;
            lvElementos.ItemSelected += LvElementos_ItemSelected;
        }

        private void LvElementos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if( e.SelectedItem != null){
                var element = e.SelectedItem as Elemento;
                DisplayAlert("Listas", element.descripcion , "Aceptar");
            }

        }
    }
}
