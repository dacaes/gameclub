using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GameClub
{
    public partial class Tablon_de_admin : Form
    {
        public Socio socio;
        UnidadJuego unidad1 = new UnidadJuego();
        UnidadJuego unidad2 = new UnidadJuego();
        UnidadJuego unidad3 = new UnidadJuego();

        Dictionary<string, UnidadJuego> dunidad = new Dictionary<string, UnidadJuego>();
        Dictionary<string, TextBox> dtextbox = new Dictionary<string, TextBox>();
        Dictionary<string, DateTimePicker> ddatetimepicker = new Dictionary<string, DateTimePicker>();

        public Tablon_de_admin()
        {
            InitializeComponent();
        }

        public Tablon_de_admin(Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
        }

        private void Tablon_de_admin_Load(object sender, EventArgs e)
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
                llenarPrestamosAntiguos(i, prestamosAntiguos);
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

        private void buttonAñadirUnidadJuego_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarSocios_Click_1(object sender, EventArgs e)
        {
            Buscar_socio buscarSocio = new Buscar_socio();
            buscarSocio.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Panel_de_socio panelSocio = new Panel_de_socio(socio, this);
            panelSocio.Show();
        }

        private void buttonAñadirSocio_Click(object sender, EventArgs e)
        {
            Panel_de_socio panelSocio = new Panel_de_socio();
            panelSocio.Show();
        }

        private void buttonAñadirFichaJuego_Click(object sender, EventArgs e)
        {
            Panel_de_juego panelJuego = new Panel_de_juego();
            panelJuego.Show();
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

        private void buttonFicha1_Click_1(object sender, EventArgs e)
        {
            int ficha = 1;
            mostrarFicha(ficha);
        }

        private void buttonFicha2_Click_1(object sender, EventArgs e)
        {
            int ficha = 2;
            mostrarFicha(ficha);
        }

        private void buttonFicha3_Click_1(object sender, EventArgs e)
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

        private void buttonBoletin_Click(object sender, EventArgs e)
        {
            Socio socio = null;
            MailMessage mail = null;
            mail = new MailMessage();
            //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
            mail.From = new MailAddress("gameclubdani@gmail.com", "GameClub", Encoding.UTF8);
            //Aquí ponemos el asunto del correo
            mail.Subject = "Juegos nuevos de este mes";
            //Aquí ponemos el mensaje que incluirá el correo
            mail.Body = "Os hacemos llegar los nuevos juegos de este mes:\n";
            //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor

            UnidadJuego unidad = new UnidadJuego();
            unidad.fechaAlta = DateTime.Now;
            unidad.idJuego = -1;
            unidad.idUnidad = -1;
 
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                Juego juego = new Juego();
                juego.idFicha = unidad_buscada.idJuego;
                juego.PEGI = 0;
 
                    foreach (Juego juego_buscado in Club.Instance.BuscarJuego(juego))
                    {
                        if (!mail.Body.Contains(juego_buscado.titulo + " " + juego_buscado.plataforma))
                            mail.Body += juego_buscado.titulo + " " + juego_buscado.plataforma + "\n";
                    }

            }
            
            foreach(Socio socio_buscado in Club.Instance.BuscarSocio(socio))
            {
                mail.To.Add(socio_buscado.mail);   
            }
            Club.Instance.SendMail(mail);
            DialogResult ok = MessageBox.Show("Boletín emitido.", "Boletín", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonRecordatorio_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            MailMessage mail = null;
            mail = new MailMessage();
            //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
            mail.From = new MailAddress("gameclubdani@gmail.com", "GameClub", Encoding.UTF8);
            //Aquí ponemos el asunto del correo
            mail.Subject = "Préstamos";
            //Aquí ponemos el mensaje que incluirá el correo
            mail.Body = "Le recordamos que tiene préstamos pendientes por devolver.";
            //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor

            Prestamo prestamo = new Prestamo();
            prestamo.idPrestamo = -1;
            prestamo.idUnidad = -1;
            prestamo.aliasSocio = String.Empty;

            foreach (Prestamo prestamo_buscado in Club.Instance.BuscarPrestamo(prestamo))
            {
                if (DateTime.Today > prestamo_buscado.fechaDevolucion)
                {
                    socio.alias = prestamo_buscado.aliasSocio;
                    foreach (Socio socio_buscado in Club.Instance.BuscarSocio(socio))
                    {
                        MailAddress adress = new MailAddress(socio_buscado.mail);
                        if(!mail.To.Contains(adress))
                            mail.To.Add(socio_buscado.mail);
                    }
 
                }
            }
            Club.Instance.SendMail(mail);
            DialogResult ok = MessageBox.Show("Recordatorio emitido.", "Recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
