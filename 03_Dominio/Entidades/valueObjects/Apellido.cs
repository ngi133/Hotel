using System;

namespace _03_Dominio.ValueObjects
{
    public class Apellido
    {

        private string valor;


        public Apellido(string valor)
        {
            this.debeContenerApellido(valor);
            this.valor = valor;
        }

        private void debeContenerApellido(string apellido)
        {
            if (apellido == "")
            {
                throw new Exception("El apellido no debe ser vacio");
            }
        }


        public string Valor()
        {
            return this.valor;
        }
    }
}