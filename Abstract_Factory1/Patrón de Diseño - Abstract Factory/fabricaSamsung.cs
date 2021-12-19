using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_de_Diseño___Abstract_Factory
{
    class fabricaSamsung: fabrica
    {
        //método heredado para crear celular Samsung
        public override celular CrearCelular()
        {
            return new celularSamsung();
        }

        //método heredado para crear televisor Samsung
        public override televisor CrearTelevisor()
        {
            return new televisorSamsung();
        }
    }
}
