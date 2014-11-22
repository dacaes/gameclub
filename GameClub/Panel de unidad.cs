using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameClub
{
    public partial class Panel_de_unidad : Form
    {
        //UnidadJuego unidad = new UnidadJuego();
        Juego juego;
        Ficha_de_juego fichaJuego;
        Ficha_de_unidad_y_prestamos fichaUnidad;
        public Panel_de_unidad()
        {
            InitializeComponent();
        }

        public Panel_de_unidad(Juego juego, Ficha_de_juego fichaJuego, Ficha_de_unidad_y_prestamos fichaUnidad)
        {
            InitializeComponent();
            this.juego = juego;
            this.fichaUnidad = fichaUnidad;
            this.fichaJuego = fichaJuego;
        }

        private void Panel_de_unidad_Load(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            textBoxTitulo.Text = juego.titulo;
            textBoxIDJuego.Text = Convert.ToString(juego.idFicha);

            foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socio))
                {
                    comboBoxAliasPropietario.Items.Add(socio_buscado.alias);
                }
        }

        private void buttonModificar_JuegoAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxAliasPropietario.SelectedIndex != -1)
            {
                UnidadJuego nuevaUnidad = new UnidadJuego();
                nuevaUnidad.idJuego = juego.idFicha;
                nuevaUnidad.aliasDueño = comboBoxAliasPropietario.SelectedItem.ToString();

                UnidadJuego unidadAux = new UnidadJuego();
                //valores inválidos para el club
                unidadAux.idJuego = -1;
                unidadAux.idUnidad = -1;
                bool existe = true;
                int id;
                for (id = 0; existe == true; id++)
                {
                    existe = false;
                    unidadAux.idUnidad = id;
                    foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidadAux))
                    {
                        existe = true;
                    }
                }
                nuevaUnidad.idUnidad = id - 1;
                nuevaUnidad.fechaAlta = DateTime.Today;
                Club.Instance.AltaUnidadJuego(nuevaUnidad);

                fichaUnidad.refresco(nuevaUnidad.idUnidad + " " + nuevaUnidad.aliasDueño);
                fichaJuego.refresco(juego);

                this.Hide();
            }
            Club.Instance.refrescoGeneral();
        }
    }
}
