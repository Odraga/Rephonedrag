using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReparacionTelefonos
{
    public partial class Menu_Principal : Form
    {
        string buscar;
        public Menu_Principal(string nombreUsuario)
        {
            InitializeComponent();

            label1.Text += nombreUsuario;
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int activaCondicional = 0;
            

            Formulario1 ventana_formulario = new Formulario1(buscar, activaCondicional);
            ventana_formulario.ShowDialog();
        }
        private void Btn_BuscarForm_Click(object sender, EventArgs e)
        {
            Buscar_Formulario ventana_buscar_form = new Buscar_Formulario();
            ventana_buscar_form.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)//La seccion Entregado estara innactiva por falta de tiempo de desarrollo
        {
            MessageBox.Show("                                  ¡Seccion en Modernizacion!\n" +
                            "Mantenganse en contacto con el desarrollador para mas soporte.");


            /*
            Form3 pendiente = new Form3();
            pendiente.Show();
            */
        }
        private void button4_Click(object sender, EventArgs e)//La seccion pendiente estara innactiva por falta de tiempo de desarrollo
        {
            MessageBox.Show("                                  ¡Seccion en Modernizacion!\n" +
                            "Mantenganse en contacto con el desarrollador para mas soporte.");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por: Gabriel Vargas\n" +
                "Tiempo de desarrollo: 17/04/2020 -> 23/04/2020\n"+
                "Telf:+18492250300 / +18492126757\n"+
                "Correo: gabrielvr.dev@gmail.com\n\n" +
                "        ¡Espero lo haya disfrutado tanto como yo!");
        }
    }
}
