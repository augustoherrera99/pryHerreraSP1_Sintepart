namespace pryHerreraSP1_Sintepart
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(30, 73);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(31, 109);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(42, 13);
            this.lblModulo.TabIndex = 2;
            this.lblModulo.Text = "Módulo";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUsuario.Location = new System.Drawing.Point(99, 37);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(114, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(99, 71);
            this.txtContrasena.MaxLength = 10;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '#';
            this.txtContrasena.Size = new System.Drawing.Size(114, 20);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.cmbModulo.Location = new System.Drawing.Point(99, 109);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(114, 21);
            this.cmbModulo.TabIndex = 5;
            this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.cmbModulo_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(268, 35);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 158);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

