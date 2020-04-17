namespace Appjudicado
{
    partial class PanelAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button_subastas = new System.Windows.Forms.Button();
            this.button_usuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_subastas
            // 
            this.button_subastas.Location = new System.Drawing.Point(175, 168);
            this.button_subastas.Name = "button_subastas";
            this.button_subastas.Size = new System.Drawing.Size(75, 23);
            this.button_subastas.TabIndex = 0;
            this.button_subastas.Text = "SUBASTAS";
            this.button_subastas.UseVisualStyleBackColor = true;
            // 
            // button_usuarios
            // 
            this.button_usuarios.Location = new System.Drawing.Point(393, 168);
            this.button_usuarios.Name = "button_usuarios";
            this.button_usuarios.Size = new System.Drawing.Size(75, 23);
            this.button_usuarios.TabIndex = 1;
            this.button_usuarios.Text = "USUARIOS";
            this.button_usuarios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMINISTRACIÓN";
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_usuarios);
            this.Controls.Add(this.button_subastas);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_subastas;
        private System.Windows.Forms.Button button_usuarios;
        private System.Windows.Forms.Label label1;
    }
}