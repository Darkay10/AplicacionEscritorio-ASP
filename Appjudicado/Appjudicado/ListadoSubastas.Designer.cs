namespace Appjudicado
{
    partial class ListadoSubastas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoSubastas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lArticulo = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.bDelPuja = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lArticulo
            // 
            this.lArticulo.AutoSize = true;
            this.lArticulo.Location = new System.Drawing.Point(177, 23);
            this.lArticulo.Name = "lArticulo";
            this.lArticulo.Size = new System.Drawing.Size(42, 13);
            this.lArticulo.TabIndex = 1;
            this.lArticulo.Text = "Articulo";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(177, 66);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 2;
            this.lCategoria.Text = "Categoria";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(351, 23);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 3;
            this.lDescripcion.Text = "Descripcion";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(351, 108);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "Precio";
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Location = new System.Drawing.Point(177, 108);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(51, 13);
            this.lFechaFin.TabIndex = 5;
            this.lFechaFin.Text = "Fecha fin";
            // 
            // bDelPuja
            // 
            this.bDelPuja.Location = new System.Drawing.Point(589, 53);
            this.bDelPuja.Name = "bDelPuja";
            this.bDelPuja.Size = new System.Drawing.Size(75, 39);
            this.bDelPuja.TabIndex = 8;
            this.bDelPuja.Text = "Pujar o eliminar";
            this.bDelPuja.UseVisualStyleBackColor = true;
            this.bDelPuja.Click += new System.EventHandler(this.bDelPuja_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(589, 95);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(75, 39);
            this.bVer.TabIndex = 9;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // ListadoSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bDelPuja);
            this.Controls.Add(this.lFechaFin);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListadoSubastas";
            this.Size = new System.Drawing.Size(680, 150);
            this.Load += new System.EventHandler(this.ListadoSubastas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lArticulo;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.Button bDelPuja;
        private System.Windows.Forms.Button bVer;
    }
}
