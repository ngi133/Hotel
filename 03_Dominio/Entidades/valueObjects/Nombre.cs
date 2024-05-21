using System;

namespace _03_Dominio.ValueObjects
{ 	
	public class Nombre
	{

		private string valor;


        public Nombre(string valor)
        {
            this.debeContenerNombre(valor);
            this.valor = valor;
        }

        private void debeContenerNombre(string nombre)
        {
            if (nombre == "")
            {
                throw new Exception("El Nombre no debe ser vacio");
            }
        }

		public string Valor() 
		{ 
			return this.valor; 
		}
	}
}
