namespace appPaqueteria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEnvio = new System.Windows.Forms.ComboBox();
            this.calcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.notificaciones = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione las opciones que deseé para notificarle\r\n";
            // 
            // comboBoxEnvio
            // 
            this.comboBoxEnvio.BackColor = System.Drawing.Color.White;
            this.comboBoxEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEnvio.FormattingEnabled = true;
            this.comboBoxEnvio.Items.AddRange(new object[] {
            "Correo normal 0,99 €",
            "Paquetería normal 1,99€",
            "Paquetería urgente 4,99€"});
            this.comboBoxEnvio.Location = new System.Drawing.Point(120, 59);
            this.comboBoxEnvio.Name = "comboBoxEnvio";
            this.comboBoxEnvio.Size = new System.Drawing.Size(189, 28);
            this.comboBoxEnvio.TabIndex = 2;
            this.comboBoxEnvio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // calcular
            // 
            this.calcular.Image = global::appPaqueteria.Properties.Resources.calcularprecio;
            this.calcular.Location = new System.Drawing.Point(21, 268);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(319, 67);
            this.calcular.TabIndex = 4;
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appPaqueteria.Properties.Resources.metodoEnvio;
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(51, 396);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(258, 29);
            this.resultado.TabIndex = 5;
            // 
            // notificaciones
            // 
            this.notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificaciones.FormattingEnabled = true;
            this.notificaciones.Items.AddRange(new object[] {
            "Email Gratis",
            "Teléfono SMS 0,63 €",
            "Fax 1,68 €"});
            this.notificaciones.Location = new System.Drawing.Point(75, 152);
            this.notificaciones.Name = "notificaciones";
            this.notificaciones.Size = new System.Drawing.Size(199, 67);
            this.notificaciones.TabIndex = 3;
            this.notificaciones.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.notificaciones);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.comboBoxEnvio);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aplicacion de envio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.ComboBox comboBoxEnvio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.CheckedListBox notificaciones;
    }
}

