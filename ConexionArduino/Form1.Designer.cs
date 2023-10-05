namespace ConexionArduino
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
            this.components = new System.ComponentModel.Container();
            this.butConectar = new System.Windows.Forms.Button();
            this.butDesconectar = new System.Windows.Forms.Button();
            this.listMensajes = new System.Windows.Forms.ListBox();
            this.puertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // butConectar
            // 
            this.butConectar.Location = new System.Drawing.Point(166, 12);
            this.butConectar.Name = "butConectar";
            this.butConectar.Size = new System.Drawing.Size(100, 30);
            this.butConectar.TabIndex = 0;
            this.butConectar.Text = "CONECTAR";
            this.butConectar.UseVisualStyleBackColor = true;
            this.butConectar.Click += new System.EventHandler(this.butConectar_Click);
            // 
            // butDesconectar
            // 
            this.butDesconectar.Location = new System.Drawing.Point(272, 12);
            this.butDesconectar.Name = "butDesconectar";
            this.butDesconectar.Size = new System.Drawing.Size(100, 30);
            this.butDesconectar.TabIndex = 1;
            this.butDesconectar.Text = "DESCONECTAR";
            this.butDesconectar.UseVisualStyleBackColor = true;
            this.butDesconectar.Click += new System.EventHandler(this.butDesconectar_Click);
            // 
            // listMensajes
            // 
            this.listMensajes.FormattingEnabled = true;
            this.listMensajes.Location = new System.Drawing.Point(12, 77);
            this.listMensajes.Name = "listMensajes";
            this.listMensajes.Size = new System.Drawing.Size(360, 264);
            this.listMensajes.TabIndex = 2;
            // 
            // puertoSerie
            // 
            this.puertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.puertoSerie_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.listMensajes);
            this.Controls.Add(this.butDesconectar);
            this.Controls.Add(this.butConectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butConectar;
        private System.Windows.Forms.Button butDesconectar;
        private System.Windows.Forms.ListBox listMensajes;
        private System.IO.Ports.SerialPort puertoSerie;
    }
}

