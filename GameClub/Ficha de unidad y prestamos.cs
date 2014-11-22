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
    public partial class Ficha_de_unidad_y_prestamos : Form
    {
        DialogResult error;
        UnidadJuego unidad;
        Ficha_de_juego ficha;
        Juego juego;
        public Ficha_de_unidad_y_prestamos()
        {
            InitializeComponent();
            
        }

        public Ficha_de_unidad_y_prestamos(Juego juego, Ficha_de_juego ficha)
        {
            InitializeComponent();
            this.juego = juego;
            this.ficha = ficha;
        }

        private void groupBoxPrestamos_Enter(object sender, EventArgs e)
        {

        }

        public void Ficha_de_unidad_y_prestamos_Load(object sender, EventArgs e)
        {
            this.listBoxUnidadDisponible.MouseClick += new MouseEventHandler(listBoxUnidadDisponible_MouseClick); //hook
            this.listBoxUnidadNoDisponible.MouseClick += new MouseEventHandler(listBoxUnidadNoDisponible_MouseClick); //hook
            
            Socio socio = new Socio();
            foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socio))
            {
                comboBoxSocio.Items.Add(socio_buscado.alias);
            }

            this.refresco();
        }

        public void refresco(string unidadSeleccionada)
        {
            refresco();

            //if (listBoxUnidadDisponible
            int index = listBoxUnidadDisponible.FindString(unidadSeleccionada);
            // Determine if a valid index is returned. Select the item if it is valid.
            if (index != -1)
                listBoxUnidadDisponible.SetSelected(index, true);

            int index2 = listBoxUnidadNoDisponible.FindString(unidadSeleccionada);
            // Determine if a valid index is returned. Select the item if it is valid.
            if (index2 != -1 && index == -1)
                listBoxUnidadNoDisponible.SetSelected(index2, true);

        }

        public void refresco()
        {
            //listBoxUnidadDisponible.AllowDrop = true;
            //listBoxUnidadNoDisponible.AllowDrop = true;

            listBoxUnidadDisponible.Items.Clear();
            listBoxUnidadNoDisponible.Items.Clear();

            UnidadJuego unidad = new UnidadJuego();
            unidad.idUnidad = -1;
            unidad.idJuego = juego.idFicha;
            List<int> idUnidades = new List<int>();
            idUnidades.Add(-3);
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                
                Prestamo prestamo = new Prestamo();
                prestamo.idUnidad = unidad_buscada.idUnidad;
                prestamo.idPrestamo = -1;
                prestamo.aliasSocio = String.Empty;


                foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
                {
                    if (prestamo_buscado.activo == true)
                    {
                        listBoxUnidadNoDisponible.Items.Add(unidad_buscada.idUnidad + " " + unidad_buscada.aliasDueño + " " + prestamo_buscado.aliasSocio);
                        idUnidades.Add(prestamo_buscado.idUnidad);
                    }
                }
                if (idUnidades[idUnidades.Count - 1] != unidad_buscada.idUnidad )
                    listBoxUnidadDisponible.Items.Add(unidad_buscada.idUnidad + " " + unidad_buscada.aliasDueño);
            }
        }

        private void buttonNueva_Click(object sender, EventArgs e)
        {
            Panel_de_unidad panelUnidad = new Panel_de_unidad(juego, ficha, this);
            panelUnidad.Show();
            //this.Hide();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string aux = String.Empty;

            if (listBoxUnidadDisponible.SelectedIndex != -1)
                aux = listBoxUnidadDisponible.SelectedItem.ToString();

            if (listBoxUnidadNoDisponible.SelectedIndex != -1)
                aux = listBoxUnidadNoDisponible.SelectedItem.ToString();

            if (listBoxUnidadNoDisponible.SelectedIndex != -1)
            {
                string aux1 = listBoxUnidadNoDisponible.SelectedItem.ToString();
                string aux2 = aux1.Split(' ')[0];
                Prestamo prestamo = new Prestamo();
                prestamo.idUnidad = Convert.ToInt32(aux2);
                //prestamo.idPrestamo = -1;
                //prestamo.aliasSocio = String.Empty;
                //foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
                //{
                Club.Instance.BajaPrestamo(prestamo);
                //}
            }

            if (aux != String.Empty)
            {
                UnidadJuego unidad = new UnidadJuego();
                aux = aux.Split(' ')[0];
                unidad.idUnidad = Convert.ToInt32(aux);
                unidad.idJuego = -1;
                foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
                {
                    Club.Instance.BajaUnidadJuego(unidad_buscada);
                }
            }

            this.refresco();
            ficha.refresco(juego);
            Club.Instance.refrescoGeneral();
        }

        private void buttonPropietario_Click(object sender, EventArgs e)
        {
            Socio propietario = new Socio();

            string aux = String.Empty;

            if (listBoxUnidadDisponible.SelectedIndex != -1)
                aux = listBoxUnidadDisponible.SelectedItem.ToString();

            if (listBoxUnidadNoDisponible.SelectedIndex != -1)
                aux = listBoxUnidadNoDisponible.SelectedItem.ToString();

            if (aux != String.Empty)
            {
                UnidadJuego unidad = new UnidadJuego();
                aux = aux.Split(' ')[0];
                unidad.idUnidad = Convert.ToInt32(aux);
                foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
                {
                    propietario.alias = unidad_buscada.aliasDueño;
                }

                //propietario.alias = 
                foreach (Socio propietario_buscado in Club.Instance.BuscarSocio(propietario))
                {
                    if (propietario_buscado.esAdmin == true)
                    {
                        Tablon_de_admin tablonAdmin = new Tablon_de_admin(propietario_buscado);
                        tablonAdmin.Show();
                    }

                    else
                    {
                        Tablon_de_socio tablonSocio = new Tablon_de_socio(propietario_buscado);
                        tablonSocio.Show();
                    }
                }
            }
        }

        public void listBoxUnidadDisponible_MouseClick(object sender, MouseEventArgs e)
        {
            string curItem = null;
            if (listBoxUnidadDisponible.SelectedIndex != -1)
                curItem = listBoxUnidadDisponible.SelectedItem.ToString();

            int index = listBoxUnidadDisponible.FindString(curItem);
            if (index != -1)
                this.refresco(curItem);
        }

        private void listBoxUnidadNoDisponible_MouseClick(object sender, MouseEventArgs e)
        {
            string curItem = null;
            if (listBoxUnidadNoDisponible.SelectedIndex != -1)
            curItem = listBoxUnidadNoDisponible.SelectedItem.ToString();

            int index = listBoxUnidadNoDisponible.FindString(curItem);
            if (index != -1)
                this.refresco(curItem);
        }

        private void buttonPrestar_Click(object sender, EventArgs e)
        {
            //compruebo si selecciono alguna unidad
            if (listBoxUnidadDisponible.SelectedIndex != -1 && comboBoxSocio.SelectedIndex != -1)
            {
                string aux = listBoxUnidadDisponible.SelectedItem.ToString();
                
                //ahora hago el préstamo
                Prestamo nuevoPrestamo = new Prestamo();

                nuevoPrestamo.aliasSocio = comboBoxSocio.SelectedItem.ToString();

                //comprobar que el socio no tenga más de 3 juego alquilados
                
                //valores inválidos para el club (así la búsqueda solo mira aliasSocio)
                nuevoPrestamo.idUnidad = -1;
                nuevoPrestamo.idPrestamo = -1;

                int prestamos = 0;
                foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(nuevoPrestamo))
                {
                    if (prestamo_buscado.activo == true)
                        prestamos++;
                }
                //si el socio en cuestión tiene menos de 3 juegos alquilados PALANTE
                if (prestamos < 3)
                {
                    //cambio gráfico de pasar una unidad al listbox nodisponible
                    aux = aux.Split(' ')[0];
                    nuevoPrestamo.fechaPrestamo = dateTimePickerJuego1.Value.Date;
                    nuevoPrestamo.fechaDevolucion = dateTimePickerJuego2.Value.Date;
                    if (nuevoPrestamo.fechaDevolucion >= DateTime.Today)
                    {
                        nuevoPrestamo.idUnidad = Convert.ToInt32(aux);
                        nuevoPrestamo.activo = true;

                        Prestamo prestamoAux = new Prestamo();
                        //valores inválidos para el club
                        prestamoAux.idUnidad = -1;
                        prestamoAux.idPrestamo = -1;
                        prestamoAux.aliasSocio = String.Empty;
                        bool existe = true;
                        int id;
                        for (id = 0; existe == true; id++)
                        {
                            existe = false;
                            prestamoAux.idPrestamo = id;
                            foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamoAux))
                            {
                                existe = true;
                            }
                        }
                        nuevoPrestamo.idPrestamo = id - 1;
                        Club.Instance.AltaPrestamo(nuevoPrestamo);
                        this.refresco();
                    }
                    else
                    {
                        error = MessageBox.Show("Fecha de devolución incorrecta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        if (DialogResult.OK == error)
                        {
                            this.dateTimePickerJuego2.Focus();
                        }
                    }
                }
                else
                     error = MessageBox.Show("El usuario objetivo ya tiene alquilados tres juegos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            }

            Club.Instance.refrescoGeneral();
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            //compruebo si selecciono alguna unidad
            if (listBoxUnidadNoDisponible.SelectedIndex != -1)
            {
                string aux = listBoxUnidadNoDisponible.SelectedItem.ToString();
                string aux2 = aux.Split(' ')[0];
                Prestamo prestamo = new Prestamo();
                prestamo.idUnidad = Convert.ToInt32(aux2);
                //prestamo.idPrestamo = -1;
                //prestamo.aliasSocio = String.Empty;
                //foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
                //{
                    Club.Instance.BajaPrestamo(prestamo);
                //}
            }
            this.refresco();
            Club.Instance.refrescoGeneral();
        }

        private void listBoxUnidadDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
