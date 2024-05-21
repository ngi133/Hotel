using _03_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03_Dominio.Entidades
{
    public class Habitacion
    {
        Numero  numero;
        

        public Habitacion(int numero)
        {

            this.numero = new Numero(numero);
            
        }
    }
}

