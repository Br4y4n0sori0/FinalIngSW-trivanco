namespace sucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbcont = new System.Windows.Forms.TextBox();
            this.btingresar = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbuser
            // 
            this.tbuser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbuser.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(150, 165);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(220, 39);
            this.tbuser.TabIndex = 2;
            // 
            // tbcont
            // 
            this.tbcont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcont.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcont.Location = new System.Drawing.Point(157, 246);
            this.tbcont.Name = "tbcont";
            this.tbcont.Size = new System.Drawing.Size(213, 39);
            this.tbcont.TabIndex = 3;
            this.tbcont.UseSystemPasswordChar = true;
            // 
            // btingresar
            // 
            this.btingresar.BackColor = System.Drawing.Color.MediumPurple;
            this.btingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btingresar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btingresar.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingresar.ForeColor = System.Drawing.Color.Black;
            this.btingresar.Location = new System.Drawing.Point(109, 314);
            this.btingresar.Margin = new System.Windows.Forms.Padding(0);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(131, 44);
            this.btingresar.TabIndex = 4;
            this.btingresar.Text = "Ingresar";
            this.btingresar.UseVisualStyleBackColor = false;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\virtual.mdb";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cuentas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("numeroCuenta", "numeroCuenta"),
                        new System.Data.Common.DataColumnMapping("saldo", "saldo"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("ususario", "ususario"),
                        new System.Data.Common.DataColumnMapping("contraseña", "contraseña"),
                        new System.Data.Common.DataColumnMapping("tipo", "tipo"),
                        new System.Data.Common.DataColumnMapping("direccion", "direccion"),
                        new System.Data.Common.DataColumnMapping("telefono", "telefono"),
                        new System.Data.Common.DataColumnMapping("cedula", "cedula"),
                        new System.Data.Common.DataColumnMapping("correo", "correo")})});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 370);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btsalir
            // 
            this.btsalir.BackColor = System.Drawing.Color.MediumPurple;
            this.btsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsalir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsalir.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir.ForeColor = System.Drawing.Color.Black;
            this.btsalir.Location = new System.Drawing.Point(258, 314);
            this.btsalir.Margin = new System.Windows.Forms.Padding(0);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(131, 44);
            this.btsalir.TabIndex = 6;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 365);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btingresar);
            this.Controls.Add(this.tbcont);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sucursal Virtual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbcont;
        private System.Windows.Forms.Button btingresar;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btsalir;
    }
}

