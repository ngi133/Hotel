using _03_Dominio.Entidades.valueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.Entidades
{
    public class Reserva
    {
        int Id;
        Cliente Cliente;
        Habitacion Habitacion;
        FechaReserva fechaReserva; 

        // Otras propiedades relevantes para la reserva

        public Reserva(int id, Cliente cliente, Habitacion habitacion, DateTime fechaReserva)
        {
            this.Id = id;
            this.Cliente = cliente;
            this.Habitacion = habitacion;
            this.fechaReserva =  new FechaReserva(fechaReserva);

        }
    }
}

