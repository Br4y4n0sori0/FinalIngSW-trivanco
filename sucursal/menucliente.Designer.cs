namespace sucursal
{
    partial class menucliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menucliente));
            this.btcerrar = new System.Windows.Forms.Button();
            this.btmovimientos = new System.Windows.Forms.Button();
            this.bttransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcerrar
            // 
            this.btcerrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcerrar.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrar.ForeColor = System.Drawing.Color.Black;
            this.btcerrar.Location = new System.Drawing.Point(151, 315);
            this.btcerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(206, 43);
            this.btcerrar.TabIndex = 7;
            this.btcerrar.Text = "Cerrar sesión";
            this.btcerrar.UseVisualStyleBackColor = false;
            this.btcerrar.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // btmovimientos
            // 
            this.btmovimientos.BackColor = System.Drawing.Color.MediumPurple;
            this.btmovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmovimientos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btmovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmovimientos.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmovimientos.ForeColor = System.Drawing.Color.Black;
            this.btmovimientos.Location = new System.Drawing.Point(151, 254);
            this.btmovimientos.Margin = new System.Windows.Forms.Padding(0);
            this.btmovimientos.Name = "btmovimientos";
            this.btmovimientos.Size = new System.Drawing.Size(206, 43);
            this.btmovimientos.TabIndex = 8;
            this.btmovimientos.Text = "Movimientos";
            this.btmovimientos.UseVisualStyleBackColor = false;
            this.btmovimientos.Click += new System.EventHandler(this.btmovimientos_Click);
            // 
            // bttransfer
            // 
            this.bttransfer.BackColor = System.Drawing.Color.MediumPurple;
            this.bttransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttransfer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bttransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttransfer.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttransfer.ForeColor = System.Drawing.Color.Black;
            this.bttransfer.Location = new System.Drawing.Point(151, 189);
            this.bttransfer.Margin = new System.Windows.Forms.Padding(0);
            this.bttransfer.Name = "bttransfer";
            this.bttransfer.Size = new System.Drawing.Size(206, 43);
            this.bttransfer.TabIndex = 9;
            this.bttransfer.Text = "Transferencia";
            this.bttransfer.UseVisualStyleBackColor = false;
            this.bttransfer.Click += new System.EventHandler(this.bttransfer_Click);
            // 
            // menucliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 366);
            this.Controls.Add(this.bttransfer);
            this.Controls.Add(this.btmovimientos);
            this.Controls.Add(this.btcerrar);
            this.MaximizeBox = false;
            this.Name = "menucliente";
            this.Text = "Menú del cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menucliente_FormClosed);
            this.Load += new System.EventHandler(this.menucliente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btcerrar;
        private System.Windows.Forms.Button btmovimientos;
        private System.Windows.Forms.Button bttransfer;
    }
}