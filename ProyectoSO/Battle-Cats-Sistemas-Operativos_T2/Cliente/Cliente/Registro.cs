using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
    public partial class Registro : Form
    {
        Socket servidor;
        IPAddress ip;
        int port;
        IPEndPoint endpoint;
        public Registro()
        {
            InitializeComponent();
        }
        public void set_ip(IPAddress ipadd)
        {
            ip = ipadd;
        }
        public void set_port(int port)
        {
            this.port = port;
        }
        
        public bool cumple_con_los_requisitos_fecha(String fecha)
        {
            String[] partes = fecha.Split('-');
            if ((Convert.ToInt32(partes[1]) > 12) || (Convert.ToInt32(partes[1]) < 1))
                return false;
            else if ((Convert.ToInt32(partes[2]) > 31) || (Convert.ToInt32(partes[2]) < 1))
                return false;
            else
            {
                DateTime today = DateTime.Today;
                String[] arrayfecha = fecha.Split('-');
                DateTime fecha_d = new DateTime(Convert.ToInt32(arrayfecha[0]), Convert.ToInt32(arrayfecha[1]), Convert.ToInt32(arrayfecha[2]), 0, 0, 0);

                TimeSpan span = (fecha_d - today);

                if (Convert.ToInt32(span.Days)/365 <= -18)
                    return true;
                else
                    return false;
            }
            
        }
        public bool cumple_con_los_requisitors_correo(String correo)
        {
            for (int i = 0; i < correo.Length; i++)
            {
                if (correo[i] == '@')
                    return true;
            }
            return false;
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            contraseña_textbox.Text = "";
            contraseña_textbox.MaxLength = 20;
            contraseña_textbox.PasswordChar = '*';
            nombre_usuario_textbox.Text = "";
            nombre_usuario_textbox.MaxLength = 20;
            endpoint = new IPEndPoint(ip, port);

        }

        private void nombre_usuario_etiqueta_Click(object sender, EventArgs e)
        {

        }

        private void nombre_usuario_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void registro_boton_Click(object sender, EventArgs e)
        {
            servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if ((nombre_usuario_textbox.Text == "") || (contraseña_textbox.Text == "") || (correo_electronico_textbox.Text == "") || (fecha_de_nacimiento_textbox.Text == ""))
                etiqueta_error.Text = "Por favor, asegúrese de rellenar todos los campos.";
            else
            {
                if (cumple_con_los_requisitos_fecha(fecha_de_nacimiento_textbox.Text))
                {
                    if (cumple_con_los_requisitors_correo(correo_electronico_textbox.Text))
                    {
                        try
                        {
                            
                            servidor.Connect(endpoint);
                            string mensaje = "3/" + nombre_usuario_textbox.Text + "/" + contraseña_textbox.Text + "/" + correo_electronico_textbox.Text + "/" + fecha_de_nacimiento_textbox.Text;
                            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                            servidor.Send(msg);

                            byte[] respuesta = new byte[80];
                            servidor.Receive(respuesta);
                            mensaje = Encoding.ASCII.GetString(respuesta).Split('\0')[0];
                            if (mensaje == "Registro")
                            {
                                Formulario_de_bienvenida formulario_de_bienvenida = new Formulario_de_bienvenida();
                                formulario_de_bienvenida.set_ip(endpoint.Address);
                                formulario_de_bienvenida.set_port(endpoint.Port);
                                formulario_de_bienvenida.set_nombre_usuario(nombre_usuario_textbox.Text);
                                formulario_de_bienvenida.Show();
                                Close();
                                
                            }
                            else if (mensaje == "Correo existente")
                            {
                                MessageBox.Show("El correo introducido ya existe.");

                            }
                            else if (mensaje == "Usuario existente")
                            {
                                MessageBox.Show("El usuario introducido ya existe.");
                            }

                        }
                        catch (SocketException)
                        {
                            MessageBox.Show("Se ha producido un error al intentar conectar con el servidor."); ;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, escriba el correo electrónico en un formato válido");
                    }
                }

                else
                {
                    MessageBox.Show("Para registrarte has de ser mayor de edad. Asegúrese, además, que la fecha está introducida en un formato correcto.");
                }
            }
        }
    }
}
