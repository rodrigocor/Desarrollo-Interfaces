namespace loginPassword
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLoggin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btInicioSesion = new System.Windows.Forms.Button();
            this.btCrearCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLoggin
            // 
            this.tbLoggin.Location = new System.Drawing.Point(75, 124);
            this.tbLoggin.Name = "tbLoggin";
            this.tbLoggin.Size = new System.Drawing.Size(100, 20);
            this.tbLoggin.TabIndex = 0;
            this.tbLoggin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(75, 231);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btInicioSesion
            // 
            this.btInicioSesion.Location = new System.Drawing.Point(75, 319);
            this.btInicioSesion.Name = "btInicioSesion";
            this.btInicioSesion.Size = new System.Drawing.Size(100, 28);
            this.btInicioSesion.TabIndex = 2;
            this.btInicioSesion.Text = "Iniciar sesión";
            this.btInicioSesion.UseVisualStyleBackColor = true;
            this.btInicioSesion.Click += new System.EventHandler(this.iniciarSesion);
            // 
            // btCrearCuenta
            // 
            this.btCrearCuenta.Location = new System.Drawing.Point(75, 319);
            this.btCrearCuenta.Name = "btCrearCuenta";
            this.btCrearCuenta.Size = new System.Drawing.Size(100, 28);
            this.btCrearCuenta.TabIndex = 3;
            this.btCrearCuenta.Text = "Crear Cuenta";
            this.btCrearCuenta.UseVisualStyleBackColor = true;
            this.btCrearCuenta.Click += new System.EventHandler(this.CrearCuenta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduzca el nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduzca la contraseña de usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCrearCuenta);
            this.Controls.Add(this.btInicioSesion);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLoggin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoggin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btInicioSesion;
        private System.Windows.Forms.Button btCrearCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

