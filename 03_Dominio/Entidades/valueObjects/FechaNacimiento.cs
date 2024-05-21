using System;

namespace _03_Dominio.ValueObjects
{
    public class FechaNacimiento
    {

        private DateTime valor;


        public FechaNacimiento(DateTime valor)
        {
            this.debeSerMayorDeEdad(valor);
            this.valor = valor;
        }

        private void debeSerMayorDeEdad(DateTime valor)
        {
            if (EsMayorDeEdad(valor))
            {
                Console.WriteLine("¡Eres mayor de 18 años!");
            }
            else
            {
                throw new Exception("Eres menor de 18 años.");
            }
        }

        static bool EsMayorDeEdad(DateTime valor)
        {
            string fechaStr = valor.ToString("ddMMyyyy"); // Convierte a formato "ddMMyyyy"
            DateTime fechaNacimiento;
            if (DateTime.TryParseExact(fechaStr, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
            {
                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (DateTime.Now < fechaNacimiento.AddYears(edad))
                {
                    edad--;
                }
                return edad >= 18;
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento inválida.");
                return false;
            }


        }


        public DateTime Valor()
        {
            return this.valor;
        }
    }
}