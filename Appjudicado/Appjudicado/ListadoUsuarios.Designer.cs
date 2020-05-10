namespace Appjudicado
{
    partial class ListadoUsuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lUsuario = new System.Windows.Forms.Label();
            this.lPais = new System.Windows.Forms.Label();
            this.lLocalidad = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lCp = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.bEditar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(38, 22);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(43, 13);
            this.lUsuario.TabIndex = 0;
            this.lUsuario.Text = "Usuario";
            // 
            // lPais
            // 
            this.lPais.AutoSize = true;
            this.lPais.Location = new System.Drawing.Point(290, 31);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(27, 13);
            this.lPais.TabIndex = 1;
            this.lPais.Text = "Pais";
            // 
            // lLocalidad
            // 
            this.lLocalidad.AutoSize = true;
            this.lLocalidad.Location = new System.Drawing.Point(290, 68);
            this.lLocalidad.Name = "lLocalidad";
            this.lLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lLocalidad.TabIndex = 2;
            this.lLocalidad.Text = "Localidad";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(38, 68);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(32, 13);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email";
            // 
            // lCp
            // 
            this.lCp.AutoSize = true;
            this.lCp.Location = new System.Drawing.Point(290, 111);
            this.lCp.Name = "lCp";
            this.lCp.Size = new System.Drawing.Size(72, 13);
            this.lCp.TabIndex = 4;
            this.lCp.Text = "Código Postal";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(38, 111);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(52, 13);
            this.lDireccion.TabIndex = 5;
            this.lDireccion.Text = "Dirección";
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(592, 87);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 6;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(592, 116);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.lCp);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lLocalidad);
            this.Controls.Add(this.lPais);
            this.Controls.Add(this.lUsuario);
            this.Name = "ListadoUsuarios";
            this.Size = new System.Drawing.Size(680, 150);
            this.Load += new System.EventHandler(this.ListadoUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lPais;
        private System.Windows.Forms.Label lLocalidad;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lCp;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bEliminar;
    }
}
