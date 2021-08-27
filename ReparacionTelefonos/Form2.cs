using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace ReparacionTelefonos
{
    public partial class Formulario1 : Form
    {
        //variable que crea un nuevo formulario
        int nroFormulario_Aumenta = 0;//esta variable tiene 2 funciones. La primera es crear los archivos de formulario por orden, y actualizar el archivo nroform.txt
        int nroAdelante = 0; //arreglar la diferencia de la ventana form, guardaba por ejemplo el formulario 2 y aun creado no actualizaba a 3, si no, lo que hacia es crear la variable 3 estando en el 2. esta variable aumenta 1 su valor a la cantidad real de archivos.
                             // como veras mas adelante lo que hace esta variable, es cambiar el valor en la ventana formulario y aumentara 1 valor mas al que ya esta creado. si escribes al form 3 no te aparezca como que es el 2.
        
        string buscar_1 =  null;
        string linea;

        

        public Formulario1(string buscar, int activaCondicional)
        {
            buscar_1 = buscar;
            InitializeComponent();

            if (activaCondicional == 1) //gracias a este condicional podremos buscar un formulario en especifico si alterar el resto del codigo.
            {
                /*este lo que hace es llamar al archivo de texto(base de datos provicional) para dar una lectura de sus datos. por esta razon concatena la variable buscar. ya 
                 * que estos poseen de una ID unica...
                */
                try
                {
                    StreamReader buscarFormulario = new StreamReader(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + buscar + ".txt", true);
                    TxBxNro.Text = buscar; //en el formulario este solo pondra su ID o Nro de formulario.

                    //desde aca se mostrara la informacion guardada en el archivo, en el formulario

                    //Leer Informacion del cliente.
                    TxBxNombreAp.Text = buscarFormulario.ReadLine();
                    TxBxDireccion.Text = buscarFormulario.ReadLine();
                    TxBxCedula.Text = buscarFormulario.ReadLine();
                    TxBxTelefono.Text = buscarFormulario.ReadLine();

                    //Leer Caracteristicas del dispositivo
                    linea = buscarFormulario.ReadLine();
                    if(linea == "Telefono")
                    {
                        RaBtn_Telefono.Checked = true;
                    }
                    
                    else if (linea == "Tablet")
                    {
                        RaBtn_Tablet.Checked = true; 
                    }
                    else 
                    {
                        RaBtn_Otro.Checked = true;
                        TxBx_Otro.Text = linea;
                    }
                    TxBx_Marca.Text = buscarFormulario.ReadLine();
                    TxBx_Modelo.Text = buscarFormulario.ReadLine();
                    TxBx_Serial.Text = buscarFormulario.ReadLine();
                    TxBx_Contrasena.Text = buscarFormulario.ReadLine();

                    linea = buscarFormulario.ReadLine();
                    if (linea == "Si")
                    {
                        RaBtn_BateriaSi.Checked = true;
                    }
                    else if (linea == "No")
                    {
                        RaBtn_BateriaNo.Checked = true;
                    }


                    //Leer Caracteristicas de la falla.
                    linea = buscarFormulario.ReadLine();
                    RTxBx_FallaDisp.Text = linea;
                    RTxBx_Observacion.Text = buscarFormulario.ReadLine();

                    linea = buscarFormulario.ReadLine();
                    if (linea == "Entregado")
                    {
                        
                        DateTime dateTime = DateTime.ParseExact(buscarFormulario.ReadLine(), "d/M/yyyy", CultureInfo.CreateSpecificCulture("en-US"));
                        DaTiPick_FechaEnt.Value = dateTime;
                        RaBtn_Entregado.Checked = true;

                    }
                    else if (linea == RaBtn_Pendiente.Text)
                    {
                        RaBtn_Pendiente.Text = linea; ;
                    }

                    TxBx_Revision.Text = buscarFormulario.ReadLine();
                    TxBx_Reparacion.Text = buscarFormulario.ReadLine();
                    TxBx_TotalPagar.Text = buscarFormulario.ReadLine();

                    buscarFormulario.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No existe este archivo"+ex.Message);
                }
                

            }


            //trabaja con el Nro de los formularios
            else if(activaCondicional != 1)
            {
                /*si te fijas esta parte del codigo ya es directo de la ventana Formulario, antes se tenia el problema de que el programa se cerraba o la ventana de formulario,
                 * el programa empezaria  otra vez desde el pincipio logrando sobrescribir los datos de los archivos unicos de cada cliente... para evitar esto
                 * se creo el archivo de texto nroForm, que guarda el ultimo punto en el cual escribio.
                 */
                
                try
                {
                    StreamReader leer = new StreamReader(@"C:\Reparacion Telefonos\base de datos\nroForm.txt");// en esta parte del codigo lo que se hace es leer y actualizar el programa en donde se habia quedado. (ultimo formulario creado).
                    nroFormulario_Aumenta = int.Parse(leer.ReadLine()); // la variable se actualiza con el ultimo formulario creado

                    nroAdelante = nroFormulario_Aumenta; // nro adelante adquiere el valor de nroFormulario_Aumenta. Explicacion mas arriba.

                    TxBxNro.Text = nroAdelante.ToString();// el textbox que enumera los Form, adquirira los valores del nroAdelante.
                    leer.Close();
                }
                catch (Exception ex)
                {
                    
                }
               
            }
            //Esta codicional evitara que cuando se salga y entre al programa este edite el ultimo archivo creado, si no, que cree otro nuevo siguiendo la secuencia.
            if (nroAdelante == nroFormulario_Aumenta && activaCondicional != 1)
            {
                StreamWriter escribir_Nro = new StreamWriter(@"C:\Reparacion Telefonos\base de datos\nroForm.txt");

                if(File.Exists(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + nroFormulario_Aumenta.ToString() + ".txt")){
                    nroFormulario_Aumenta++;
                }
                nroAdelante = nroFormulario_Aumenta;
                TxBxNro.Text = nroAdelante.ToString();
                escribir_Nro.WriteLine(TxBxNro.Text);
                escribir_Nro.Close();
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)//textbox que idica el numero de formulario¿.
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Lab1Bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void Lab_InfoClient_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void TxBxNombreAp_TextChanged(object sender, EventArgs e)// Nombre apellido de Form2
        {
               //Guarda el Nombre y Apellido del formulario en el Arreglo nombre apellido
        }
        private void TxBxDireccion_TextChanged(object sender, EventArgs e)// Direccion de Form2
        {

        }
        private void TxBxCedula_TextChanged(object sender, EventArgs e)//Cedula de Form2
        {

        }

        private void TxBxTelefono_TextChanged(object sender, EventArgs e)//telefono de Form2
        {

        }

        private void RaBtn_Telefono_CheckedChanged(object sender, EventArgs e)// Radio button Telefono de Form2
        {

        }
        private void RaBtn_Tablet_CheckedChanged(object sender, EventArgs e)// Radio button Tablet de form2
        {

        }
        private void RaBtn_Otro_CheckedChanged(object sender, EventArgs e)//Radio Button otro de Form2
        {
            if (RaBtn_Otro.Checked == true)
            {
                TxBx_Otro.ReadOnly = false;
            }
            else if (RaBtn_Otro.Checked == false)
            {
                TxBx_Otro.ReadOnly = true;
                TxBx_Otro.Clear();
            }
        }

        private void RTxBx_FallaDisp_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)//radio button que dice si esta Entregado
        {
            if (RaBtn_Entregado.Checked == true)
            {
                DaTiPick_FechaEnt.Visible = true;
                Lab_FechaEnt.Visible = true;

            }
        }
        private void RaBtn_Pendiente_CheckedChanged(object sender, EventArgs e)//Radio button que dice si no esta Pendiente
        {
            if(RaBtn_Pendiente.Checked == true)
            {
                DaTiPick_FechaEnt.Visible = false;
                Lab_FechaEnt.Visible = false;
            }
        }
        private void TxBx_Revision_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxBx_Reparacion.Text))
                {
                    TxBx_TotalPagar.Text = TxBx_Revision.Text;
                }
                else
                {
                    TxBx_TotalPagar.Text = Pago_Total(int.Parse(TxBx_Revision.Text), int.Parse(TxBx_Reparacion.Text)).ToString();
                }
            }catch(Exception ex) { }
        }
        private void textBox13_TextChanged(object sender, EventArgs e)

        {

            try
            {
                if (string.IsNullOrEmpty(TxBx_Revision.Text))
                {
                    TxBx_TotalPagar.Text = TxBx_Reparacion.Text;
                }
                else
                {
                    TxBx_TotalPagar.Text = Pago_Total(int.Parse(TxBx_Revision.Text), int.Parse(TxBx_Reparacion.Text)).ToString();
                }
            }
            catch{}
        }

        private void TxBx_TotalPagar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxBxNombreAp.Text) || string.IsNullOrEmpty(TxBxDireccion.Text) || string.IsNullOrEmpty(TxBxCedula.Text) || string.IsNullOrEmpty(TxBxCedula.Text) || string.IsNullOrEmpty(TxBxTelefono.Text) || string.IsNullOrEmpty(TxBx_Marca.Text) || string.IsNullOrEmpty(TxBx_Modelo.Text) || string.IsNullOrEmpty(TxBx_Serial.Text) || string.IsNullOrEmpty(TxBx_Contrasena.Text) || string.IsNullOrEmpty(RTxBx_FallaDisp.Text) || string.IsNullOrEmpty(RTxBx_Observacion.Text))
            {
                MessageBox.Show("Debe llenar los campos restantes");
            }

            else if (buscar_1 == null) 
            {//este if habilitara la creacion y escritura de un nuevo formulario.
                nroAdelante += 1; // aumentara uno su valor, al valor real de archivos creados.
                TxBxNro.Text = nroAdelante.ToString();

                try
                {
                    StreamWriter escribir = new StreamWriter(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + nroFormulario_Aumenta + ".txt", true);//crea los archivos de texto de los clientes, cada uno es individual.
                    StreamWriter escribir_Nro = new StreamWriter(@"C:\Reparacion Telefonos\base de datos\nroForm.txt"); // actualiza el nro del formulario que se creo.


                    //Escribir Datos del cliente
                    escribir.WriteLine(TxBxNombreAp.Text);//escribe en el archivo los datos guardados en la ventana form.
                    escribir.WriteLine(TxBxDireccion.Text);
                    escribir.WriteLine(TxBxCedula.Text);
                    escribir.WriteLine(TxBxTelefono.Text);

                    //Escribir Caracteristicas del dispositivo
                    if (RaBtn_Telefono.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Telefono.Text);
                    }
                    else if (RaBtn_Tablet.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Tablet.Text);
                    }
                    else if (RaBtn_Otro.Checked == true)
                    {
                        escribir.WriteLine(TxBx_Otro);
                    }
                    escribir.WriteLine(TxBx_Marca.Text);
                    escribir.WriteLine(TxBx_Modelo.Text);
                    escribir.WriteLine(TxBx_Serial.Text);
                    escribir.WriteLine(TxBx_Contrasena.Text);
                    if (RaBtn_BateriaSi.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_BateriaSi.Text);
                    }
                    else if (RaBtn_BateriaNo.Checked == false)
                    {
                        escribir.WriteLine(RaBtn_BateriaNo.Text);
                    }

                    //Caracteristicas de la falla

                    escribir.WriteLine(RTxBx_FallaDisp.Text.Replace("\r\n", " ").Replace("\n", "").Replace("\r", " ").Replace("\t", ""));//los Replace permiten eliminar los saltos de lineas y tabulaciones creadas.
                    escribir.WriteLine(RTxBx_Observacion.Text.Replace("\r\n", " ").Replace("\n", "").Replace("\r", " ").Replace("\t", ""));

                    if (RaBtn_Entregado.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Entregado.Text);
                        escribir.WriteLine(DaTiPick_FechaEnt.Text);
                    }
                    else if (RaBtn_Pendiente.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Pendiente.Text);
                    }
                    escribir.WriteLine(TxBx_Revision.Text);
                    escribir.WriteLine(TxBx_Reparacion.Text);
                    try
                    {
                        escribir.WriteLine(Pago_Total(int.Parse(TxBx_Revision.Text), int.Parse(TxBx_Reparacion.Text)).ToString());
                    }
                    catch { }

                    escribir_Nro.WriteLine(nroFormulario_Aumenta);//sobreescribe el valor, o nro de formulario existente por una nueva cantidad.


                    escribir.Close();//cierra archivo escribir
                    escribir_Nro.Close();//Cierra archivo escribir_Nro
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    nroFormulario_Aumenta += 1;

                    //Limpia los textbox al precionar el boton guardar.
                    TxBxNombreAp.Clear();
                    TxBxDireccion.Clear();
                    TxBxCedula.Clear();
                    TxBxTelefono.Clear();
                    TxBx_Marca.Clear();
                    TxBx_Modelo.Clear();
                    TxBx_Serial.Clear();
                    TxBx_Contrasena.Clear();
                    TxBx_Otro.Clear();
                    RTxBx_FallaDisp.Clear();
                    RTxBx_Observacion.Clear();
                    TxBx_Revision.Clear();
                    TxBx_Reparacion.Clear();
                    TxBx_TotalPagar.Clear();

                    MessageBox.Show("¡Formulario guardado!");
                }
            }
            else//si la edicion anterior es incorrecta, pues significa que se esta buscando un formulario y por lo tanto, el siguiente codigo lo que hace es reemplazar los datos existentes. por los nuevos escritos.
            {
                try
                {
                    StreamWriter escribir = new StreamWriter(@"C:\Reparacion Telefonos\base de datos\formulario_user_" + buscar_1 + ".txt");//crea los archivos de texto de los clientes, cada uno es individual


                    //Editar los datos existentes del cliente
                    escribir.WriteLine(TxBxNombreAp.Text);//escribe en el archivo los datos guardados en la ventana form.
                    escribir.WriteLine(TxBxDireccion.Text);
                    escribir.WriteLine(TxBxCedula.Text);
                    escribir.WriteLine(TxBxTelefono.Text);

                    //Editar las Caracteristicas existentes del dispositivo
                    if (RaBtn_Telefono.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Telefono.Text);
                    }
                    else if (RaBtn_Tablet.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Tablet.Text);
                    }
                    else if (RaBtn_Otro.Checked == true)
                    {
                        escribir.WriteLine(TxBx_Otro.Text);
                    }
                    escribir.WriteLine(TxBx_Marca.Text);
                    escribir.WriteLine(TxBx_Modelo.Text);
                    escribir.WriteLine(TxBx_Serial.Text);
                    escribir.WriteLine(TxBx_Contrasena.Text);
                    if (RaBtn_BateriaSi.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_BateriaSi.Text);
                    }
                    else if (RaBtn_BateriaNo.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_BateriaNo.Text);
                    }

                    //Editar caracteristicas existentes de la falla
                    escribir.WriteLine(RTxBx_FallaDisp.Text.Replace("\r\n", " ").Replace("\n", "").Replace("\r", " ").Replace("\t", ""));
                    escribir.WriteLine(RTxBx_Observacion.Text.Replace("\r\n", " ").Replace("\n", "").Replace("\r", " ").Replace("\t", ""));

                    if (RaBtn_Entregado.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Entregado.Text);
                        escribir.WriteLine(DaTiPick_FechaEnt.Text);
                    }
                    else if (RaBtn_Pendiente.Checked == true)
                    {
                        escribir.WriteLine(RaBtn_Pendiente.Text);
                    }
                    escribir.WriteLine(TxBx_Revision.Text);
                    escribir.WriteLine(TxBx_Reparacion.Text);
                    try
                    {
                        escribir.WriteLine(Pago_Total(int.Parse(TxBx_Revision.Text), int.Parse(TxBx_Reparacion.Text)).ToString());
                    }
                    catch { }
                    finally 
                    { 
                        escribir.Close();//cierra archivo escribir
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("¡El formulario se edito exitosamente!");
                }
            }
        }
        private int Pago_Total(int revision, int reparacion) => revision + reparacion; 

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        
    }
}