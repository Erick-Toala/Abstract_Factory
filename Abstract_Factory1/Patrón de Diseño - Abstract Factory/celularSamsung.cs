using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_de_Diseño___Abstract_Factory
{
    class celularSamsung: celular
    {
        //Producto A concreto Samsung
        public celularSamsung()
        {
            _descripcion = "Celular Samsung Galaxy";
        }
    }
}
