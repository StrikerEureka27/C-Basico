using System;
using System.Collections.Generic;
using System.Text;


namespace aeropuerto
{
    class Pasajero
    {
        public String cedula;
        public String nombre;
        public String apellido;
        public String sexo;
        public int edad;

        public void AgregarNuevo()
        {
            Console.WriteLine("Agregar nuevo pasajero");
            
        }

        public void Modificar()
        {
            Console.WriteLine("Modificar nuevo pasajero");
        }

        public void AsignarVuelo()
        {
            Console.WriteLine("Asignar a nuevo pasajero");
        }

        public void Buscar()
        {
            Console.WriteLine("Buscar pasajero");
        }

    }
}
