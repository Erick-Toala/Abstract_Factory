using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_de_Diseño___Abstract_Factory
{
    class televisorSamsung: televisor
    {
        //Producto B concreto Samsung
        public televisorSamsung()
        {
            _descripcion = "Televisor Samsung NeoQLED";
        }
    }
}
