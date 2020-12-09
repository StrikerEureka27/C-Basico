using System;
using System.Collections.Generic;
using System.Text;

namespace aeropuerto
{
    class Avion
    {
        public String aerolinea;
        public String  codigoDeAvion;
        public int numeroAsientos;
        public String comportamiento;

        public void AsignarVuelo()
        {
            Console.WriteLine("Asignar vuelo");
        }

        public void ObtenerVuelo()
        {
            Console.WriteLine("Obtener Vuelo");
        }

        public void CancelarVuelo()
        {
            Console.WriteLine("Cancelar Vuelo");
        }

    }

     

}
