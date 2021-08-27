using System.ComponentModel;
using System.Windows.Forms;

namespace ReparacionTelefonos
{
    partial class Formulario1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Formulario1(int nroFormulario_Aumenta, int nroAdelante, string buscar_1, string linea, IContainer components, Label lab3Bienvenido, Label lab1Bienvenido, Label lab_InfoClient, Label label2, TextBox txBxNombreAp, Label label3, TextBox txBxDireccion, Label label4, TextBox txBxCedula, Label label5, TextBox txBxTelefono, RadioButton raBtn_Telefono, RadioButton raBtn_Tablet, Label label6, RadioButton raBtn_Otro, TextBox txBx_Otro, Label label7, TextBox txBx_Marca, Label label8, TextBox txBx_Modelo, Label label9, TextBox txBx_Serial, Label label10, TextBox txBx_Contrasena, RadioButton raBtn_BateriaSi, RadioButton raBtn_BateriaNo, GroupBox dddd, Label label11, Label label12, RichTextBox rTxBx_FallaDisp, Label label13, RichTextBox rTe, Label lab_FechaEnt, DateTimePicker daTiPick_FechaEnt, Label label15, TextBox txBx_Revision, Label label16, TextBox txBx_TotalPagar, GroupBox groupBox1, RadioButton raBtn_Pendiente, RadioButton raBtn_Entregado, Button button1, Label label17, TextBox txBxNro, Label label18, TextBox txBx_Reparacion, Button btnGuardarInf, GroupBox groupBox2, RichTextBox rTxBx_Observacion)
        {
            this.nroFormulario_Aumenta = nroFormulario_Aumenta;
            this.nroAdelante = nroAdelante;
            this.buscar_1 = buscar_1;
            this.linea = linea;
            this.components = components;
            Lab3Bienvenido = lab3Bienvenido;
            Lab1Bienvenido = lab1Bienvenido;
            Lab_InfoClient = lab_InfoClient;
            this.label2 = label2;
            TxBxNombreAp = txBxNombreAp;
            this.label3 = label3;
            TxBxDireccion = txBxDireccion;
            this.label4 = label4;
            TxBxCedula = txBxCedula;
            this.label5 = label5;
            TxBxTelefono = txBxTelefono;
            RaBtn_Telefono = raBtn_Telefono;
            RaBtn_Tablet = raBtn_Tablet;
            this.label6 = label6;
            RaBtn_Otro = raBtn_Otro;
            TxBx_Otro = txBx_Otro;
            this.label7 = label7;
            TxBx_Marca = txBx_Marca;
            this.label8 = label8;
            TxBx_Modelo = txBx_Modelo;
            this.label9 = label9;
            TxBx_Serial = txBx_Serial;
            this.label10 = label10;
            TxBx_Contrasena = txBx_Contrasena;
            RaBtn_BateriaSi = raBtn_BateriaSi;
            RaBtn_BateriaNo = raBtn_BateriaNo;
            this.dddd = dddd;
            this.label11 = label11;
            this.label12 = label12;
            RTxBx_FallaDisp = rTxBx_FallaDisp;
            this.label13 = label13;
            RTe = rTe;
            Lab_FechaEnt = lab_FechaEnt;
            DaTiPick_FechaEnt = daTiPick_FechaEnt;
            this.label15 = label15;
            TxBx_Revision = txBx_Revision;
            this.label16 = label16;
            TxBx_TotalPagar = txBx_TotalPagar;
            this.groupBox1 = groupBox1;
            RaBtn_Pendiente = raBtn_Pendiente;
            RaBtn_Entregado = raBtn_Entregado;
            this.button1 = button1;
            this.label17 = label17;
            TxBxNro = txBxNro;
            this.label18 = label18;
            TxBx_Reparacion = txBx_Reparacion;
            BtnGuardarInf = btnGuardarInf;
            this.groupBox2 = groupBox2;
            RTxBx_Observacion = rTxBx_Observacion;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lab3Bienvenido = new System.Windows.Forms.Label();
            this.Lab1Bienvenido = new System.Windows.Forms.Label();
            this.Lab_InfoClient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxBxNombreAp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxBxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxBxCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxBxTelefono = new System.Windows.Forms.TextBox();
            this.RaBtn_Telefono = new System.Windows.Forms.RadioButton();
            this.RaBtn_Tablet = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.RaBtn_Otro = new System.Windows.Forms.RadioButton();
            this.TxBx_Otro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxBx_Marca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxBx_Modelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxBx_Serial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxBx_Contrasena = new System.Windows.Forms.TextBox();
            this.RaBtn_BateriaSi = new System.Windows.Forms.RadioButton();
            this.RaBtn_BateriaNo = new System.Windows.Forms.RadioButton();
            this.dddd = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RTxBx_FallaDisp = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RTxBx_Observacion = new System.Windows.Forms.RichTextBox();
            this.Lab_FechaEnt = new System.Windows.Forms.Label();
            this.DaTiPick_FechaEnt = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.TxBx_Revision = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxBx_TotalPagar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RaBtn_Pendiente = new System.Windows.Forms.RadioButton();
            this.RaBtn_Entregado = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TxBxNro = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxBx_Reparacion = new System.Windows.Forms.TextBox();
            this.BtnGuardarInf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dddd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab3Bienvenido
            // 
            this.Lab3Bienvenido.AutoSize = true;
            this.Lab3Bienvenido.Location = new System.Drawing.Point(-256, -74);
            this.Lab3Bienvenido.Name = "Lab3Bienvenido";
            this.Lab3Bienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab3Bienvenido.Size = new System.Drawing.Size(0, 17);
            this.Lab3Bienvenido.TabIndex = 2;
            // 
            // Lab1Bienvenido
            // 
            this.Lab1Bienvenido.AutoSize = true;
            this.Lab1Bienvenido.Location = new System.Drawing.Point(-248, -77);
            this.Lab1Bienvenido.Name = "Lab1Bienvenido";
            this.Lab1Bienvenido.Size = new System.Drawing.Size(0, 17);
            this.Lab1Bienvenido.TabIndex = 3;
            this.Lab1Bienvenido.Click += new System.EventHandler(this.Lab1Bienvenido_Click);
            // 
            // Lab_InfoClient
            // 
            this.Lab_InfoClient.AutoSize = true;
            this.Lab_InfoClient.BackColor = System.Drawing.Color.Transparent;
            this.Lab_InfoClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_InfoClient.Image = global::ReparacionTelefonos.Properties.Resources.colorful_2174045_1280;
            this.Lab_InfoClient.Location = new System.Drawing.Point(6, 24);
            this.Lab_InfoClient.Name = "Lab_InfoClient";
            this.Lab_InfoClient.Size = new System.Drawing.Size(402, 19);
            this.Lab_InfoClient.TabIndex = 8;
            this.Lab_InfoClient.Text = "                                Informacion del Cliente                          " +
    "   ";
            this.Lab_InfoClient.Click += new System.EventHandler(this.Lab_InfoClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // TxBxNombreAp
            // 
            this.TxBxNombreAp.Location = new System.Drawing.Point(145, 54);
            this.TxBxNombreAp.Name = "TxBxNombreAp";
            this.TxBxNombreAp.Size = new System.Drawing.Size(169, 25);
            this.TxBxNombreAp.TabIndex = 10;
            this.TxBxNombreAp.TextChanged += new System.EventHandler(this.TxBxNombreAp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dirección:";
            // 
            // TxBxDireccion
            // 
            this.TxBxDireccion.Location = new System.Drawing.Point(91, 83);
            this.TxBxDireccion.Name = "TxBxDireccion";
            this.TxBxDireccion.Size = new System.Drawing.Size(317, 25);
            this.TxBxDireccion.TabIndex = 12;
            this.TxBxDireccion.TextChanged += new System.EventHandler(this.TxBxDireccion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cedula:";
            // 
            // TxBxCedula
            // 
            this.TxBxCedula.Location = new System.Drawing.Point(76, 114);
            this.TxBxCedula.Name = "TxBxCedula";
            this.TxBxCedula.Size = new System.Drawing.Size(96, 25);
            this.TxBxCedula.TabIndex = 13;
            this.TxBxCedula.TextChanged += new System.EventHandler(this.TxBxCedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(178, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefono:";
            // 
            // TxBxTelefono
            // 
            this.TxBxTelefono.Location = new System.Drawing.Point(250, 114);
            this.TxBxTelefono.Name = "TxBxTelefono";
            this.TxBxTelefono.Size = new System.Drawing.Size(158, 25);
            this.TxBxTelefono.TabIndex = 14;
            this.TxBxTelefono.TextChanged += new System.EventHandler(this.TxBxTelefono_TextChanged);
            // 
            // RaBtn_Telefono
            // 
            this.RaBtn_Telefono.AutoSize = true;
            this.RaBtn_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.RaBtn_Telefono.Checked = true;
            this.RaBtn_Telefono.Location = new System.Drawing.Point(6, 19);
            this.RaBtn_Telefono.Name = "RaBtn_Telefono";
            this.RaBtn_Telefono.Size = new System.Drawing.Size(80, 21);
            this.RaBtn_Telefono.TabIndex = 15;
            this.RaBtn_Telefono.TabStop = true;
            this.RaBtn_Telefono.Text = "Telefono";
            this.RaBtn_Telefono.UseVisualStyleBackColor = false;
            this.RaBtn_Telefono.CheckedChanged += new System.EventHandler(this.RaBtn_Telefono_CheckedChanged);
            // 
            // RaBtn_Tablet
            // 
            this.RaBtn_Tablet.AutoSize = true;
            this.RaBtn_Tablet.BackColor = System.Drawing.Color.Transparent;
            this.RaBtn_Tablet.Location = new System.Drawing.Point(92, 19);
            this.RaBtn_Tablet.Name = "RaBtn_Tablet";
            this.RaBtn_Tablet.Size = new System.Drawing.Size(64, 21);
            this.RaBtn_Tablet.TabIndex = 16;
            this.RaBtn_Tablet.Text = "Tablet";
            this.RaBtn_Tablet.UseVisualStyleBackColor = false;
            this.RaBtn_Tablet.CheckedChanged += new System.EventHandler(this.RaBtn_Tablet_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Image = global::ReparacionTelefonos.Properties.Resources.color_1909977_1280;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "                           Caracteristicas del dispositivo                       " +
    "";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RaBtn_Otro
            // 
            this.RaBtn_Otro.AutoSize = true;
            this.RaBtn_Otro.BackColor = System.Drawing.Color.Transparent;
            this.RaBtn_Otro.Location = new System.Drawing.Point(162, 19);
            this.RaBtn_Otro.Name = "RaBtn_Otro";
            this.RaBtn_Otro.Size = new System.Drawing.Size(55, 21);
            this.RaBtn_Otro.TabIndex = 17;
            this.RaBtn_Otro.Text = "Otro";
            this.RaBtn_Otro.UseVisualStyleBackColor = false;
            this.RaBtn_Otro.CheckedChanged += new System.EventHandler(this.RaBtn_Otro_CheckedChanged);
            // 
            // TxBx_Otro
            // 
            this.TxBx_Otro.Location = new System.Drawing.Point(225, 15);
            this.TxBx_Otro.Name = "TxBx_Otro";
            this.TxBx_Otro.ReadOnly = true;
            this.TxBx_Otro.Size = new System.Drawing.Size(172, 25);
            this.TxBx_Otro.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Marca:";
            // 
            // TxBx_Marca
            // 
            this.TxBx_Marca.Location = new System.Drawing.Point(64, 218);
            this.TxBx_Marca.Name = "TxBx_Marca";
            this.TxBx_Marca.Size = new System.Drawing.Size(108, 25);
            this.TxBx_Marca.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(178, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Modelo:";
            // 
            // TxBx_Modelo
            // 
            this.TxBx_Modelo.Location = new System.Drawing.Point(244, 218);
            this.TxBx_Modelo.Name = "TxBx_Modelo";
            this.TxBx_Modelo.Size = new System.Drawing.Size(166, 25);
            this.TxBx_Modelo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(5, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Serial:";
            // 
            // TxBx_Serial
            // 
            this.TxBx_Serial.Location = new System.Drawing.Point(64, 246);
            this.TxBx_Serial.Name = "TxBx_Serial";
            this.TxBx_Serial.Size = new System.Drawing.Size(172, 25);
            this.TxBx_Serial.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(6, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Contraseña:";
            // 
            // TxBx_Contrasena
            // 
            this.TxBx_Contrasena.Location = new System.Drawing.Point(100, 277);
            this.TxBx_Contrasena.Name = "TxBx_Contrasena";
            this.TxBx_Contrasena.Size = new System.Drawing.Size(144, 25);
            this.TxBx_Contrasena.TabIndex = 22;
            // 
            // RaBtn_BateriaSi
            // 
            this.RaBtn_BateriaSi.AutoSize = true;
            this.RaBtn_BateriaSi.Checked = true;
            this.RaBtn_BateriaSi.Location = new System.Drawing.Point(6, 22);
            this.RaBtn_BateriaSi.Name = "RaBtn_BateriaSi";
            this.RaBtn_BateriaSi.Size = new System.Drawing.Size(39, 21);
            this.RaBtn_BateriaSi.TabIndex = 23;
            this.RaBtn_BateriaSi.TabStop = true;
            this.RaBtn_BateriaSi.Text = "Si";
            this.RaBtn_BateriaSi.UseVisualStyleBackColor = true;
            // 
            // RaBtn_BateriaNo
            // 
            this.RaBtn_BateriaNo.AutoSize = true;
            this.RaBtn_BateriaNo.Location = new System.Drawing.Point(108, 24);
            this.RaBtn_BateriaNo.Name = "RaBtn_BateriaNo";
            this.RaBtn_BateriaNo.Size = new System.Drawing.Size(44, 21);
            this.RaBtn_BateriaNo.TabIndex = 24;
            this.RaBtn_BateriaNo.Text = "No";
            this.RaBtn_BateriaNo.UseVisualStyleBackColor = true;
            this.RaBtn_BateriaNo.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // dddd
            // 
            this.dddd.BackColor = System.Drawing.Color.Transparent;
            this.dddd.Controls.Add(this.RaBtn_BateriaNo);
            this.dddd.Controls.Add(this.RaBtn_BateriaSi);
            this.dddd.Location = new System.Drawing.Point(249, 249);
            this.dddd.Name = "dddd";
            this.dddd.Size = new System.Drawing.Size(159, 56);
            this.dddd.TabIndex = 34;
            this.dddd.TabStop = false;
            this.dddd.Text = "Bateria";
            this.dddd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Image = global::ReparacionTelefonos.Properties.Resources.watercolour_1336856_1280;
            this.label11.Location = new System.Drawing.Point(5, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(403, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "                               Caracteristicas de la Falla                       " +
    "  ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(12, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Falla del Dispositivo:";
            // 
            // RTxBx_FallaDisp
            // 
            this.RTxBx_FallaDisp.Location = new System.Drawing.Point(159, 333);
            this.RTxBx_FallaDisp.Name = "RTxBx_FallaDisp";
            this.RTxBx_FallaDisp.Size = new System.Drawing.Size(249, 82);
            this.RTxBx_FallaDisp.TabIndex = 25;
            this.RTxBx_FallaDisp.Text = "";
            this.RTxBx_FallaDisp.TextChanged += new System.EventHandler(this.RTxBx_FallaDisp_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(12, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Observaciones:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // RTxBx_Observacion
            // 
            this.RTxBx_Observacion.Location = new System.Drawing.Point(134, 421);
            this.RTxBx_Observacion.Name = "RTxBx_Observacion";
            this.RTxBx_Observacion.Size = new System.Drawing.Size(275, 82);
            this.RTxBx_Observacion.TabIndex = 26;
            this.RTxBx_Observacion.Text = "";
            // 
            // Lab_FechaEnt
            // 
            this.Lab_FechaEnt.AutoSize = true;
            this.Lab_FechaEnt.BackColor = System.Drawing.Color.Transparent;
            this.Lab_FechaEnt.Location = new System.Drawing.Point(12, 513);
            this.Lab_FechaEnt.Name = "Lab_FechaEnt";
            this.Lab_FechaEnt.Size = new System.Drawing.Size(126, 17);
            this.Lab_FechaEnt.TabIndex = 41;
            this.Lab_FechaEnt.Text = "Fecha de entrega:";
            this.Lab_FechaEnt.Visible = false;
            // 
            // DaTiPick_FechaEnt
            // 
            this.DaTiPick_FechaEnt.CustomFormat = "dd/MM/yyyy";
            this.DaTiPick_FechaEnt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DaTiPick_FechaEnt.Location = new System.Drawing.Point(134, 509);
            this.DaTiPick_FechaEnt.Name = "DaTiPick_FechaEnt";
            this.DaTiPick_FechaEnt.Size = new System.Drawing.Size(274, 25);
            this.DaTiPick_FechaEnt.TabIndex = 27;
            this.DaTiPick_FechaEnt.Visible = false;
            this.DaTiPick_FechaEnt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(305, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Revision$:";
            // 
            // TxBx_Revision
            // 
            this.TxBx_Revision.Location = new System.Drawing.Point(305, 557);
            this.TxBx_Revision.Name = "TxBx_Revision";
            this.TxBx_Revision.Size = new System.Drawing.Size(103, 25);
            this.TxBx_Revision.TabIndex = 36;
            this.TxBx_Revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxBx_Revision.TextChanged += new System.EventHandler(this.TxBx_Revision_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(302, 637);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "Total a Pagar $:";
            // 
            // TxBx_TotalPagar
            // 
            this.TxBx_TotalPagar.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxBx_TotalPagar.Location = new System.Drawing.Point(305, 654);
            this.TxBx_TotalPagar.Name = "TxBx_TotalPagar";
            this.TxBx_TotalPagar.ReadOnly = true;
            this.TxBx_TotalPagar.Size = new System.Drawing.Size(103, 46);
            this.TxBx_TotalPagar.TabIndex = 46;
            this.TxBx_TotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxBx_TotalPagar.TextChanged += new System.EventHandler(this.TxBx_TotalPagar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RaBtn_Pendiente);
            this.groupBox1.Controls.Add(this.RaBtn_Entregado);
            this.groupBox1.Location = new System.Drawing.Point(12, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 111);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // RaBtn_Pendiente
            // 
            this.RaBtn_Pendiente.AutoSize = true;
            this.RaBtn_Pendiente.Checked = true;
            this.RaBtn_Pendiente.Location = new System.Drawing.Point(190, 45);
            this.RaBtn_Pendiente.Name = "RaBtn_Pendiente";
            this.RaBtn_Pendiente.Size = new System.Drawing.Size(91, 21);
            this.RaBtn_Pendiente.TabIndex = 29;
            this.RaBtn_Pendiente.TabStop = true;
            this.RaBtn_Pendiente.Text = "Pendiente";
            this.RaBtn_Pendiente.UseVisualStyleBackColor = true;
            this.RaBtn_Pendiente.CheckedChanged += new System.EventHandler(this.RaBtn_Pendiente_CheckedChanged);
            // 
            // RaBtn_Entregado
            // 
            this.RaBtn_Entregado.AutoSize = true;
            this.RaBtn_Entregado.Location = new System.Drawing.Point(6, 45);
            this.RaBtn_Entregado.Name = "RaBtn_Entregado";
            this.RaBtn_Entregado.Size = new System.Drawing.Size(93, 21);
            this.RaBtn_Entregado.TabIndex = 30;
            this.RaBtn_Entregado.Text = "Entregado";
            this.RaBtn_Entregado.UseVisualStyleBackColor = true;
            this.RaBtn_Entregado.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(306, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(320, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 48;
            this.label17.Text = "Nro.";
            // 
            // TxBxNro
            // 
            this.TxBxNro.AcceptsReturn = true;
            this.TxBxNro.Location = new System.Drawing.Point(362, 54);
            this.TxBxNro.Name = "TxBxNro";
            this.TxBxNro.ReadOnly = true;
            this.TxBxNro.Size = new System.Drawing.Size(46, 25);
            this.TxBxNro.TabIndex = 11;
            this.TxBxNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxBxNro.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(305, 589);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 17);
            this.label18.TabIndex = 50;
            this.label18.Text = "Reparacion $:";
            // 
            // TxBx_Reparacion
            // 
            this.TxBx_Reparacion.Location = new System.Drawing.Point(305, 609);
            this.TxBx_Reparacion.Name = "TxBx_Reparacion";
            this.TxBx_Reparacion.Size = new System.Drawing.Size(103, 25);
            this.TxBx_Reparacion.TabIndex = 28;
            this.TxBx_Reparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxBx_Reparacion.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // BtnGuardarInf
            // 
            this.BtnGuardarInf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardarInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardarInf.Location = new System.Drawing.Point(12, 654);
            this.BtnGuardarInf.Name = "BtnGuardarInf";
            this.BtnGuardarInf.Size = new System.Drawing.Size(287, 95);
            this.BtnGuardarInf.TabIndex = 31;
            this.BtnGuardarInf.Text = "Guardar Informacion";
            this.BtnGuardarInf.UseVisualStyleBackColor = false;
            this.BtnGuardarInf.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.RaBtn_Telefono);
            this.groupBox2.Controls.Add(this.RaBtn_Tablet);
            this.groupBox2.Controls.Add(this.RaBtn_Otro);
            this.groupBox2.Controls.Add(this.TxBx_Otro);
            this.groupBox2.Location = new System.Drawing.Point(6, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 50);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispositivo";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::ReparacionTelefonos.Properties.Resources.color_1909977_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnGuardarInf);
            this.Controls.Add(this.TxBx_Reparacion);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxBxNro);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxBx_TotalPagar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxBx_Revision);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DaTiPick_FechaEnt);
            this.Controls.Add(this.Lab_FechaEnt);
            this.Controls.Add(this.RTxBx_Observacion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RTxBx_FallaDisp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dddd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxBx_Contrasena);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxBx_Serial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxBx_Modelo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxBx_Marca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxBxTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxBxCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxBxDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxBxNombreAp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab_InfoClient);
            this.Controls.Add(this.Lab1Bienvenido);
            this.Controls.Add(this.Lab3Bienvenido);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 800);
            this.MinimumSize = new System.Drawing.Size(430, 800);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rephonedrag - Formulario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.dddd.ResumeLayout(false);
            this.dddd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lab3Bienvenido;
        private System.Windows.Forms.Label Lab1Bienvenido;
        private System.Windows.Forms.Label Lab_InfoClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxBxNombreAp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxBxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxBxCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxBxTelefono;
        private System.Windows.Forms.RadioButton RaBtn_Telefono;
        private System.Windows.Forms.RadioButton RaBtn_Tablet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RaBtn_Otro;
        private System.Windows.Forms.TextBox TxBx_Otro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxBx_Marca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxBx_Modelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxBx_Serial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxBx_Contrasena;
        private System.Windows.Forms.RadioButton RaBtn_BateriaSi;
        private System.Windows.Forms.RadioButton RaBtn_BateriaNo;
        private System.Windows.Forms.GroupBox dddd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox RTxBx_FallaDisp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox RTe;
        private System.Windows.Forms.Label Lab_FechaEnt;
        private System.Windows.Forms.DateTimePicker DaTiPick_FechaEnt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxBx_Revision;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxBx_TotalPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RaBtn_Pendiente;
        private System.Windows.Forms.RadioButton RaBtn_Entregado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxBxNro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxBx_Reparacion;
        private System.Windows.Forms.Button BtnGuardarInf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RTxBx_Observacion;
    }
}