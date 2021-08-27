using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReparacionTelefonos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //txbx2Contrasena.ReadOnly = true;
            if (!Directory.Exists(@"C:\Reparacion Telefonos\base de datos\"))
            {
                MessageBox.Show("Se confirmo que la ruta en donde se guardara la informacion no existe\n" +
                    "Por lo tanto se creara un nuevo directorio: C:/Reparacion Telefonos/base de datos");


                DirectoryInfo di = Directory.CreateDirectory(@"C:\Reparacion Telefonos\base de datos\");

               // StreamWriter file = new StreamWriter(@"C:\Reparacion Telefonos\base de datos\nroForm.txt",true);
                //file.WriteLine('0');
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictbxUsuario_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txbx1Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbx2Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        int intentos = 0;
        private void btn1Ingresar_Click(object sender, EventArgs e)//Acciones del Boton Ingresar
        {

            //Usuario y contraseña almacenados en el programa
            string nombreUsuario = "null";
            string contrasenaUsuario = "";

            

            //Verificacion de usuario y contraseña...

            //verifica si los campos estan vacios
            //if (txbx1Usuario.Text == "" || txbx2Contrasena.Text == "") MessageBox.Show("¡Debe llenar los campos!"); //Envia un mensaje, si estos estan vacios

            //Verifica si la informacion puesta por el usuario es correcta.
            if (/*txbx1Usuario.Text == nombreUsuario &&*/ txbx2Contrasena.Text == contrasenaUsuario)
            {
                this.Hide();//Oculta la ventana de Iniciar Sesion
                Menu_Principal ventana_menu = new Menu_Principal(nombreUsuario); //Crea una instancia.
                ventana_menu.Show(); //llama a la instancia.
            }
            else if (intentos == 3)//al alcanzar el limite de intentos activa esta condicional
            {
                MessageBox.Show("Limite de intentos alcanzado.\n ¡Cerrando Ventana!");
                this.Close(); //Cierra el programa por superar la cantidad de intentos.
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos. \n intento " + intentos + " / 3"); //si el usuario o contraseña es incorrecto enviara este mensaje
                intentos++;//Cada vez que falle, Intentos aumentara en 1 hasta 3, que es el limite maximo...

                txbx1Usuario.Clear();//Limpia los textbox
                txbx2Contrasena.Clear();//Limpia los textbox
            }
        }

        //Boton salir
        //Acciones del boton salir
        private void Btn2Salir_Click(object sender, EventArgs e) => this.Close();//Hara que el programa se cierre.
    }
}
