using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;


namespace GameClub
{
    public partial class Ficha_de_juego : Form
    {
        DialogResult error;
        public Juego juego;
        public Ficha_de_juego()
        {
            InitializeComponent();
        }

        public Ficha_de_juego(Juego juego)
        {
            InitializeComponent();
            this.juego = juego;
        }

        private void Ficha_de_juego_Load(object sender, EventArgs e)
        {
            textBoxOpiniones.ReadOnly = true;
            textBoxOpiniones.BackColor = Color.White;
            this.comboBoxAlias.SelectedIndexChanged += new System.EventHandler(comboBoxAlias_SelectedIndexChanged); //hook
            this.refresco(juego);
        }

        public void refresco(Juego juego)
        {
            this.comboBoxAlias.Items.Clear();

            this.juego = juego;
            textBoxTitulo.Text = juego.titulo;
            textBoxPlataforma.Text = juego.plataforma;
            textBoxGenero.Text = juego.genero;
            textBoxPEGI.Text = Convert.ToString(juego.PEGI);
            UnidadJuego unidad = new UnidadJuego();
            unidad.idUnidad = -1;
            unidad.idJuego = juego.idFicha;
            bool disponible = false;
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                Prestamo prestamo = new Prestamo();
                prestamo.idPrestamo = -1;
                prestamo.aliasSocio = String.Empty;
                prestamo.idUnidad = unidad_buscada.idUnidad;
                foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
                {
                    if (prestamo_buscado.activo == false)
                        disponible = true;
                }
            }
            if (disponible)
                checkBoxDisponible.Checked = true;
            else
                checkBoxDisponible.Checked = false;

            if (Club.socioLogueado.esAdmin == false)
            {
                buttonUnidades.Enabled = false;
                buttonModificar.Enabled = false;
            }

            llenarOpiniones();
            notaMedia();
            recargarOpinion();
        }

        private void notaMedia()
        {
            int media = 0;
            int opiniones = 0;
            Opinion opinion = new Opinion();
            opinion.idOpinion = -1;
            opinion.idJuego = juego.idFicha;
            foreach (Opinion opinion_buscada in Club.Instance.BuscarOpinion(opinion))
            {
                media += opinion_buscada.nota;
                opiniones++;
            }
            if (opiniones != 0)
                textBoxMedia.Text = Convert.ToString(media / opiniones);
            else
                textBoxMedia.Text = "NA";
        }

        private void llenarOpiniones()
        {
            Opinion opinion = new Opinion();
            opinion.idOpinion = -1;
            opinion.idJuego = juego.idFicha;
            foreach (Opinion opinion_buscada in Club.Instance.BuscarOpinion(opinion))
                 this.comboBoxAlias.Items.Add(opinion_buscada.alias_autor);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNotaMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDisponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPlataforma_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Panel_de_juego panelJuego = new Panel_de_juego(juego, this);
            panelJuego.Show();
        }

        private void textBoxGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnidades_Click(object sender, EventArgs e)
        {
            Ficha_de_unidad_y_prestamos fichaUnidadPrestamos = new Ficha_de_unidad_y_prestamos(juego, this);
            fichaUnidadPrestamos.Show();
        }

        private void buttonEscribirOpinión_Click(object sender, EventArgs e)
        {
            bool hayUd = false;
            bool prestado = false;
            bool posesion = false;
            //solo opina si tiene el juego o lo ha jugado
            UnidadJuego unidad = new UnidadJuego();
            unidad.aliasDueño = null;
            unidad.idJuego = this.juego.idFicha;
            unidad.idUnidad = -1;
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                hayUd = true;
                Prestamo prestamo = new Prestamo();
                prestamo.idUnidad = unidad_buscada.idUnidad;
                prestamo.idPrestamo = -1;
                prestamo.aliasSocio = String.Empty;

                foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
                {
                    if (prestamo_buscado.aliasSocio == Club.socioLogueado.alias)
                    {
                        prestado = true;
                        Panel_de_opinión panelOpinion = new Panel_de_opinión(this.juego);
                        panelOpinion.Show();
                    }
                }
                if (unidad_buscada.aliasDueño == Club.socioLogueado.alias && !prestado)
                {
                    posesion = true;
                    Panel_de_opinión panelOpinion = new Panel_de_opinión(this.juego);
                    panelOpinion.Show();
                }
            }
            if (!hayUd)
            {
                error = MessageBox.Show("No hay unidades de este juego y por tanto no puede opinar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!posesion && !prestado)
            {
                error = MessageBox.Show("Usted no tiene este juego y tampoco lo ha alquilado jamás. Alquilelo para poder opinar sobre él.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void comboBoxAlias_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            recargarOpinion();
        }

        private void recargarOpinion()
        {
            Opinion opinion = new Opinion();
            opinion.idOpinion = -1;
            opinion.alias_autor = comboBoxAlias.Text;
            opinion.idJuego = juego.idFicha;
            foreach (Opinion opinion_buscada in Club.Instance.BuscarOpinion(opinion))
            {
                textBoxOpiniones.Text = opinion_buscada.comentario;
                textBoxNota.Text = Convert.ToString(opinion_buscada.nota);
            }
            if (comboBoxAlias.Text != Club.socioLogueado.alias)
                buttonModificarOpinion.Enabled = false;
            else
                buttonModificarOpinion.Enabled = true;
        }

        private void buttonModificarOpinion_Click(object sender, EventArgs e)
        {
            Opinion opinion = new Opinion();
            opinion.idOpinion = -1;
            opinion.alias_autor = comboBoxAlias.Text;
            opinion.idJuego = juego.idFicha;
            foreach (Opinion opinion_buscada in Club.Instance.BuscarOpinion(opinion))
            {
                Panel_de_opinión panelOpinion = new Panel_de_opinión(juego,opinion_buscada);
                panelOpinion.Show();
            }

                
        }
    }
}
