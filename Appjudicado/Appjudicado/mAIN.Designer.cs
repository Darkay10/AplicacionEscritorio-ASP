namespace Appjudicado
{
    partial class Main
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
            this.button_crear = new System.Windows.Forms.Button();
            this.button_subastas_lista = new System.Windows.Forms.Button();
            this.button_perfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(213, 124);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(145, 23);
            this.button_crear.TabIndex = 0;
            this.button_crear.Text = "CREAR SUBASTA";
            this.button_crear.UseVisualStyleBackColor = true;
            // 
            // button_subastas_lista
            // 
            this.button_subastas_lista.Location = new System.Drawing.Point(213, 187);
            this.button_subastas_lista.Name = "button_subastas_lista";
            this.button_subastas_lista.Size = new System.Drawing.Size(145, 23);
            this.button_subastas_lista.TabIndex = 1;
            this.button_subastas_lista.Text = "lista subastas";
            this.button_subastas_lista.UseVisualStyleBackColor = true;
            // 
            // button_perfil
            // 
            this.button_perfil.Location = new System.Drawing.Point(665, 22);
            this.button_perfil.Name = "button_perfil";
            this.button_perfil.Size = new System.Drawing.Size(75, 23);
            this.button_perfil.TabIndex = 2;
            this.button_perfil.Text = "Usuario";
            this.button_perfil.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_perfil);
            this.Controls.Add(this.button_subastas_lista);
            this.Controls.Add(this.button_crear);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_subastas_lista;
        private System.Windows.Forms.Button button_perfil;
    }
}

