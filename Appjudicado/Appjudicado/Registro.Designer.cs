namespace Appjudicado
{
    partial class Registro
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
            this.button_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_user = new System.Windows.Forms.TextBox();
            this.textbox_pass = new System.Windows.Forms.TextBox();
            this.textbox_direccion = new System.Windows.Forms.TextBox();
            this.textbox_codigo_postal = new System.Windows.Forms.TextBox();
            this.textbox_localidad = new System.Windows.Forms.TextBox();
            this.textbox_pais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(265, 360);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(194, 57);
            this.button_register.TabIndex = 0;
            this.button_register.Text = "REGISTRARSE";
            this.button_register.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CODIGO POSTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "LOCALIDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "PAIS";
            // 
            // textbox_user
            // 
            this.textbox_user.Location = new System.Drawing.Point(364, 100);
            this.textbox_user.Name = "textbox_user";
            this.textbox_user.Size = new System.Drawing.Size(100, 20);
            this.textbox_user.TabIndex = 7;
            // 
            // textbox_pass
            // 
            this.textbox_pass.Location = new System.Drawing.Point(369, 141);
            this.textbox_pass.Name = "textbox_pass";
            this.textbox_pass.Size = new System.Drawing.Size(100, 20);
            this.textbox_pass.TabIndex = 8;
            // 
            // textbox_direccion
            // 
            this.textbox_direccion.Location = new System.Drawing.Point(370, 184);
            this.textbox_direccion.Name = "textbox_direccion";
            this.textbox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textbox_direccion.TabIndex = 9;
            // 
            // textbox_codigo_postal
            // 
            this.textbox_codigo_postal.Location = new System.Drawing.Point(378, 225);
            this.textbox_codigo_postal.Name = "textbox_codigo_postal";
            this.textbox_codigo_postal.Size = new System.Drawing.Size(100, 20);
            this.textbox_codigo_postal.TabIndex = 10;
            // 
            // textbox_localidad
            // 
            this.textbox_localidad.Location = new System.Drawing.Point(391, 268);
            this.textbox_localidad.Name = "textbox_localidad";
            this.textbox_localidad.Size = new System.Drawing.Size(100, 20);
            this.textbox_localidad.TabIndex = 11;
            // 
            // textbox_pais
            // 
            this.textbox_pais.Location = new System.Drawing.Point(392, 308);
            this.textbox_pais.Name = "textbox_pais";
            this.textbox_pais.Size = new System.Drawing.Size(100, 20);
            this.textbox_pais.TabIndex = 12;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox_pais);
            this.Controls.Add(this.textbox_localidad);
            this.Controls.Add(this.textbox_codigo_postal);
            this.Controls.Add(this.textbox_direccion);
            this.Controls.Add(this.textbox_pass);
            this.Controls.Add(this.textbox_user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_register);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_user;
        private System.Windows.Forms.TextBox textbox_pass;
        private System.Windows.Forms.TextBox textbox_direccion;
        private System.Windows.Forms.TextBox textbox_codigo_postal;
        private System.Windows.Forms.TextBox textbox_localidad;
        private System.Windows.Forms.TextBox textbox_pais;
    }
}