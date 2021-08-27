
namespace ReparacionTelefonos
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txbx1Usuario = new System.Windows.Forms.TextBox();
            this.txbx2Contrasena = new System.Windows.Forms.TextBox();
            this.lab2Contrasena = new System.Windows.Forms.Label();
            this.btn1Ingresar = new System.Windows.Forms.Button();
            this.pictbxUsuario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab1Usuario = new System.Windows.Forms.Label();
            this.Btn2Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx1Usuario
            // 
            this.txbx1Usuario.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.txbx1Usuario, "txbx1Usuario");
            this.txbx1Usuario.Name = "txbx1Usuario";
            this.txbx1Usuario.TextChanged += new System.EventHandler(this.txbx1Usuario_TextChanged);
            // 
            // txbx2Contrasena
            // 
            this.txbx2Contrasena.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.txbx2Contrasena, "txbx2Contrasena");
            this.txbx2Contrasena.Name = "txbx2Contrasena";
            this.txbx2Contrasena.UseSystemPasswordChar = true;
            this.txbx2Contrasena.TextChanged += new System.EventHandler(this.txbx2Contrasena_TextChanged);
            // 
            // lab2Contrasena
            // 
            resources.ApplyResources(this.lab2Contrasena, "lab2Contrasena");
            this.lab2Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.lab2Contrasena.Name = "lab2Contrasena";
            this.lab2Contrasena.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btn1Ingresar
            // 
            this.btn1Ingresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn1Ingresar, "btn1Ingresar");
            this.btn1Ingresar.Name = "btn1Ingresar";
            this.btn1Ingresar.UseVisualStyleBackColor = false;
            this.btn1Ingresar.Click += new System.EventHandler(this.btn1Ingresar_Click);
            // 
            // pictbxUsuario
            // 
            this.pictbxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pictbxUsuario.BackgroundImage = global::ReparacionTelefonos.Properties.Resources.user_2935373_1280;
            resources.ApplyResources(this.pictbxUsuario, "pictbxUsuario");
            this.pictbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictbxUsuario.Name = "pictbxUsuario";
            this.pictbxUsuario.TabStop = false;
            this.pictbxUsuario.Click += new System.EventHandler(this.pictbxUsuario_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // Lab1Usuario
            // 
            resources.ApplyResources(this.Lab1Usuario, "Lab1Usuario");
            this.Lab1Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lab1Usuario.Name = "Lab1Usuario";
            // 
            // Btn2Salir
            // 
            this.Btn2Salir.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn2Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Btn2Salir, "Btn2Salir");
            this.Btn2Salir.Name = "Btn2Salir";
            this.Btn2Salir.UseVisualStyleBackColor = false;
            this.Btn2Salir.Click += new System.EventHandler(this.Btn2Salir_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::ReparacionTelefonos.Properties.Resources.watercolour_1336856_1280;
            this.Controls.Add(this.Btn2Salir);
            this.Controls.Add(this.Lab1Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictbxUsuario);
            this.Controls.Add(this.btn1Ingresar);
            this.Controls.Add(this.lab2Contrasena);
            this.Controls.Add(this.txbx2Contrasena);
            this.Controls.Add(this.txbx1Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictbxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx1Usuario;
        private System.Windows.Forms.TextBox txbx2Contrasena;
        private System.Windows.Forms.Label lab2Contrasena;
        private System.Windows.Forms.Button btn1Ingresar;
        private System.Windows.Forms.PictureBox pictbxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab1Usuario;
        private System.Windows.Forms.Button Btn2Salir;
    }
}

