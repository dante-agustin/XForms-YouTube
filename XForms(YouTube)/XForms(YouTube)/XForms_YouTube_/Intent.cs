using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms_YouTube_
{

    //Manejador de navegacion

    //Intent en android con una varacion en el constructor (que le metemos nosotros)
    //De esta manera podemos enviar objetos y más cosas a traves de las paginas de una manera más estilizada
    //y mejor programada al estilo de android
    public class Intent
    {
        public Page startPage { get; set; }
        public Page endPage { get; set; }
        public Dictionary<string, object> dataObject { get; set; }    
        public Dictionary<string,string> dataString { get; set; }

        public class Navigation
        {
            public static Intent intent  { get; set; }
        }

        public Intent ( Page startPage, Page endPage)
        {
            this.startPage = startPage;
            this.endPage = endPage;
            dataObject = new Dictionary<string, object>();
            dataString = new Dictionary<string, string>();

        }

        public void PutObject(string key, object obj)
        {
            if (dataObject.ContainsKey(key)) //si ya existe la key no la podemos sobreescribir
            {
                throw new ArgumentException("La llave ya existe.");
            }
            dataObject.Add(key, obj);
        }

        public void PutString( string key,string value)
        {
            if( dataString.ContainsKey(key) ) //si ya existe la key no la podemos sobreescribir
            {
                throw new ArgumentException("La llave ya existe.");
            }
            dataString.Add(key, value);
        }

        //T es un generico
        public T GetObject<T>(string key)
        {
            if( dataObject.ContainsKey(key)) {
                return (T)dataObject[key];
            }
               
            throw new ArgumentException("La llave no existe.");
        }

        //no regresamos un T
        public string GetString(string key)
        {
            if (dataString.ContainsKey(key) )
            {
                return dataString[key];
            }

            throw new ArgumentException("La llave no existe.");
        }

        public void StartIntent()
        {
            Navigation.intent = this;
            //animación true
            startPage.Navigation.PushModalAsync(endPage, true);
        }
    }
}
