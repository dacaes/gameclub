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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Club.timer();
        }

        /*private void Login_Load(object sender, EventArgs e)
        {
            foreach(Socio socio in Club.Instance.Login())
            {
                string aux = socio.alias + " " + socio.nombre + " " + socio.apellidos;
                listaSocios.Items.Add(aux);
            }
        }*/


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
           
            //Socio socio_buscado = new Socio();

            if (textBoxAlias.Text != String.Empty)
            {
                Socio socio = new Socio();

                socio.alias = textBoxAlias.Text;
               // socio.contraseña = textBoxContraseña.Text;
                bool encontrado = false;
                foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socio))
                {
                    encontrado = true;
                    if (textBoxContraseña.Text == socio_buscado.contraseña)
                    {
                        Club.socioLogueado = socio_buscado;
                        if (socio_buscado.esAdmin == true)
                        {
                            Tablon_de_admin tablonAdmin = new Tablon_de_admin(socio_buscado);
                            tablonAdmin.Show();
                            this.Hide();
                        }

                        else
                        {
                            Tablon_de_socio tablonSocio = new Tablon_de_socio(socio_buscado);
                            tablonSocio.Show();
                            this.Hide();
                        }
                    }

                    else
                    {
                        DialogResult error = MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (DialogResult.OK == error)
                        {
                            //así se selecciona solo lo que está mal
                            this.textBoxContraseña.Focus();
                            this.textBoxContraseña.SelectionStart = 0;
                            this.textBoxContraseña.SelectionLength = textBoxContraseña.Text.Length;
                        }
                    }
                }
                if (!encontrado)
                {
                    DialogResult error = MessageBox.Show("Socio no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (DialogResult.OK == error)
                    {
                        //así se selecciona solo lo que está mal
                        this.textBoxAlias.Focus();
                        this.textBoxAlias.SelectionStart = 0;
                        this.textBoxAlias.SelectionLength = textBoxAlias.Text.Length;
                    }
                }
            }

        }

        private void textBoxAlias_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Socio socio = new Socio();
                socio.alias = "nenperdut";
                socio.nombre = "Dani";
                socio.apellidos = "Castaño Estrella";
                socio.mail = "dani.kas.90@gmail.com";
                socio.telefono = "618069392";
                socio.esAdmin = true;
                socio.contraseña = "1";
                
                Club.Instance.AltaSocio(socio);
                //ListarSocios listarSocios = new ListarSocios();
                //listarSocios.Show();
                //this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            socio.alias = "x";
            socio.nombre = "Dani";
            socio.apellidos = "Muñoz Comas";
            socio.mail = "sins112";
            socio.telefono = "111888111";
            socio.esAdmin = false;
            socio.contraseña = "1";

            Club.Instance.AltaSocio(socio);
        }
    }
}
