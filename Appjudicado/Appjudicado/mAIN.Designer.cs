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
            this.bMisSubastas = new System.Windows.Forms.Button();
            this.panelDeControl = new System.Windows.Forms.FlowLayoutPanel();
            this.bMisPujas = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
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
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
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
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
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
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // bAdmin
            // 
            this.bAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAdmin.Location = new System.Drawing.Point(11, 327);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(100, 57);
            this.bAdmin.TabIndex = 3;
            this.bAdmin.Text = "Administrar usuarios";
            this.bAdmin.UseVisualStyleBackColor = true;
            this.bAdmin.Visible = false;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // bMisSubastas
            // 
            this.bMisSubastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bMisSubastas.Location = new System.Drawing.Point(11, 201);
            this.bMisSubastas.Name = "bMisSubastas";
            this.bMisSubastas.Size = new System.Drawing.Size(100, 57);
            this.bMisSubastas.TabIndex = 5;
            this.bMisSubastas.Text = "Mis subastas";
            this.bMisSubastas.UseVisualStyleBackColor = true;
            this.bMisSubastas.Click += new System.EventHandler(this.bMisSubastas_Click);
            // 
            // panelDeControl
            // 
            this.panelDeControl.AutoScroll = true;
            this.panelDeControl.Location = new System.Drawing.Point(120, 5);
            this.panelDeControl.Name = "panelDeControl";
            this.panelDeControl.Size = new System.Drawing.Size(710, 459);
            this.panelDeControl.TabIndex = 6;
            // 
            // bMisPujas
            // 
            this.bMisPujas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bMisPujas.Location = new System.Drawing.Point(11, 264);
            this.bMisPujas.Name = "bMisPujas";
            this.bMisPujas.Size = new System.Drawing.Size(100, 57);
            this.bMisPujas.TabIndex = 7;
            this.bMisPujas.Text = "Mis pujas";
            this.bMisPujas.UseVisualStyleBackColor = true;
            this.bMisPujas.Click += new System.EventHandler(this.bMisPujas_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(12, 441);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(99, 23);
            this.bActualizar.TabIndex = 8;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Visible = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 471);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bMisPujas);
            this.Controls.Add(this.panelDeControl);
            this.Controls.Add(this.bMisSubastas);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bCrear);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.Button bMisSubastas;
        private System.Windows.Forms.FlowLayoutPanel panelDeControl;
        private System.Windows.Forms.Button bMisPujas;
        private System.Windows.Forms.Button bActualizar;
    }
}

