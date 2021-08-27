using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ReparacionTelefonos
{
    public partial class Buscar_Formulario : Form
    {
        string buscar;//Guarda el valor numerico en string, del Nro de formulario a buscar.
        int activaCondicional = 1;// servira para activar la opcion(condiciona) de buscar en el Formulario.
        public Buscar_Formulario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader archivo = null;

            //Busca excepciones
            try
            {
                buscar = textBox1.Text;
                archivo = new StreamReader(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + buscar + ".txt");
                archivo.Close();
            }
            //FormatException sirve cuando el tipo de dato que entra no es el mismo que el que usa la variable Ejemplo int x igual a un string
            catch (FileNotFoundException ex)
            {  
                MessageBox.Show("Campo Vacio / No existe este formulario");
            }
            finally
            {
                if (archivo != null)
                {
                    Formulario1 buscarFormulario = new Formulario1(buscar, activaCondicional);// crea la ventana Formulario1 y tendra los parametros de buscar y activaCondicional
                    buscarFormulario.Show();//llama la ventana formulario.
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader archivo = null;


            //Busca excepciones
            try
            {
                buscar = textBox1.Text;
                archivo = new StreamReader(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + buscar + ".txt");
                archivo.Close();

                File.Delete(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + buscar + ".txt");
                if (File.Exists(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + buscar + ".txt") == false)
                {
                    MessageBox.Show("Borrado con exito");
                    textBox1.Clear();
                }
            }
            //FormatException sirve cuando el tipo de dato que entra no es el mismo que el que usa la variable Ejemplo int x igual a un string
            catch (FileNotFoundException ex)
            {

                MessageBox.Show("Campo Vacio / No existe este formulario");

            }
            catch(IOException ex)
            {
                MessageBox.Show("El nombre del Formulario es incorrecto...");
            }
            
        }

        private void Buscar_Formulario_Load(object sender, EventArgs e)
        {

        }
    }
}
