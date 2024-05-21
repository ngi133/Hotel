using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.Entidades.valueObjects
{
    public class FechaReserva
    {

        private DateTime valor;


        public FechaReserva(DateTime valor)
        {
            this.valor = valor;
        }

        public DateTime Valor()
        {
            return this.valor;
        }
    }
}
