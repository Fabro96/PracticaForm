using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForms.Negocio
{
    public class JugadorBL
    {
        private List<Jugador> _listaJugadores;

        public JugadorBL()
        {
            _listaJugadores = new List<Jugador>();

            _listaJugadores.Add(new Jugador(1, 29, 19, "Juan Gonzalez"));
            _listaJugadores.Add(new Jugador(2, 22, 12, "Claudia Owen"));

        }
        
        public List<Jugador> GetAll()
        {
            return _listaJugadores;
        }
        public void Insert(Jugador jugador)
        {
            _listaJugadores.Add(jugador);
        }
    }
}
