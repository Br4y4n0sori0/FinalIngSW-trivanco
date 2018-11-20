namespace sucursal
{
    partial class movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movimientos));
            this.btatras = new System.Windows.Forms.Button();
            this.btmovimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btatras
            // 
            this.btatras.BackColor = System.Drawing.Color.MediumPurple;
            this.btatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btatras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btatras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btatras.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatras.ForeColor = System.Drawing.Color.Black;
            this.btatras.Location = new System.Drawing.Point(299, 324);
            this.btatras.Margin = new System.Windows.Forms.Padding(0);
            this.btatras.Name = "btatras";
            this.btatras.Size = new System.Drawing.Size(153, 40);
            this.btatras.TabIndex = 14;
            this.btatras.Text = "Atrás";
            this.btatras.UseVisualStyleBackColor = false;
            this.btatras.Click += new System.EventHandler(this.btatras_Click);
            // 
            // btmovimientos
            // 
            this.btmovimientos.BackColor = System.Drawing.Color.MediumPurple;
            this.btmovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmovimientos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btmovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmovimientos.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmovimientos.ForeColor = System.Drawing.Color.Black;
            this.btmovimientos.Location = new System.Drawing.Point(65, 324);
            this.btmovimientos.Margin = new System.Windows.Forms.Padding(0);
            this.btmovimientos.Name = "btmovimientos";
            this.btmovimientos.Size = new System.Drawing.Size(153, 40);
            this.btmovimientos.TabIndex = 15;
            this.btmovimientos.Text = "Mostrar";
            this.btmovimientos.UseVisualStyleBackColor = false;
            // 
            // movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.btmovimientos);
            this.Controls.Add(this.btatras);
            this.Name = "movimientos";
            this.Text = " Mostrar Movimientos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.movimientos_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btatras;
        private System.Windows.Forms.Button btmovimientos;
    }
}