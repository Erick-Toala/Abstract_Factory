using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_de_Diseño___Abstract_Factory
{
    public abstract class televisor
    {
        protected string _descripcion;

        //descripcion del televisor
        public object Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}
