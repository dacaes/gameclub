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
    public partial class Buscar_juego : Form
    {
        public Buscar_juego()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            Juego juego = new Juego();

            if (textBoxTitulo.Text != String.Empty)
                juego.titulo = textBoxTitulo.Text;

            //Plataforma
            if (comboBoxPlataforma.Text != String.Empty)
                juego.plataforma = comboBoxPlataforma.Text;

            //Genero
            if (comboBoxGenero.Text != String.Empty)
                juego.genero = comboBoxGenero.Text;

            //PEGI
            if (comboBoxPEGI.Text != String.Empty)
                juego.PEGI = Convert.ToInt16(comboBoxPEGI.Text);

            if (textBoxTitulo.Text != String.Empty || comboBoxPlataforma.Text != String.Empty || comboBoxGenero.Text != String.Empty || comboBoxPEGI.Text != String.Empty)
            {
                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    //if (socio_buscado != null)
                    //{
                    string aux = juego_buscado.idFicha + " - " + juego_buscado.titulo + " - " + juego_buscado.plataforma + " - " + juego_buscado.genero + " - PEGI " + juego_buscado.PEGI;
                    listBoxResultados.Items.Add(aux);
                    /*}

                    else
                    {
                        listBoxResultados.Items.Add("Error");
                    }*/
                }
                if (listBoxResultados.Items.Count < 1)
                    listBoxResultados.Items.Add("No se encuentran resultados.");
            }
            else
                listBoxResultados.Items.Add("No se encuentran resultados.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedIndex != -1)
            {
                string aux = String.Empty;
                aux = listBoxResultados.SelectedItem.ToString();
                Juego juego = new Juego();
                aux = aux.Split(' ')[0];
                juego.idFicha = Convert.ToInt32(aux);
                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    Ficha_de_juego fichaJuego = new Ficha_de_juego(juego_buscado);
                    fichaJuego.Show();
                    this.Hide();
                }
            }
        }

        private void Buscar_juego_Load(object sender, EventArgs e)
        {
            this.listBoxResultados.DoubleClick += new System.EventHandler(listBoxResultados_DoubleClick); //hook
        }

        public void listBoxResultados_DoubleClick(object sender, System.EventArgs e)
        {
            buttonAcceder_Click(sender,e);
        }
    }
}
