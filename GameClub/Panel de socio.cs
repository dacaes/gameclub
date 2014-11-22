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
    public partial class Panel_de_socio : Form
    {
        Tablon_de_socio tablonSocio;
        Tablon_de_admin tablonAdmin;
        Socio socio;
        bool ok = true;

        public Panel_de_socio()
        {
            InitializeComponent();
        }

        public Panel_de_socio(Socio socio, Tablon_de_socio tablonSocio)
        {
            InitializeComponent();
            this.socio = socio;
            this.tablonSocio = tablonSocio;
        }

        public Panel_de_socio(Socio socio, Tablon_de_admin tablonAdmin)
        {
            InitializeComponent();
            this.socio = socio;
            this.tablonAdmin = tablonAdmin;
        }

        private void Panel_de_socio_Load(object sender, EventArgs e)
        {
            //si eres admin
            if (Club.socioLogueado.esAdmin == true)
            {
                checkBoxAdmin.Enabled = true;
                //si el admin modifica a otro socio no hace falta que sepa su pass
                if( Club.socioLogueado != socio)
                    textBoxContraseñaActual.Enabled = false;
            }
            
            //si es una modificación se parte de los datos anteriores
            if (socio != null)
            {
            textBoxAlias.Text = socio.alias;
            textBoxNombre.Text = socio.nombre;
            textBoxApellidos.Text = socio.apellidos;
            textBoxMail.Text = socio.mail;
            textBoxTelefono.Text = socio.telefono;
            if (socio.esAdmin == true)
                checkBoxAdmin.Checked = true;
            }

            //si no es modificación habilito Alias y dehabilito contraseña actual.
            else
            {
                textBoxAlias.Enabled = true;
                textBoxContraseñaActual.Enabled = false;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Club.Instance.BajaSocio(socio);
            if (socio.esAdmin == true)
                tablonAdmin.Hide();
            else
                tablonSocio.Hide();
            this.Hide();
        }

        private void buttonAñadir_SocioAceptar_Click(object sender, EventArgs e)
        {
            Socio nuevoSocio = new Socio();

            nuevoSocio.alias = textBoxAlias.Text;
            nuevoSocio.nombre = textBoxNombre.Text;
            nuevoSocio.apellidos = textBoxApellidos.Text;
            nuevoSocio.mail = textBoxMail.Text;
            nuevoSocio.telefono = textBoxTelefono.Text;
            nuevoSocio.esAdmin = checkBoxAdmin.Checked;

            //MODIFICACIÓN socio
            if (socio != null)
            {
                //si no hay cambios vuelvo a visionar el mismo socio de antes sin pedir pass
                if (socio.alias == textBoxAlias.Text && socio.nombre == textBoxNombre.Text && socio.apellidos == textBoxApellidos.Text && socio.mail == textBoxMail.Text && socio.telefono == textBoxTelefono.Text && socio.esAdmin == checkBoxAdmin.Checked && ((textBoxNuevaContraseña.Text == String.Empty && textBoxConfirmarContraseña.Text == String.Empty) || (textBoxNuevaContraseña.Text == socio.contraseña && textBoxConfirmarContraseña.Text == socio.contraseña)))
                {
                    /*if (socio.esAdmin == true)
                    {
                        Tablon_de_admin tablonAdmin = new Tablon_de_admin(socio);
                        tablonAdmin.refresco(socio);
                        this.Hide();
                    }
                    else
                    {
                        Tablon_de_socio tablonSocio = new Tablon_de_socio(socio);
                        tablonSocio.refresco(socio);
                        this.Hide();

                    }*/
                    this.Hide();
                }

                //si hay cambios creo un nuevoSocio y borro antiguo
                else
                {
                    //verifico la identidad con la contraseña actual, di doy admin no hace falta

                    if (socio.contraseña == textBoxContraseñaActual.Text || Club.socioLogueado.esAdmin == true)
                    {

                        //si los campos de contraseña quedan vacios es que no hay cambios en ellos
                        if (textBoxNuevaContraseña.Text != String.Empty)
                            nuevoSocio.contraseña = textBoxNuevaContraseña.Text;
                        else
                            nuevoSocio.contraseña = socio.contraseña;

                        //eliminio socio
                        Club.Instance.BajaSocio(socio);

                        //creo nuevoSocio
                        Club.Instance.AltaSocio(nuevoSocio);

                        //si me modifico a mí
                        if (Club.socioLogueado == socio)
                            //cambio el estatus de sociologueado por si me he quitado la condición de admin
                            Club.socioLogueado = nuevoSocio;

                        if (nuevoSocio.esAdmin == true)
                        {
                            //Tablon_de_admin tablonAdminModificado = new Tablon_de_admin(Club.socioLogueado);
                            tablonAdmin.refresco(nuevoSocio);
                            this.Hide();
                        }

                        else
                        {
                            //Tablon_de_socio tablonSocioModificado = new Tablon_de_socio(Club.socioLogueado);
                            //tablonSocio.refresco(nuevoSocio);
                            Club.socioAux = nuevoSocio;
                            Club.Instance.refrescoGeneral();
                            this.Hide();
                        }

                    }
                }
            }

            //ALTA socio
            if (socio == null)
            {
                Socio socioAux = new Socio();
                socioAux.alias = nuevoSocio.alias;

                foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socioAux))
                {
                    ok = false;
                    break;
                }

                if (ok == true || textBoxAlias.Text != "Alias no disponible")
                {
                    //nueva contraseña y contraseña actual son iguales
                    if (textBoxNuevaContraseña.Text == textBoxConfirmarContraseña.Text && textBoxNuevaContraseña.Text != String.Empty)
                    {
                        nuevoSocio.contraseña = textBoxNuevaContraseña.Text;
                        Club.Instance.AltaSocio(nuevoSocio);
                        if (nuevoSocio.esAdmin == true)
                        {
                            tablonAdmin = new Tablon_de_admin(nuevoSocio);
                            tablonAdmin.Show();
                        }
                        else
                        {
                            tablonSocio = new Tablon_de_socio(nuevoSocio);
                            tablonSocio.Show();
                        }
                        this.Hide();
                    }
                }

                else
                    textBoxAlias.Text = "Alias no disponible";
            }
        }
    }
}
