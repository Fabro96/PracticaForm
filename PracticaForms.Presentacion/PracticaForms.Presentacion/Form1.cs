using System;
using PracticaForms.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaForms.Presentacion
{
    public partial class Form1 : Form
    {
        private JugadorBL _servicioJugador;
        
        int cont = 0;

        private List<Jugador> listaJugador; 


        public Form1()
        {
            _servicioJugador = new JugadorBL();
            listaJugador = _servicioJugador.GetAll();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaJugador = _servicioJugador.GetAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Nombre = this.textBox1.Text;

            JugadorBL jugadorBL = new JugadorBL();
            jugadorBL.Insert(jugador);

            this.textBox1.Text = string.Empty;
        }
    }
}
