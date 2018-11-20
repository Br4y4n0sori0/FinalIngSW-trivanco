namespace sucursal
{
    partial class transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transferencia));
            this.btatras = new System.Windows.Forms.Button();
            this.bttransferir = new System.Windows.Forms.Button();
            this.tbcuentaorigen = new System.Windows.Forms.TextBox();
            this.tbcuentadestino = new System.Windows.Forms.TextBox();
            this.tbmonto = new System.Windows.Forms.TextBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
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
            this.btatras.Location = new System.Drawing.Point(296, 310);
            this.btatras.Margin = new System.Windows.Forms.Padding(0);
            this.btatras.Name = "btatras";
            this.btatras.Size = new System.Drawing.Size(153, 40);
            this.btatras.TabIndex = 14;
            this.btatras.Text = "Atrás";
            this.btatras.UseVisualStyleBackColor = false;
            this.btatras.Click += new System.EventHandler(this.btatras_Click);
            // 
            // bttransferir
            // 
            this.bttransferir.BackColor = System.Drawing.Color.MediumPurple;
            this.bttransferir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttransferir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bttransferir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttransferir.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttransferir.ForeColor = System.Drawing.Color.Black;
            this.bttransferir.Location = new System.Drawing.Point(36, 310);
            this.bttransferir.Margin = new System.Windows.Forms.Padding(0);
            this.bttransferir.Name = "bttransferir";
            this.bttransferir.Size = new System.Drawing.Size(153, 40);
            this.bttransferir.TabIndex = 15;
            this.bttransferir.Text = "Transferir";
            this.bttransferir.UseVisualStyleBackColor = false;
            this.bttransferir.Click += new System.EventHandler(this.bttransferir_Click);
            // 
            // tbcuentaorigen
            // 
            this.tbcuentaorigen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbcuentaorigen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcuentaorigen.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcuentaorigen.Location = new System.Drawing.Point(162, 148);
            this.tbcuentaorigen.Name = "tbcuentaorigen";
            this.tbcuentaorigen.Size = new System.Drawing.Size(220, 39);
            this.tbcuentaorigen.TabIndex = 16;
            // 
            // tbcuentadestino
            // 
            this.tbcuentadestino.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbcuentadestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcuentadestino.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcuentadestino.Location = new System.Drawing.Point(162, 202);
            this.tbcuentadestino.Name = "tbcuentadestino";
            this.tbcuentadestino.Size = new System.Drawing.Size(220, 39);
            this.tbcuentadestino.TabIndex = 17;
            // 
            // tbmonto
            // 
            this.tbmonto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbmonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbmonto.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmonto.Location = new System.Drawing.Point(162, 256);
            this.tbmonto.Name = "tbmonto";
            this.tbmonto.Size = new System.Drawing.Size(220, 39);
            this.tbmonto.TabIndex = 18;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Universidad\\POO\\Final\\Sucursal\\su" +
    "cursal\\virtual.mdb";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 359);
            this.Controls.Add(this.tbmonto);
            this.Controls.Add(this.tbcuentadestino);
            this.Controls.Add(this.tbcuentaorigen);
            this.Controls.Add(this.bttransferir);
            this.Controls.Add(this.btatras);
            this.Name = "transferencia";
            this.Text = "transferencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.transferencia_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btatras;
        private System.Windows.Forms.Button bttransferir;
        private System.Windows.Forms.TextBox tbcuentaorigen;
        private System.Windows.Forms.TextBox tbcuentadestino;
        private System.Windows.Forms.TextBox tbmonto;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}