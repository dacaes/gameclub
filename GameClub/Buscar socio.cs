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
    public partial class Buscar_socio : Form
    {
        public Buscar_socio()
        {
            InitializeComponent();
        }

        /*private void Buscar_socio_Load(object sender, EventArgs e)
        {
            foreach (Socio socio in Club.Instance.BuscarSocio(socio))
            {
                string aux = socio.alias + " " + socio.nombre + " " + socio.apellidos;
                listBoxResultados.Items.Add(aux);
            }
        }*/

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            Socio socio = new Socio();

            if (textBoxAlias.Text != String.Empty)
                socio.alias = textBoxAlias.Text;
            if (textBoxNombre.Text != String.Empty)
                socio.nombre = textBoxNombre.Text;
            if (textBoxApellidos.Text != String.Empty)
                socio.apellidos = textBoxApellidos.Text;
            if (textBoxMail.Text != String.Empty)
                socio.mail = textBoxMail.Text;
            if (textBoxTelefono.Text != String.Empty)
                socio.telefono = textBoxTelefono.Text;

            if (textBoxAlias.Text != String.Empty || textBoxNombre.Text != String.Empty || textBoxApellidos.Text != String.Empty || textBoxMail.Text != String.Empty || textBoxTelefono.Text != String.Empty)
            {
                foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socio))
                {
                    //if (socio_buscado != null)
                    //{
                        string aux = socio_buscado.alias + " " + socio_buscado.mail;
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

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedIndex != -1)
            {
                string aux = String.Empty;
                aux = listBoxResultados.SelectedItem.ToString();
                Socio socio = new Socio();
                aux = aux.Split(' ')[0];
                socio.alias = aux;
                foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socio))
                {
                    if (socio_buscado != null)
                    {
                        if (socio_buscado.esAdmin == true)
                        {
                            Tablon_de_admin tablonAdminBuscado = new Tablon_de_admin(socio_buscado);
                            tablonAdminBuscado.Show();
                            this.Hide();
                        }

                        else
                        {
                            Tablon_de_socio tablonSocioBuscado = new Tablon_de_socio(socio_buscado);
                            tablonSocioBuscado.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            socio.alias = "3";
            socio.nombre = "Dani";
            socio.apellidos = "Chumilla Liccioli";
            socio.mail = "davidchumilla";
            socio.telefono = "111666111";
            socio.esAdmin = false;
            socio.contraseña = "1";

            Club.Instance.AltaSocio(socio);
        }

        private void listBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_socio_Load(object sender, EventArgs e)
        {
            this.listBoxResultados.DoubleClick += new System.EventHandler(listBoxResultados_DoubleClick); //hook
        }

        public void listBoxResultados_DoubleClick(object sender, System.EventArgs e)
        {
            buttonAcceder_Click(sender, e);
        }
    }
}
