namespace sucursal
{
    partial class registrocuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrocuenta));
            this.btregistrar = new System.Windows.Forms.Button();
            this.btatras = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.tbNumeroCuenta = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btregistrar
            // 
            this.btregistrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btregistrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btregistrar.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregistrar.ForeColor = System.Drawing.Color.Black;
            this.btregistrar.Location = new System.Drawing.Point(104, 315);
            this.btregistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btregistrar.Name = "btregistrar";
            this.btregistrar.Size = new System.Drawing.Size(144, 44);
            this.btregistrar.TabIndex = 5;
            this.btregistrar.Text = "Registrar";
            this.btregistrar.UseVisualStyleBackColor = false;
            this.btregistrar.Click += new System.EventHandler(this.btregistrar_Click);
            // 
            // btatras
            // 
            this.btatras.BackColor = System.Drawing.Color.MediumPurple;
            this.btatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btatras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btatras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btatras.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatras.ForeColor = System.Drawing.Color.Black;
            this.btatras.Location = new System.Drawing.Point(262, 315);
            this.btatras.Margin = new System.Windows.Forms.Padding(0);
            this.btatras.Name = "btatras";
            this.btatras.Size = new System.Drawing.Size(149, 44);
            this.btatras.TabIndex = 6;
            this.btatras.Text = "Atrás";
            this.btatras.UseVisualStyleBackColor = false;
            this.btatras.Click += new System.EventHandler(this.btatras_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        cuentas.*, Id AS Expr1, numeroCuenta AS Expr2, saldo AS Expr3\r\nFROM" +
    "            cuentas";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\virtual.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `cuentas` (`numeroCuenta`, `saldo`, `numeroCuenta`, `saldo`) VALUES (" +
    "?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("numeroCuenta", System.Data.OleDb.OleDbType.VarWChar, 0, "numeroCuenta"),
            new System.Data.OleDb.OleDbParameter("saldo", System.Data.OleDb.OleDbType.Currency, 0, "saldo"),
            new System.Data.OleDb.OleDbParameter("Expr2", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr2"),
            new System.Data.OleDb.OleDbParameter("Expr3", System.Data.OleDb.OleDbType.Currency, 0, "Expr3")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("numeroCuenta", System.Data.OleDb.OleDbType.VarWChar, 0, "numeroCuenta"),
            new System.Data.OleDb.OleDbParameter("saldo", System.Data.OleDb.OleDbType.Currency, 0, "saldo"),
            new System.Data.OleDb.OleDbParameter("Expr2", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr2"),
            new System.Data.OleDb.OleDbParameter("Expr3", System.Data.OleDb.OleDbType.Currency, 0, "Expr3"),
            new System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_numeroCuenta", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numeroCuenta", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_numeroCuenta", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numeroCuenta", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_saldo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "saldo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_saldo", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "saldo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr3", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr3", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_numeroCuenta", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numeroCuenta", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_numeroCuenta", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numeroCuenta", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_saldo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "saldo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_saldo", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "saldo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Expr3", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Expr3", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cuentas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("numeroCuenta", "numeroCuenta"),
                        new System.Data.Common.DataColumnMapping("saldo", "saldo"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Expr2", "Expr2"),
                        new System.Data.Common.DataColumnMapping("Expr3", "Expr3")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // tbNumeroCuenta
            // 
            this.tbNumeroCuenta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNumeroCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumeroCuenta.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroCuenta.Location = new System.Drawing.Point(155, 167);
            this.tbNumeroCuenta.Name = "tbNumeroCuenta";
            this.tbNumeroCuenta.Size = new System.Drawing.Size(220, 39);
            this.tbNumeroCuenta.TabIndex = 7;
            // 
            // tbSaldo
            // 
            this.tbSaldo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSaldo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.Location = new System.Drawing.Point(155, 247);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(220, 39);
            this.tbSaldo.TabIndex = 8;
            this.tbSaldo.TextChanged += new System.EventHandler(this.tbSaldo_TextChanged);
            // 
            // registrocuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(516, 368);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbNumeroCuenta);
            this.Controls.Add(this.btatras);
            this.Controls.Add(this.btregistrar);
            this.MaximizeBox = false;
            this.Name = "registrocuenta";
            this.Text = "Registro de cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registrocuenta_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btregistrar;
        private System.Windows.Forms.Button btatras;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.TextBox tbNumeroCuenta;
        private System.Windows.Forms.TextBox tbSaldo;
    }
}