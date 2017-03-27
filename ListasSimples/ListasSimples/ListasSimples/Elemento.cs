using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimples
{
    public class Elemento
    {
        
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }

    public class ListaElementos
    {
        public List<Elemento> elementosList;

        public ListaElementos()
        {
            elementosList = new List<Elemento>();
            LoadElements();
        }

        public void LoadElements()
        {
            elementosList.Add(new ListasSimples.Elemento
            {
                nombre = " Elemento 1",
                descripcion = " Descripcion al azar"
            });

            elementosList.Add(new ListasSimples.Elemento
            {
                nombre = " asdfasdas dasdas",
                descripcion = "  dasdas dsadsdad"
            });
        }
    }
}
