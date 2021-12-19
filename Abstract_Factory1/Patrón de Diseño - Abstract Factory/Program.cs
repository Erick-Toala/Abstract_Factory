using System;

namespace Patrón_de_Diseño___Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaz
            Console.WriteLine("         ABSTRACT FACTORY");
            Console.WriteLine("          ULEAM ECUADOR");
            Console.WriteLine(" Facultad de Ciencias Informaticas");
            Console.WriteLine("    Manta - Manabí - Ecuador\n");
            Console.WriteLine("   Fecha: " + DateTime.Now+ "\n");

            //Instanciar la fabrica
            fabrica fabrica1;
            //crear una fabrica para Samsung
            fabrica1 = new fabricaSamsung();

            celular celular1 = fabrica1.CrearCelular();
            televisor televisor1 = fabrica1.CrearTelevisor();
            fabrica1.nombrefabrica = "Samsung";
            Console.WriteLine("-- " + fabrica1.nombrefabrica + " ---------------\n" + celular1.Descripcion + " \n" + televisor1.Descripcion + "\n");

            //crear una fabrica para Sony
            fabrica1 = new fabricaSony();
            celular1 = fabrica1.CrearCelular();
            televisor1 = fabrica1.CrearTelevisor();
            fabrica1.nombrefabrica = "Sony";
            Console.WriteLine("-- " + fabrica1.nombrefabrica + " ---------------\n" + celular1.Descripcion + " \n" + televisor1.Descripcion + "\n");
        }
    }
}
