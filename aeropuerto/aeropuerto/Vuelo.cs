using System;
using System.Collections.Generic;
using System.Text;

namespace aeropuerto
{
    class Vuelo
    {
        public int numeroVuelo;
        public string horaSalida;
        public String horaLlegada;
        public String lugarOrigen;
        public String lugarDestino;
        public String fechaSalida;
        public String fechaRegreso;
        public String tipoVuelo;

        public void Reservar()
        {
            Console.WriteLine("Reservar vuelos");
        }

        public void Modificar()
        {
            Console.WriteLine("Reservar vuelos");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminar vuelo");
        }

        public void Buscar()
        {
            Console.WriteLine("Buscar vuelo");
        }

    }
}
