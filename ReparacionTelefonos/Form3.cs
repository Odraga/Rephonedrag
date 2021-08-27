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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            /*
            string[] ubicacion = Directory.GetFiles(@"C:\Reparacion Telefonos\base de datos\");

            for (int i = 0; i < ubicacion.Length; i++)
            {
                listView1.Items.Add("ID");
                listView1.Items.Add(Path.GetFileName(ubicacion[i]));

            }
            */
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
