using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Timers;
using System.Windows.Forms;

using System.Diagnostics;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Threading;




namespace GameClub
{
    class Club
    {
        
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        public static Socio socioLogueado = new Socio();
        public static Socio socioAux = new Socio();

        static Club instance = null;
        public static Club Instance
        {
            get
            {
                if (instance == null)
                    instance = new Club();
                return instance;
            }
        }

        Dictionary<string,Socio> listaSocios;
        SqlConnection con;

        private Club()
        {
            listaSocios = new Dictionary<string, Socio>();
            string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\GameClub_BDD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con = new SqlConnection(cadenaConexion);

        }

        // This is the method to run when the timer is raised.
        public static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();

            // Displays a message box asking whether to continue running the timer.
            if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Restarts the timer and increments the counter.
                alarmCounter += 1;
                myTimer.Enabled = true;
            }
            else
            {
                // Stops the timer.
                exitFlag = true;
            }
        }

        public static int timer()
        {
            /* Adds the event and the event handler for the method that will 
               process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 5000;
            myTimer.Start();

            // Runs the timer, and raises the event.
            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }
            return 0;
        }

        public void refrescoGeneral()
        {
            List<Form> formTablon_de_socio = new List<Form>();
            List<Form> formTablon_de_admin = new List<Form>();
            List<Form> formFicha_de_juego = new List<Form>();

            foreach (Form form_buscado in Application.OpenForms)
            {
                 if (form_buscado.Name == "Tablon_de_socio")
                     formTablon_de_socio.Add(form_buscado);
                 if (form_buscado.Name == "Tablon_de_admin")
                     formTablon_de_admin.Add(form_buscado);
                 if (form_buscado.Name == "Ficha_de_juego")
                     formFicha_de_juego.Add(form_buscado);
            }
            foreach (Tablon_de_socio form in formTablon_de_socio)
            {
                if (socioAux != null)
                {
                    if (socioAux.alias != null)
                        form.refresco(socioAux);
                    else
                        form.refresco();
                }
                else
                    form.refresco();
            }

            foreach (Tablon_de_admin form in formTablon_de_admin)
            {
                    form.refresco();
            }

            foreach (Ficha_de_juego form in formFicha_de_juego)
            {
                    form.refresco(form.juego);
            }

            socioAux = null;
        }

        public Boolean SendMail(MailMessage mail_entrada)
        {
            try
            {
                //Configuración del Mensaje
                MailMessage mail = mail_entrada;
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
              
                //Configuracion del SMTP
                SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential("gameclubdani@gmail.com", "macarena1");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void AltaUnidadJuego(UnidadJuego miUnidad)
        {
            DateTime thisDay = DateTime.Today;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Tabla_UnidadJuego(idUnidad,idJuego,aliasDueño,fechaAlta) values (@idUnidad,@idJuego,@aliasDueño,@fechaAlta)";

            cmd.Parameters.Add("@idUnidad", SqlDbType.Int).Value = miUnidad.idUnidad;
            cmd.Parameters.Add("@idJuego", SqlDbType.Int).Value = miUnidad.idJuego;
            cmd.Parameters.Add("@aliasDueño", SqlDbType.NVarChar, 50).Value = miUnidad.aliasDueño;
            cmd.Parameters.Add("@fechaAlta", SqlDbType.DateTime).Value = thisDay;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                con.Close();
            }
        }

        public void BajaUnidadJuego(UnidadJuego miUnidad)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM Tabla_UnidadJuego WHERE idUnidad=@idUnidad";
            cmd.Parameters.Add("@idUnidad", SqlDbType.Int).Value = miUnidad.idUnidad;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        public List<UnidadJuego> BuscarUnidadJuego(UnidadJuego miUnidad)
        {
            List<UnidadJuego> aux = new List<UnidadJuego>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

             string cadena = "SELECT * FROM Tabla_UnidadJuego WHERE ";

             if (miUnidad.idUnidad != -1)
             {
                 cmd.Parameters.Add("@idUnidad", SqlDbType.Int).Value = miUnidad.idUnidad;
                 cadena += "idUnidad=@idUnidad AND ";
             }

             if (miUnidad.idJuego != -1)
             {
                 cmd.Parameters.Add("@idJuego", SqlDbType.Int).Value = miUnidad.idJuego;
                 cadena += "idJuego=@idJuego AND ";
             }

             if (miUnidad.aliasDueño != null)
             {
                 cmd.Parameters.Add("@aliasDueño", SqlDbType.NVarChar, 50).Value = miUnidad.aliasDueño;
                 cadena += "aliasDueño=@aliasDueño AND ";
             }
            
             String MyString;
             MyString = "01/01/0001 0:00:00";
             

             DateTime MyDateTime;
             MyDateTime = new DateTime();
             MyDateTime = DateTime.ParseExact(MyString, "dd/MM/yyyy H:mm:ss", null);

            string smonth;
            int month = miUnidad.fechaAlta.Month;
            //string smonth= miUnidad.fechaAlta.Month.ToString();
            smonth = Convert.ToString(month);
            if (month < 10)
                smonth = "0" + smonth;
            string syear = miUnidad.fechaAlta.Year.ToString();

             if (miUnidad.fechaAlta != MyDateTime)
             {
                 cmd.Parameters.Add("@fechaAlta", SqlDbType.DateTime).Value = miUnidad.fechaAlta;
                 cadena += "'01/" + smonth + "/" + syear + " 00:00:00'<=@fechaAlta AND ";
             }
             if (miUnidad.idUnidad != -1 || miUnidad.idJuego != -1 || miUnidad.aliasDueño != null ||miUnidad.fechaAlta!= MyDateTime)
                 cadena = cadena.Remove(cadena.Length - 5);

            cmd.CommandText = cadena;

            UnidadJuego unidad = null;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    unidad = new UnidadJuego();
                    unidad.idUnidad = (int)reader["idUnidad"];
                    unidad.idJuego = (int)reader["idJuego"];
                    unidad.aliasDueño = reader["aliasDueño"].ToString();
                    unidad.fechaAlta = Convert.ToDateTime(reader["fechaAlta"]);
                    aux.Add(unidad);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
            return aux;
        }

        public void AltaSocio(Socio miSocio)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Tabla_Socio(alias,nombre,apellidos,mail,telefono,esAdmin,contraseña) values (@alias,@nombre,@apellidos,@mail,@telefono,@esAdmin,@contraseña)";

            cmd.Parameters.Add("@alias",SqlDbType.NVarChar,50).Value = miSocio.alias;
            cmd.Parameters.Add("@nombre",SqlDbType.NVarChar,50).Value = miSocio.nombre;
            cmd.Parameters.Add("@apellidos",SqlDbType.NVarChar,50).Value = miSocio.apellidos;
            cmd.Parameters.Add("@mail",SqlDbType.NVarChar,50).Value = miSocio.mail;
            cmd.Parameters.Add("@telefono",SqlDbType.NChar,10).Value = miSocio.telefono;
            cmd.Parameters.Add("@esAdmin",SqlDbType.Bit).Value = miSocio.esAdmin;
            cmd.Parameters.Add("@contraseña",SqlDbType.NVarChar,50).Value = miSocio.contraseña;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch(Exception e)
            {
                con.Close();
            }
        }


        public void ModificacionSocio(Socio antiguoSocio, Socio nuevoSocio)
        {
            BajaSocio(antiguoSocio);
            AltaSocio(nuevoSocio);
        }

        public void BajaSocio(Socio miSocio)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM Tabla_Socio WHERE alias=@alias";
            cmd.Parameters.Add("@alias", SqlDbType.NVarChar, 50).Value = miSocio.alias;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        public Socio BuscarSocio(string Alias)
        {
            return null;
        }

        public void AltaPrestamo(Prestamo miPrestamo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Tabla_Prestamo(idPrestamo,idUnidad,fechaPrestamo,fechaDevolucion,activo,aliasSocio) values (@idPrestamo,@idUnidad,@fechaPrestamo,@fechaDevolucion,@activo,@aliasSocio)";

            cmd.Parameters.Add("@idPrestamo", SqlDbType.Int).Value = miPrestamo.idPrestamo;
            cmd.Parameters.Add("@idUnidad", SqlDbType.Int).Value = miPrestamo.idUnidad;
            cmd.Parameters.Add("@fechaPrestamo", SqlDbType.DateTime).Value = miPrestamo.fechaPrestamo;
            cmd.Parameters.Add("@fechaDevolucion", SqlDbType.DateTime).Value = miPrestamo.fechaDevolucion;
            cmd.Parameters.Add("@activo", SqlDbType.Bit).Value = miPrestamo.activo;
            cmd.Parameters.Add("@aliasSocio", SqlDbType.NVarChar, 50).Value = miPrestamo.aliasSocio;
            

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                con.Close();
            }
        }

        public void BajaPrestamo(Prestamo miPrestamo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE Tabla_Prestamo SET activo='false' WHERE activo='true' AND idUnidad=@idUnidad";
            cmd.Parameters.Add("@idUnidad", SqlDbType.Int).Value = miPrestamo.idUnidad;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                con.Close();
            }
        }

        public List<Prestamo> BuscarPrestamo(Prestamo miPrestamo)
        {
            List<Prestamo> aux = new List<Prestamo>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string cadena = "SELECT * FROM Tabla_Prestamo WHERE ";

            if (miPrestamo.idPrestamo != -1)
            {
                cmd.Parameters.Add("@idPrestamo", SqlDbType.Int).Value = miPrestamo.idPrestamo;
                cadena += "idPrestamo=@idPrestamo AND ";
            }

            if (miPrestamo.idUnidad != -1)
            {
                cmd.Parameters.Add("@idUnidad", SqlDbType.Int).Value = miPrestamo.idUnidad;
                cadena += "idUnidad=@idUnidad AND ";
            }

            if (miPrestamo.aliasSocio != String.Empty)
            {
                cmd.Parameters.Add("@aliasSocio", SqlDbType.NVarChar, 50).Value = miPrestamo.aliasSocio;
                cadena += "aliasSocio=@aliasSocio AND ";
            }

            if (miPrestamo.idPrestamo != -1 || miPrestamo.idUnidad != -1 || miPrestamo.aliasSocio != String.Empty)
                cadena = cadena.Remove(cadena.Length - 5);
            else
                cadena = cadena.Remove(cadena.Length - 7);

            cmd.CommandText = cadena;

            Prestamo prestamo = null;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prestamo = new Prestamo();
                    prestamo.idPrestamo = (int)reader["idPrestamo"];
                    prestamo.idUnidad = (int)reader["idUnidad"];
                    prestamo.aliasSocio = reader["aliasSocio"].ToString();
                    prestamo.activo = (bool)reader["activo"];
                    prestamo.fechaPrestamo = Convert.ToDateTime(reader["fechaPrestamo"]);
                    prestamo.fechaDevolucion = Convert.ToDateTime(reader["fechaDevolucion"]);
                    aux.Add(prestamo);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
            return aux;
        }

        void EnviarBoletin(Boletin miBoletin)
        {
            
        }

        Boletin BuscarBoletin()
        {
            return null;
        }

        void EnviarNotificacion()
        {
            
        }

        public void AltaOpinion(Opinion miOpinion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Tabla_Opinion(idOpinion,alias_autor,nota,comentario,idJuego) values (@idOpinion,@alias_autor,@nota,@comentario,@idJuego)";

            cmd.Parameters.Add("@idOpinion", SqlDbType.Int).Value = miOpinion.idOpinion;
            cmd.Parameters.Add("@alias_autor", SqlDbType.NVarChar, 50).Value = miOpinion.alias_autor;
            cmd.Parameters.Add("@nota", SqlDbType.Int).Value = miOpinion.nota;
            cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 800).Value = miOpinion.comentario;
            cmd.Parameters.Add("@idJuego", SqlDbType.Int).Value = miOpinion.idJuego;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                con.Close();
            }
        }

        public List<Opinion> BuscarOpinion(Opinion opinion_entrada)
        {
            List<Opinion> aux = new List<Opinion>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string cadena = "SELECT * FROM Tabla_Opinion WHERE ";

            if (opinion_entrada.idOpinion != -1)
            {
                cmd.Parameters.Add("@idOpinion", SqlDbType.Int).Value = opinion_entrada.idOpinion;
                cadena += "idOpinion=@idOpinion AND ";
            }

            if (opinion_entrada.alias_autor != null)
            {
                cmd.Parameters.Add("@alias_autor", SqlDbType.NVarChar, 50).Value = opinion_entrada.alias_autor;
                cadena += "alias_autor=@alias_autor AND ";
            }

            if (opinion_entrada.idJuego != -1)
            {
                cmd.Parameters.Add("@idJuego", SqlDbType.Int).Value = opinion_entrada.idJuego;
                cadena += "idJuego=@idJuego AND ";
            }

            if (opinion_entrada.idOpinion != -1 || opinion_entrada.alias_autor != null || opinion_entrada.idJuego != -1)
                cadena = cadena.Remove(cadena.Length - 5);


            cmd.CommandText = cadena;

            Opinion opinion = null;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    opinion = new Opinion();
                    opinion.idOpinion = (int)reader["idOpinion"];
                    opinion.comentario = reader["comentario"].ToString();
                    opinion.alias_autor = reader["alias_autor"].ToString();
                    opinion.idJuego = (int)reader["idJuego"];
                    opinion.nota = (int)reader["nota"];
                    //opinion = (Opinion)reader["Tabla_Opinion"];
                    aux.Add(opinion);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
            return aux;
        } 

        public void BajaOpinion(Opinion miOpinion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM Tabla_Opinion WHERE idOpinion=@idOpinion";
            cmd.Parameters.Add("@idOpinion", SqlDbType.Int).Value = miOpinion.idOpinion;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }

        }

        public void AltaJuego(Juego miJuego)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Tabla_Juego(idFicha,titulo,plataforma,genero,PEGI) values (@idFicha,@titulo,@plataforma,@genero,@PEGI)";

            cmd.Parameters.Add("@idFicha", SqlDbType.Int).Value = miJuego.idFicha;
            cmd.Parameters.Add("@titulo", SqlDbType.NVarChar, 50).Value = miJuego.titulo;
            cmd.Parameters.Add("@plataforma", SqlDbType.NVarChar, 50).Value = miJuego.plataforma;
            cmd.Parameters.Add("@genero", SqlDbType.NVarChar, 50).Value = miJuego.genero;
            cmd.Parameters.Add("@PEGI", SqlDbType.Int).Value = miJuego.PEGI;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception e)
            {
                con.Close();
            }
        }

        Juego ModificacionJuego(Juego miJuego)
        {
            return null;
        }

        public void BajaJuego(Juego miJuego)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM Tabla_Juego WHERE idFicha=@idFicha";
            cmd.Parameters.Add("@idFicha", SqlDbType.Int).Value = miJuego.idFicha;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }

            UnidadJuego unidad = new UnidadJuego();
            unidad.idJuego = miJuego.idFicha;
            BajaUnidadJuego(unidad);

            Opinion opinion = new Opinion();
            opinion.idJuego = miJuego.idFicha;
            BajaOpinion(opinion);

            Prestamo prestamo = new Prestamo();
            unidad = new UnidadJuego();
            unidad.idJuego = miJuego.idFicha;
            unidad.idUnidad = -1;
            unidad.aliasDueño = null;
            foreach (UnidadJuego unidad_buscada in Club.Instance.BuscarUnidadJuego(unidad))
            {
                prestamo.idUnidad = unidad_buscada.idUnidad;
                BajaPrestamo(prestamo);
            }
        }

        public List<Juego> BuscarJuego(Juego juego_entrada)
        {
            List<Juego> aux = new List<Juego>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string cadena = "SELECT * FROM Tabla_Juego WHERE ";

            if (juego_entrada.titulo != null)
            {
                //cmd.Parameters.Add("@titulo", SqlDbType.NVarChar, 50).Value = juego_entrada.titulo;
                //cadena += "titulo=@titulo AND ";
                cadena += "titulo LIKE '%" + juego_entrada.titulo + "%' AND ";
            }

            if (juego_entrada.plataforma != null)
            {
                cmd.Parameters.Add("@plataforma", SqlDbType.NVarChar, 50).Value = juego_entrada.plataforma;
                cadena += "plataforma=@plataforma AND ";
            }

            if (juego_entrada.genero != null)
            {
                //cmd.Parameters.Add("@genero", SqlDbType.NVarChar, 50).Value = juego_entrada.genero;
                //cadena += "genero=@genero AND ";
                cadena += "genero LIKE '%" + juego_entrada.genero + "%' AND ";
            }

            if (juego_entrada.PEGI != 0)
            {
                cmd.Parameters.Add("@PEGI", SqlDbType.NVarChar, 50).Value = juego_entrada.PEGI;
                cadena += "PEGI=@PEGI AND ";
            }

            if (juego_entrada.titulo != null || juego_entrada.plataforma != null || juego_entrada.genero != null || juego_entrada.PEGI != 0)
                cadena = cadena.Remove(cadena.Length - 5);
            
            else if (juego_entrada.idFicha != null)
            {
                //cadena = cadena.Remove(cadena.Length - 7);
                cmd.Parameters.Add("@idFicha", SqlDbType.Int).Value = juego_entrada.idFicha;
                cadena += "idFicha=@idFicha";
            }

            //si no se ha añadido nada se modifica la cadena para que saque todos los socios
            if (cadena == "SELECT * FROM Tabla_Juego WHERE ")
                cadena = cadena.Remove(cadena.Length - 7);

            cmd.CommandText = cadena;

            Juego juego = null;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    juego = new Juego();
                    juego.idFicha = (int)reader["idFicha"];
                    juego.titulo = reader["titulo"].ToString();
                    juego.plataforma = reader["plataforma"].ToString();
                    juego.genero = reader["genero"].ToString();
                    juego.PEGI = (int)reader["PEGI"];
                    //socio = (Socio)reader["Tabla_Socio"];
                    aux.Add(juego);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
            return aux;
        }

        Socio Login(string usuario, string contraseña)
        {
            return null;
        }

        public List<Socio> BuscarSocio(Socio socio_entrada)
        {
            List<Socio> aux = new List<Socio>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string cadena = "SELECT * FROM Tabla_Socio WHERE ";
            if (socio_entrada == null)
                cadena = cadena.Remove(cadena.Length - 7);
            else
            {
                if (socio_entrada.alias != null)
                {
                    cmd.Parameters.Add("@alias", SqlDbType.NVarChar, 50).Value = socio_entrada.alias;
                    cadena += "alias=@alias AND ";
                }

                if (socio_entrada.nombre != null)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = socio_entrada.nombre;
                    cadena += "nombre=@nombre AND ";
                }

                if (socio_entrada.apellidos != null)
                {
                    cmd.Parameters.Add("@apellidos", SqlDbType.NVarChar, 50).Value = socio_entrada.apellidos;
                    cadena += "apellidos=@apellidos AND ";
                }

                if (socio_entrada.mail != null)
                {
                    cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 50).Value = socio_entrada.mail;
                    cadena += "mail=@mail AND ";
                }

                if (socio_entrada.telefono != null)
                {
                    cmd.Parameters.Add("@telefono", SqlDbType.NChar, 10).Value = socio_entrada.telefono;
                    cadena += "telefono=@telefono AND ";
                }

                if (socio_entrada.contraseña != null)
                {
                    cmd.Parameters.Add("@contraseña", SqlDbType.NVarChar, 50).Value = socio_entrada.contraseña;
                    cadena += "contraseña=@contraseña AND ";
                }

                cadena = cadena.Remove(cadena.Length - 5);
            }

            cmd.CommandText = cadena;
            
            Socio socio = null;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    socio = new Socio();
                    socio.alias = reader["alias"].ToString();
                    socio.nombre = reader["nombre"].ToString();
                    socio.apellidos = reader["apellidos"].ToString();
                    socio.mail = reader["mail"].ToString();
                    socio.telefono = reader["telefono"].ToString();
                    socio.contraseña = reader["contraseña"].ToString();
                    socio.esAdmin = (bool)reader["esAdmin"];
                    //socio = (Socio)reader["Tabla_Socio"];
                    aux.Add(socio);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
            return aux;
        }
    }
}
