using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms_YouTube_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Se ejecuta cuando la aplicacion aparece, cuando termian de cargar
            /***btnSumar.Clicked += BtnSumar_Clicked;   //crea evento click ***/
        }


        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = etNombre.Text;

            if (!string.IsNullOrEmpty(nombre))  //Si no esta vacío el edit text
            {
                //DisplayAlert("Xamarin Forms", nombre, "Aceptar");

                var user = new UserModel { name = nombre };

                //Tiene la ventaja de que le podemos mandar más elementos al intent
                Intent intent = new XForms_YouTube_.Intent(this, new UserPage());
                intent.PutObject("user", user);
                intent.PutString("msg", "Todo piola");
                intent.StartIntent();   //inicia la navegacion



               // this.Navigation.PushModalAsync(new UserPage(user)); //abrir una nueva pag
            }

        }

        /***
        private void BtnSumar_Clicked(object sender, EventArgs e)
        {
            count++;
            btnSumar.Text = count.ToString();
        }
        ***/
    }
}
