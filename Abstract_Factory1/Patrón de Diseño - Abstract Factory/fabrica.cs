using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_de_Diseño___Abstract_Factory
{
    public abstract class fabrica
    {
        public string nombrefabrica { get; set; }

        //método abstract para crear celular
        public abstract celular CrearCelular();

        //método abstract para crear televisor
        public abstract televisor CrearTelevisor();
    }
}
