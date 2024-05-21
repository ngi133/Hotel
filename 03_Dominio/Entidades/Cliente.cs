using _03_Dominio.ValueObjects;
namespace _03_Dominio.Entidades
{
    public class Cliente
    {
        Identificador id; 
        Nombre nombre; 
        Apellido apellido;
        FechaNacimiento fechaNacimiento;

        public Cliente(Guid id, string nombre, string apellido, DateTime fechaNacimiento)
        {

            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);
        }



        
        
    }
}
