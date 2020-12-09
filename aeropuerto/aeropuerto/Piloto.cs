using System;
using System.Collections.Generic;
using System.Text;

namespace aeropuerto
{
    class Piloto
    {
        public String codigoPiloto;
        public String nombre;
        public String apellido;
        public int numeroLicencia;

        public void AgregarNuevo()
        {
            Console.WriteLine("Agregar nuevo");
        }

        public void AsignarVuelo()
        {
            Console.WriteLine("Asignar vuelo");
        }

        public void CacelarVuelo()
        {
            Console.WriteLine("Cancelar vuelo");
        }

        public void ModificarVuelo()
        {
            Console.WriteLine("Modificar vuelo");
        }

        public void BuscarVuelo()
        {
            Console.WriteLine("Buscar vuelo");
        }

    }
}
