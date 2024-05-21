using _03_Dominio.Entidades;
using _03_Dominio.Repositorio;

namespace _02_Aplicacion
{
    public class ReservaService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IHabitacionRepositorio _habitacionRepositorio;
        private readonly IReservaRepositorio _reservaRepositorio;

        public ReservaService(IClienteRepositorio _clienteRepositorio, IHabitacionRepositorio _habitacionRepositorio, IReservaRepositorio _reservaRepositorio)
        {
            this._clienteRepositorio = _clienteRepositorio;
            this._habitacionRepositorio = _habitacionRepositorio;
            this._reservaRepositorio = _reservaRepositorio;
        }

        public void RealizarReserva(Identificador id, int habitacionNumero, DateTime fechaReserva)
        {
            var cliente = _clienteRepositorio.ObtenerPorId(id);
            var habitacion = _habitacionRepositorio.ObtenerPorNumero(habitacionNumero);

            var reserva = new Reserva(1, cliente, habitacion, fechaReserva);
            _reservaRepositorio.Guardar(reserva);
        }
    }

}
