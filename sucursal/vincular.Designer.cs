namespace sucursal
{
    partial class vincular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vincular));
            this.btatras = new System.Windows.Forms.Button();
            this.btvincular = new System.Windows.Forms.Button();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.tbcuenta = new System.Windows.Forms.TextBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
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
            this.btatras.Location = new System.Drawing.Point(304, 292);
            this.btatras.Margin = new System.Windows.Forms.Padding(0);
            this.btatras.Name = "btatras";
            this.btatras.Size = new System.Drawing.Size(153, 40);
            this.btatras.TabIndex = 13;
            this.btatras.Text = "Atrás";
            this.btatras.UseVisualStyleBackColor = false;
            this.btatras.Click += new System.EventHandler(this.btatras_Click);
            // 
            // btvincular
            // 
            this.btvincular.BackColor = System.Drawing.Color.MediumPurple;
            this.btvincular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btvincular.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btvincular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btvincular.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvincular.ForeColor = System.Drawing.Color.Black;
            this.btvincular.Location = new System.Drawing.Point(87, 292);
            this.btvincular.Margin = new System.Windows.Forms.Padding(0);
            this.btvincular.Name = "btvincular";
            this.btvincular.Size = new System.Drawing.Size(153, 40);
            this.btvincular.TabIndex = 14;
            this.btvincular.Text = "Vincular";
            this.btvincular.UseVisualStyleBackColor = false;
            this.btvincular.Click += new System.EventHandler(this.btvincular_Click);
            // 
            // tbcedula
            // 
            this.tbcedula.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbcedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcedula.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcedula.Location = new System.Drawing.Point(161, 148);
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.Size = new System.Drawing.Size(220, 39);
            this.tbcedula.TabIndex = 15;
            // 
            // tbcuenta
            // 
            this.tbcuenta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbcuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcuenta.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcuenta.Location = new System.Drawing.Point(161, 220);
            this.tbcuenta.Name = "tbcuenta";
            this.tbcuenta.Size = new System.Drawing.Size(220, 39);
            this.tbcuenta.TabIndex = 16;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        cedula, cuenta, IdVinculacion\r\nFROM            vinculaciones";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `vinculaciones` (`cedula`, `cuenta`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("cedula", System.Data.OleDb.OleDbType.Integer, 0, "cedula"),
            new System.Data.OleDb.OleDbParameter("cuenta", System.Data.OleDb.OleDbType.VarWChar, 0, "cuenta")});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "vinculaciones", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cedula", "cedula"),
                        new System.Data.Common.DataColumnMapping("cuenta", "cuenta"),
                        new System.Data.Common.DataColumnMapping("IdVinculacion", "IdVinculacion")})});
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\virtual.mdb";
            // 
            // vincular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 341);
            this.Controls.Add(this.tbcuenta);
            this.Controls.Add(this.tbcedula);
            this.Controls.Add(this.btvincular);
            this.Controls.Add(this.btatras);
            this.Name = "vincular";
            this.Text = "Vincular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vincular_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btatras;
        private System.Windows.Forms.Button btvincular;
        private System.Windows.Forms.TextBox tbcedula;
        private System.Windows.Forms.TextBox tbcuenta;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}