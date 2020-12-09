using System;
using System.Collections.Generic;
using System.Text;

namespace aeropuerto
{
    class Asiento
    {
        public int numeroAsiento;
        public bool estado;
        public String comportamiento;

        public void Reservar()
        {
            Console.WriteLine("Reservar asiento");
        }

        public void Comprar()
        {
            Console.WriteLine("Comprar asiento");
        }

        public void MostrarDisponibilidad()
        {
            Console.WriteLine("Mostrar disponibilidad de  asiento");
        }

        public void Desbloquear()
        {
            Console.WriteLine("Desbloquear asiento");
        }

    }
}
