using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XForms_YouTube_
{
    public partial class UserPage : ContentPage
    {
        //public UserModel user { get; set; }

        /*
    public UserPage(UserModel us)
    {
        InitializeComponent();
        //this.user = us;

        //Nos va a permitir asignar todas las propiedades de la clase UserModel a nuestra vista XAML
        BindingContext = us;

    }*/

        public UserPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var intent = Intent.Navigation.intent;
            var user = intent.GetObject<UserModel>("user");
            string msg = intent.GetString("msg");
            DisplayAlert("XForms", msg, "Aceptar");
            BindingContext = user;
        }


    }
}

