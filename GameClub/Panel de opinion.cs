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
    public partial class Panel_de_opinión : Form
    {
        Juego juego;
        Opinion opinion;
        public Panel_de_opinión()
        {
            InitializeComponent();
        }

        public Panel_de_opinión(Juego juego)
        {
            InitializeComponent();
            this.juego = juego;
        }

        public Panel_de_opinión(Juego juego, Opinion opinion)
        {
            InitializeComponent();
            this.juego = juego;
            this.opinion = opinion;
        }


        private void Panel_de_opinión_Load(object sender, EventArgs e)
        {
            this.refresco();
        }

        public void refresco()
        {
            textBoxTitulo.Text = this.juego.titulo;
            if (opinion != null)
            {
                textBoxNota.Text = Convert.ToString(opinion.nota);
                textBoxOpinion.Text = opinion.comentario;
            }
        }

        private void buttonOpinionAceptar_Click(object sender, EventArgs e)
        {
            DialogResult error;
            bool ok = true;
            bool apto = true;
            int idAntiguaOpinion = -1;
            Opinion nuevaOpinion = new Opinion();
            nuevaOpinion.idJuego = juego.idFicha;
            nuevaOpinion.alias_autor = Club.socioLogueado.alias;
            if (textBoxOpinion.Text.Length > 800)
            {
                error = MessageBox.Show("La opinión no puede exceder los 800 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBoxOpinion.Focus();
                //no selecciono para que la gente no borre todo por accidente
                ok = false;
            }
            else
                nuevaOpinion.comentario = textBoxOpinion.Text;
            int aux;
            bool puedoConvertir = int.TryParse(textBoxNota.Text, out aux);
            if (puedoConvertir && aux < 11 && aux > -1)
                nuevaOpinion.nota = aux;
            else
            {
                error = MessageBox.Show("La nota ha de ser un número entero del 0 al 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBoxNota.Focus();
                this.textBoxNota.SelectionStart = 0;
                this.textBoxNota.SelectionLength = textBoxNota.Text.Length;
                ok = false;
            }
            if (ok)
            {
                //MODIFICACIÓN opinión
                if (opinion != null)
                {
                    //que no haya info vacía
                    if (opinion.comentario != String.Empty && opinion.nota > -1 && opinion.nota < 11)
                    {
                        //asigno id de la vieja al nuevo
                        nuevaOpinion.idOpinion = opinion.idOpinion;
                        //elimino juego
                        Club.Instance.BajaOpinion(opinion);
                    }
                }

                else
                {
                    nuevaOpinion.idOpinion = -1;
                    //estamos creando una opinión nueva y no queremos equivocarnos, aquí vemos si ya existe
                    foreach (Opinion opinion_buscada in Club.Instance.BuscarOpinion(nuevaOpinion))
                    {
                        error = MessageBox.Show("Ya ha escrito una opinión, si acepta se sobreescribirá.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (DialogResult.OK == error)
                        {
                            apto = true;
                            idAntiguaOpinion = opinion_buscada.idOpinion;
                            Club.Instance.BajaOpinion(opinion_buscada);
                        }
                        else
                        {
                            apto = false;
                            this.textBoxOpinion.Focus();
                        }
                    }
                }

                //crear ficha nuevaOpinion
                if (apto)
                {
                    if (idAntiguaOpinion != -1)
                        nuevaOpinion.idOpinion = idAntiguaOpinion;

                    else
                    {
                        //encontrar idOpinion vacía
                        Opinion opinionAux = new Opinion();
                        bool existe = true;
                        int id;
                        for (id = 0; existe == true; id++)
                        {
                            existe = false;
                            opinionAux.idJuego = -1;
                            opinionAux.idOpinion = id;
                            foreach (Opinion opinion_buscada in Club.Instance.BuscarOpinion(opinionAux))
                            {
                                existe = true;
                            }
                        }
                        nuevaOpinion.idOpinion = id - 1;
                    }

                    Club.Instance.AltaOpinion(nuevaOpinion);
                    Club.Instance.refrescoGeneral();
                    this.Hide();
                }
            }
        }
    }
}
