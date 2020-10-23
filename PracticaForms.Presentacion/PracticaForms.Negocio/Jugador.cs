using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForms.Negocio
{
    public class Jugador
    {
        private int _codigo;
        private string _nombre;
        private int _edad;
        private int _distancia;

        public Jugador() { }

        public Jugador(int codigo, int edad, int distancia, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._edad = edad;
            this._distancia = distancia;
        }

        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public int Edad
        {
            set { _edad = value; }
            get { return _edad;  }
        }
        public int Distancia
        {
            set { _distancia = value; }
            get { return _distancia;  }
        }

        public override string ToString()
        {
            return string.Format("Jugador {0} Nombre {1} Edad {2} Distancia {3}", this.Codigo, this.Nombre, this.Edad.ToString(), this.Distancia);
        }
    }
}
