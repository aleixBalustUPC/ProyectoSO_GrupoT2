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
    public partial class Login : Form
    {
        Socket servidor;
        IPEndPoint endpoint;
        public Login()
        {
            InitializeComponent();
        }

        private void inicio_de_sesion_Click(object sender, EventArgs e)
        {
            servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if ((nombre_usuario.Text == "") || (contraseña.Text == ""))
                etiqueta_mensaje_de_error.Text = "Por favor, asegúrese de escribir tanto su nombre de usuario como su contraseña.";
            else
            {
                try {
                   
                    servidor.Connect(endpoint);
                    string mensaje = "1/" + nombre_usuario.Text + "/" + contraseña.Text;
                    byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                    servidor.Send(msg);

                    byte[] respuesta = new byte[80];
                    servidor.Receive(respuesta);
                    mensaje = Encoding.ASCII.GetString(respuesta).Split('\0')[0];
                    if (mensaje == "Login")
                    {
                        //servidor.Close();
                        Formulario_de_bienvenida formulario_de_bienvenida = new Formulario_de_bienvenida();
                        formulario_de_bienvenida.set_nombre_usuario(nombre_usuario.Text);
                        formulario_de_bienvenida.set_ip(endpoint.Address);
                        formulario_de_bienvenida.set_port(endpoint.Port);
                        formulario_de_bienvenida.Show();
                        Close();
                        
       



                    }
                    else
                    {
                        MessageBox.Show("Asegúrese, por favor, de que los datos están correctamente introducidos.");
                        
                    }
                    
                    
                }
                catch (SocketException)
                {
                    MessageBox.Show("Se ha producido un error al intentar conectar con el servidor."); ;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            contraseña.Text = "";
            contraseña.MaxLength = 20;
            contraseña.PasswordChar = '*';
            nombre_usuario.Text = "";
            nombre_usuario.MaxLength = 20;

            IPAddress ip = IPAddress.Parse("192.168.56.102");
            endpoint = new IPEndPoint(ip, 35678);
            
            
            
        }

        private void nombre_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.set_ip(endpoint.Address);
            registro.set_port(endpoint.Port);
            registro.Show();
            Close();
        }
    }
}
