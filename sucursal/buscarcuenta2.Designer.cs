namespace sucursal
{
    partial class buscarcuenta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarcuenta2));
            this.bteliminar = new System.Windows.Forms.Button();
            this.btatras = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.tbnumcuenta = new System.Windows.Forms.TextBox();
            this.tbsaldo = new System.Windows.Forms.TextBox();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.SuspendLayout();
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.MediumPurple;
            this.bteliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bteliminar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bteliminar.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.Black;
            this.bteliminar.Location = new System.Drawing.Point(177, 324);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(0);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(153, 40);
            this.bteliminar.TabIndex = 12;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btatras
            // 
            this.btatras.BackColor = System.Drawing.Color.MediumPurple;
            this.btatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btatras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btatras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btatras.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatras.ForeColor = System.Drawing.Color.Black;
            this.btatras.Location = new System.Drawing.Point(344, 324);
            this.btatras.Margin = new System.Windows.Forms.Padding(0);
            this.btatras.Name = "btatras";
            this.btatras.Size = new System.Drawing.Size(153, 40);
            this.btatras.TabIndex = 13;
            this.btatras.Text = "Atrás";
            this.btatras.UseVisualStyleBackColor = false;
            this.btatras.Click += new System.EventHandler(this.btatras_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.Color.MediumPurple;
            this.btbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbuscar.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscar.ForeColor = System.Drawing.Color.Black;
            this.btbuscar.Location = new System.Drawing.Point(9, 324);
            this.btbuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(155, 40);
            this.btbuscar.TabIndex = 14;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // tbnumcuenta
            // 
            this.tbnumcuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnumcuenta.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumcuenta.Location = new System.Drawing.Point(236, 163);
            this.tbnumcuenta.Name = "tbnumcuenta";
            this.tbnumcuenta.Size = new System.Drawing.Size(249, 20);
            this.tbnumcuenta.TabIndex = 15;
            // 
            // tbsaldo
            // 
            this.tbsaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsaldo.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsaldo.Location = new System.Drawing.Point(236, 223);
            this.tbsaldo.Name = "tbsaldo";
            this.tbsaldo.Size = new System.Drawing.Size(249, 20);
            this.tbsaldo.TabIndex = 16;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        numeroCuenta AS Expr1, saldo AS Expr2\r\nFROM            cuentas";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Users\\IdeaPad\\Desktop\\Nueva carp" +
    "eta (2)\\proyecto poo\\sucursal\\sucursal\\virtual.mdb\"";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `cuentas` (`numeroCuenta`, `saldo`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Expr1", System.Data.OleDb.OleDbType.Double, 0, "Expr1"),
            new System.Data.OleDb.OleDbParameter("Expr2", System.Data.OleDb.OleDbType.Currency, 0, "Expr2")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `cuentas` SET `numeroCuenta` = ?, `saldo` = ? WHERE ((`numeroCuenta` = ?) " +
    "AND ((? = 1 AND `saldo` IS NULL) OR (`saldo` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Expr1", System.Data.OleDb.OleDbType.Double, 0, "Expr1"),
            new System.Data.OleDb.OleDbParameter("Expr2", System.Data.OleDb.OleDbType.Currency, 0, "Expr2"),
            new System.Data.OleDb.OleDbParameter("Original_Expr1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr2", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `cuentas` WHERE ((`numeroCuenta` = ?) AND ((? = 1 AND `saldo` IS NULL" +
    ") OR (`saldo` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Expr1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr2", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cuentas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Expr2", "Expr2")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // buscarcuenta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 368);
            this.Controls.Add(this.tbsaldo);
            this.Controls.Add(this.tbnumcuenta);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btatras);
            this.Controls.Add(this.bteliminar);
            this.Name = "buscarcuenta2";
            this.Text = "Cuenta encontrada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buscarcuenta2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btatras;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.TextBox tbnumcuenta;
        private System.Windows.Forms.TextBox tbsaldo;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}