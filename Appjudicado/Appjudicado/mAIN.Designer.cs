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
            this.bCrear = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.bAdmin = new System.Windows.Forms.Button();
            this.lTexto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCrear
            // 
            this.bCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bCrear.Location = new System.Drawing.Point(12, 74);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(99, 58);
            this.bCrear.TabIndex = 0;
            this.bCrear.Text = "Crear subasta";
            this.bCrear.UseVisualStyleBackColor = true;
            // 
            // bListar
            // 
            this.bListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bListar.Location = new System.Drawing.Point(12, 138);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(99, 57);
            this.bListar.TabIndex = 1;
            this.bListar.Text = "Ver subastas";
            this.bListar.UseVisualStyleBackColor = true;
            // 
            // bPerfil
            // 
            this.bPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bPerfil.Location = new System.Drawing.Point(12, 11);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(99, 57);
            this.bPerfil.TabIndex = 2;
            this.bPerfil.Text = "Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            // 
            // bAdmin
            // 
            this.bAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAdmin.Location = new System.Drawing.Point(11, 264);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(100, 57);
            this.bAdmin.TabIndex = 3;
            this.bAdmin.Text = "Administrar usuarios";
            this.bAdmin.UseVisualStyleBackColor = true;
            // 
            // lTexto
            // 
            this.lTexto.AutoSize = true;
            this.lTexto.Location = new System.Drawing.Point(12, 391);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(30, 13);
            this.lTexto.TabIndex = 4;
            this.lTexto.Text = "texto";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(11, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mis subastas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lTexto);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bCrear);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.Label lTexto;
        private System.Windows.Forms.Button button1;
    }
}

