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
    public partial class Panel_de_juego : Form
    {
        DialogResult error1;
        Ficha_de_juego fichaJuego;
        Juego juego;
        public Panel_de_juego()
        {
            InitializeComponent();
        }

        public Panel_de_juego(Juego juego, Ficha_de_juego fichaJuego)
        {
            InitializeComponent();
            this.juego = juego;
            this.fichaJuego = fichaJuego;
        }

        private void Añadir_socio_Load(object sender, EventArgs e)
        {
            //si es una MODIFICACIÓN
            if (juego != null)
            {
                //título
                textBoxTitulo.Text = juego.titulo;

                //plataformas
                if (juego.plataforma == "Xbox360")
                    radioButtonXbox360.Checked = true;

                if (juego.plataforma == "PS3")
                    radioButtonPS3.Checked = true;

                if (juego.plataforma == "Wii U")
                    radioButtonWiiU.Checked = true;

                if (juego.plataforma == "PC")
                    radioButtonPC.Checked = true;

                if (juego.plataforma == "Vita")
                    radioButtonVita.Checked = true;

                if (juego.plataforma == "3DS")
                    radioButton3DS.Checked = true;

                if (juego.plataforma == "Otra")
                    radioButtonOtra.Checked = true;

                if (juego.plataforma == "PSP")
                    radioButtonPSP.Checked = true;

                if (juego.plataforma == "DS")
                    radioButtonDS.Checked = true;

                //géneros
                if (juego.genero.Contains("Acción"))
                    checkBoxAccion.Checked = true;

                if (juego.genero.Contains("Aventura"))
                    checkBoxAventura.Checked = true;

                if (juego.genero.Contains("Conducción"))
                    checkBoxConduccion.Checked = true;

                if (juego.genero.Contains("Deportes"))
                    checkBoxDeportes.Checked = true;

                if (juego.genero.Contains("Estrategia"))
                    checkBoxEstrategia.Checked = true;

                if (juego.genero.Contains("Plataforma"))
                    checkBoxPlataforma.Checked = true;

                if (juego.genero.Contains("Arcade"))
                    checkBoxArcade.Checked = true;

                if (juego.genero.Contains("Simulación"))
                    checkBoxSimulacion.Checked = true;

                if (juego.genero.Contains("Lucha"))
                    checkBoxLucha.Checked = true;

                if (juego.genero.Contains("Rol"))
                    checkBoxRol.Checked = true;

                if (juego.genero.Contains("MMO"))
                    checkBoxMMO.Checked = true;

                if (juego.genero.Contains("Puzzle"))
                    checkBoxPuzzle.Checked = true;

                if (juego.genero.Contains("Casual"))
                    checkBoxCasual.Checked = true;

                if (juego.genero.Contains("Educativo"))
                    checkBoxEducativo.Checked = true;

                if (juego.genero.Contains("Otro"))
                    checkBoxOtro.Checked = true;

                //PEGI
                if (juego.PEGI == 3)
                    radioButtonPEGI3.Checked = true;

                if (juego.PEGI == 7)
                    radioButtonPEGI7.Checked = true;

                if (juego.PEGI == 12)
                    radioButtonPEGI12.Checked = true;

                if (juego.PEGI == 16)
                    radioButtonPEGI16.Checked = true;

                if (juego.PEGI == 18)
                    radioButtonPEGI18.Checked = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPlataforma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxEstrategia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDeportes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelPropietario_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool apto = true;
            Juego nuevoJuego = new Juego();

            //título
            if (textBoxTitulo.Text != String.Empty)
                nuevoJuego.titulo = textBoxTitulo.Text;
            else
                ok = false;
            if (ok)
            {
                //plataformas
                if (radioButtonXbox360.Checked)
                    nuevoJuego.plataforma = "Xbox360";

                else if (radioButtonPS3.Checked)
                    nuevoJuego.plataforma = "PS3";

                else if (radioButtonWiiU.Checked)
                    nuevoJuego.plataforma = "Wii U";

                else if (radioButtonPC.Checked)
                    nuevoJuego.plataforma = "PC";

                else if (radioButtonVita.Checked)
                    nuevoJuego.plataforma = "Vita";

                else if (radioButton3DS.Checked)
                    nuevoJuego.plataforma = "3DS";

                else if (radioButtonOtra.Checked)
                    nuevoJuego.plataforma = "Otra";

                else if (radioButtonPSP.Checked)
                    nuevoJuego.plataforma = "PSP";

                else if (radioButtonDS.Checked)
                    nuevoJuego.plataforma = "DS";
                else
                    ok = false;
            }

            if (ok)
            {
                ok = false;
                //géneros
                List<string> aux = new List<string>();
                foreach (CheckBox box in groupBoxGenero.Controls)
                {
                    if (box.Checked)
                    {
                        ok = true;
                        aux.Add(box.Text);
                    }
                }
                if (ok)
                {
                    foreach (string cad in aux)
                    {
                        nuevoJuego.genero += cad + " ";
                    }
                    nuevoJuego.genero = nuevoJuego.genero.Remove(nuevoJuego.genero.Length - 1);
                }
            }
            if (ok)
            {
                //PEGI
                if (radioButtonPEGI3.Checked)
                    nuevoJuego.PEGI = 3;

                else if (radioButtonPEGI7.Checked)
                    nuevoJuego.PEGI = 7;

                else if (radioButtonPEGI12.Checked)
                    nuevoJuego.PEGI = 12;

                else if (radioButtonPEGI16.Checked)
                    nuevoJuego.PEGI = 16;

                else if (radioButtonPEGI18.Checked)
                    nuevoJuego.PEGI = 18;
                else
                    ok = false;
            }

            if (ok)
            {
                //MODIFICACIÓN juego
                if (juego != null)
                {
                    //que no haya info vacía
                    if (juego.titulo != String.Empty)
                    {
                        //asigno id del viejo al nuevo
                        nuevoJuego.idFicha = juego.idFicha;
                        //eliminio juego
                        Club.Instance.BajaJuego(juego);
                    }
                }

                else
                {
                    //estamos creando un juego nuevo y no queremos equivocarnos, aquí vemos si ya existe
                    foreach (Juego juego_buscado in Club.Instance.BuscarJuego(nuevoJuego))
                    {
                        //textBoxTitulo.Text += " --Este juego ya existe.";
                        DialogResult error = MessageBox.Show("Existe una ficha de juego con el mismo título.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (DialogResult.OK == error)
                        {
                            //así se selecciona solo lo que está mal
                            this.textBoxTitulo.Focus();
                            this.textBoxTitulo.SelectionStart = 0;
                            this.textBoxTitulo.SelectionLength = textBoxTitulo.Text.Length;
                        }
                        apto = false;
                    }

                    /*
                    if (textBoxTitulo.Text.Contains(" --Este juego ya existe."))
                    {
                        apto = false;
                    }
                    */

                    //encontrar idFicha vacía
                    Juego juegoAux = new Juego();
                    bool existe = true;
                    int id;
                    for (id = 0; existe == true; id++)
                    {
                        existe = false;
                        juegoAux.idFicha = id;
                        foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juegoAux))
                        {
                            existe = true;
                        }
                    }
                    nuevoJuego.idFicha = id - 1;
                }
                //crear ficha nuevoJuego
                if (apto)
                {
                    Club.Instance.AltaJuego(nuevoJuego);
                    if (juego != null)
                        fichaJuego.refresco(nuevoJuego);
                    else
                    {
                        fichaJuego = new Ficha_de_juego(nuevoJuego);
                        fichaJuego.Show();
                    }
                    this.Hide();
                }
                Club.Instance.refrescoGeneral();
            }
            else
                error1 = MessageBox.Show("Se deben cumplimentar todos los campos de la ficha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxPEGI_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Club.Instance.BajaJuego(juego);
            Club.Instance.refrescoGeneral();
            fichaJuego.Hide();
            this.Hide();
        }
    }
}
