using _03_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.Repositorio
{
    public interface IClienteRepositorio
    {
        Cliente ObtenerPorId(Identificador id);
        public void Guardar(Cliente cliente);
    }
}

