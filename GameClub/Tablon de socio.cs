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
    public partial class Tablon_de_socio : Form
    {
        Socio socio;
        UnidadJuego unidad1 = new UnidadJuego();
        UnidadJuego unidad2 = new UnidadJuego();
        UnidadJuego unidad3 = new UnidadJuego();
        
        Dictionary<string, UnidadJuego> dunidad = new Dictionary<string, UnidadJuego>();
        Dictionary<string, TextBox> dtextbox = new Dictionary<string, TextBox>();
        Dictionary<string, DateTimePicker> ddatetimepicker = new Dictionary<string, DateTimePicker>();

        public Tablon_de_socio()
        {
            InitializeComponent();
        }

        public Tablon_de_socio(Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
        }

        private void Tablon_de_socio_Load(object sender, EventArgs e)
        {
            dunidad.Add("unidad1", unidad1);
            dunidad.Add("unidad2", unidad2);
            dunidad.Add("unidad3", unidad3);
            dtextbox.Add("textBoxJuego1", textBoxJuego1);
            dtextbox.Add("textBoxJuego2", textBoxJuego2);
            dtextbox.Add("textBoxJuego3", textBoxJuego3);
            ddatetimepicker.Add("dateTimePickerJuego1", dateTimePickerJuego1);
            ddatetimepicker.Add("dateTimePickerJuego2", dateTimePickerJuego2);
            ddatetimepicker.Add("dateTimePickerJuego3", dateTimePickerJuego3);

            this.refresco(socio);
        }

        public void refresco()
        {
            this.refresco(socio);
        }

        public void refresco(Socio socio)
        {
            this.comboBoxJuegosRecientes.Items.Clear();
            this.comboBoxJuegosRecientes.Text = String.Empty;
            this.comboBoxMisJuegos.Items.Clear();
            this.comboBoxMisJuegos.Text = String.Empty;
            this.textBoxJuego1.Clear();
            this.textBoxJuego2.Clear();
            this.textBoxJuego3.Clear();
            dateTimePickerJuego1.Value = DateTime.Today;
            dateTimePickerJuego2.Value = DateTime.Today;
            dateTimePickerJuego3.Value = DateTime.Today;

            dunidad["unidad1"].idJuego = -1;
            dunidad["unidad2"].idJuego = -1;
            dunidad["unidad3"].idJuego = -1;

            this.socio = socio;
            textBoxAlias.Text = socio.alias;
            textBoxNombre.Text = socio.nombre;
            textBoxApellidos.Text = socio.apellidos;
            textBoxMail.Text = socio.mail;
            textBoxTelefono.Text = socio.telefono;

            Prestamo prestamo = new Prestamo();
            prestamo.aliasSocio = socio.alias;
            prestamo.idUnidad = -1;
            prestamo.idPrestamo = -1;
            List<Prestamo> listaPrestamos = new List<Prestamo>();
            List<Prestamo> prestamosAntiguos = new List<Prestamo>();
            int totalPrestamosAntiguos = 0;
            foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
            {
                if (prestamo_buscado.activo == true)
                    listaPrestamos.Add(prestamo_buscado);
                else if (totalPrestamosAntiguos < 10)
                {
                    prestamosAntiguos.Add(prestamo_buscado);
                    totalPrestamosAntiguos++;
                }
            }

            for (int i = 0; i < prestamosAntiguos.Count; i++)
            {
                llenarPrestamosAntiguos(i,prestamosAntiguos);
            }
            

            //primer préstamo
            if (listaPrestamos.Count > 0)
                llenarPrestamos(0, listaPrestamos);

            //segundo préstamo
            if (listaPrestamos.Count > 1)
                llenarPrestamos(1, listaPrestamos);

            //tercer préstamo
            if (listaPrestamos.Count > 2)
                llenarPrestamos(2, listaPrestamos);

            llenarMisJuegos();
        }

        private void llenarPrestamosAntiguos(int index, List<Prestamo> prestamosAntiguos)
        {
            Juego juego = new Juego();
            UnidadJuego unidad = new UnidadJuego();
            unidad.aliasDueño = null;
            unidad.idJuego = -1;
            unidad.idUnidad = prestamosAntiguos[index].idUnidad;
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                juego.idFicha = unidad_buscada.idJuego;

                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    string cadena = juego_buscado.titulo + " " + juego_buscado.plataforma + " " + prestamosAntiguos[index].fechaDevolucion;
                    cadena = cadena.Remove(cadena.Length - 8);
                    this.comboBoxJuegosRecientes.Items.Add(cadena);
                }
            }

           
        }

        private void llenarMisJuegos()
        {
            Juego juego = new Juego();
            UnidadJuego unidad = new UnidadJuego();
            unidad.aliasDueño = socio.alias;
            unidad.idJuego = -1;
            unidad.idUnidad = -1;
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                juego.idFicha = unidad_buscada.idJuego;

                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    int index = comboBoxMisJuegos.FindString(juego_buscado.titulo + " " + juego_buscado.plataforma);
                    if (index == -1)
                        this.comboBoxMisJuegos.Items.Add(juego_buscado.titulo + " " + juego_buscado.plataforma);
                }
            }
        }

        private void llenarPrestamos(int index, List<Prestamo> listaPrestamos)
        {
            Juego juego = new Juego();
            dunidad["unidad" + Convert.ToString(index + 1)].idUnidad = listaPrestamos[index].idUnidad;
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(dunidad["unidad" + Convert.ToString(index + 1)]))
            {
                juego.idFicha = unidad_buscada.idJuego;
            }

            foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
            {
                dtextbox["textBoxJuego" + Convert.ToString(index + 1)].Text = juego_buscado.titulo + " " + juego_buscado.plataforma;
                dunidad["unidad" + Convert.ToString(index + 1)].idJuego = juego_buscado.idFicha;
            }

            ddatetimepicker["dateTimePickerJuego" + Convert.ToString(index + 1)].Value = listaPrestamos[index].fechaDevolucion;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxJuegosAlquilados_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Panel_de_socio panelSocio = new Panel_de_socio(socio, this);
            panelSocio.Show();
        }

        private void buttonBuscarJuegos_Click(object sender, EventArgs e)
        {
            Buscar_juego buscarJuego = new Buscar_juego();
            buscarJuego.Show();
        }

        private void mostrarFicha(int numBotonFicha)
        {
            Juego juego = new Juego();

            bool ok = false;

            if (numBotonFicha == 1 && unidad1.idJuego != -1)
            {
                juego.idFicha = unidad1.idJuego;
                ok = true;
            }
            if (numBotonFicha == 2 && unidad2.idJuego != -1)
            {
                juego.idFicha = unidad2.idJuego;
                ok = true;
            }
            if (numBotonFicha == 3 && unidad3.idJuego != -1)
            {
                juego.idFicha = unidad3.idJuego;
                ok = true;
            }

            if (ok)
            {
                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    Ficha_de_juego fichaJuego = new Ficha_de_juego(juego_buscado);
                    fichaJuego.Show();
                }
            }
        }

        private void buttonFicha1_Click(object sender, EventArgs e)
        {
            int ficha = 1;
            mostrarFicha(ficha);
        }

        private void buttonFicha2_Click(object sender, EventArgs e)
        {
            int ficha = 2;
            mostrarFicha(ficha);
        }

        private void buttonFicha3_Click(object sender, EventArgs e)
        {
            int ficha = 3;
            mostrarFicha(ficha);
        }

        private void buttonFichaReciente_Click(object sender, EventArgs e)
        {
            if (comboBoxJuegosRecientes.Text != String.Empty)
            {
                string aux = comboBoxJuegosRecientes.Text;
                aux = aux.Split(' ')[0];
                Juego juego = new Juego();
                juego.titulo = aux;

                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    Ficha_de_juego fichaJuego = new Ficha_de_juego(juego_buscado);
                    fichaJuego.Show();
                }
            }
        }

        private void buttonFichaMiJuego_Click(object sender, EventArgs e)
        {
            if (comboBoxMisJuegos.Text != String.Empty)
            {
                string aux = comboBoxMisJuegos.Text;
                aux = aux.Split(' ')[0];
                Juego juego = new Juego();
                juego.titulo = aux;

                foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                {
                    Ficha_de_juego fichaJuego = new Ficha_de_juego(juego_buscado);
                    fichaJuego.Show();
                }
            }
        }
    }
}
