using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_de_Diseño___Abstract_Factory
{
    class fabricaSony: fabrica
    {
        //método heredado para crear celular Sony
        public override celular CrearCelular()
        {
            return new celularSony();
        }

        //método heredado para crear televisor Sony
        public override televisor CrearTelevisor()
        {
            return new televisorSony();
        }
    }
}
