namespace Appjudicado
{
    partial class SubastaCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_publicar = new System.Windows.Forms.Button();
            this.textbox_articulo = new System.Windows.Forms.TextBox();
            this.textbox_precio = new System.Windows.Forms.TextBox();
            this.textbox_descripcion = new System.Windows.Forms.TextBox();
            this.listbox_duracion = new System.Windows.Forms.ListBox();
            this.openimagen = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.button_openfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // button_publicar
            // 
            this.button_publicar.Location = new System.Drawing.Point(299, 317);
            this.button_publicar.Name = "button_publicar";
            this.button_publicar.Size = new System.Drawing.Size(238, 121);
            this.button_publicar.TabIndex = 4;
            this.button_publicar.Text = "PUBLICAR";
            this.button_publicar.UseVisualStyleBackColor = true;
            // 
            // textbox_articulo
            // 
            this.textbox_articulo.Location = new System.Drawing.Point(398, 104);
            this.textbox_articulo.Name = "textbox_articulo";
            this.textbox_articulo.Size = new System.Drawing.Size(100, 20);
            this.textbox_articulo.TabIndex = 5;
            // 
            // textbox_precio
            // 
            this.textbox_precio.Location = new System.Drawing.Point(425, 208);
            this.textbox_precio.Name = "textbox_precio";
            this.textbox_precio.Size = new System.Drawing.Size(100, 20);
            this.textbox_precio.TabIndex = 6;
            // 
            // textbox_descripcion
            // 
            this.textbox_descripcion.Location = new System.Drawing.Point(425, 234);
            this.textbox_descripcion.Name = "textbox_descripcion";
            this.textbox_descripcion.Size = new System.Drawing.Size(100, 20);
            this.textbox_descripcion.TabIndex = 7;
            // 
            // listbox_duracion
            // 
            this.listbox_duracion.FormattingEnabled = true;
            this.listbox_duracion.Items.AddRange(new object[] {
            "4 horas",
            "8 horas",
            "12 horas",
            "1 día",
            "3 días"});
            this.listbox_duracion.Location = new System.Drawing.Point(398, 130);
            this.listbox_duracion.Name = "listbox_duracion";
            this.listbox_duracion.Size = new System.Drawing.Size(109, 69);
            this.listbox_duracion.TabIndex = 8;
            // 
            // openimagen
            // 
            this.openimagen.FileName = "openFileDialog1";
            this.openimagen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IMAGEN";
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(422, 283);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(75, 23);
            this.button_openfile.TabIndex = 10;
            this.button_openfile.Text = "button1";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // SubastaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_openfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listbox_duracion);
            this.Controls.Add(this.textbox_descripcion);
            this.Controls.Add(this.textbox_precio);
            this.Controls.Add(this.textbox_articulo);
            this.Controls.Add(this.button_publicar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubastaCreate";
            this.Text = "SubastaCreate";
            this.Load += new System.EventHandler(this.SubastaCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_publicar;
        private System.Windows.Forms.TextBox textbox_articulo;
        private System.Windows.Forms.TextBox textbox_precio;
        private System.Windows.Forms.TextBox textbox_descripcion;
        private System.Windows.Forms.ListBox listbox_duracion;
        private System.Windows.Forms.OpenFileDialog openimagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_openfile;
    }
}