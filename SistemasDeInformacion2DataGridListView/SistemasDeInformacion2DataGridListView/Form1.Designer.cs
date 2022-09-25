namespace SistemasDeInformacion2DataGridListView
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbDatos = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.ltvDatos = new System.Windows.Forms.ListView();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(62, 40);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(227, 20);
            this.txtConsulta.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(619, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 20);
            this.txtID.TabIndex = 1;
            // 
            // cmbDatos
            // 
            this.cmbDatos.FormattingEnabled = true;
            this.cmbDatos.Location = new System.Drawing.Point(340, 39);
            this.cmbDatos.Name = "cmbDatos";
            this.cmbDatos.Size = new System.Drawing.Size(227, 21);
            this.cmbDatos.TabIndex = 2;
            this.cmbDatos.SelectedIndexChanged += new System.EventHandler(this.cmbDatos_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(62, 11);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Combo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(59, 143);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 4;
            // 
            // ltvDatos
            // 
            this.ltvDatos.HideSelection = false;
            this.ltvDatos.Location = new System.Drawing.Point(62, 288);
            this.ltvDatos.Name = "ltvDatos";
            this.ltvDatos.Size = new System.Drawing.Size(689, 150);
            this.ltvDatos.TabIndex = 5;
            this.ltvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(62, 103);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(689, 150);
            this.dgvDatos.TabIndex = 6;
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.Location = new System.Drawing.Point(62, 74);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(75, 23);
            this.btnDataGrid.TabIndex = 7;
            this.btnDataGrid.Text = "DataGrid";
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.Click += new System.EventHandler(this.btnDataGrid_Click);
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(62, 259);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(75, 23);
            this.btnListView.TabIndex = 8;
            this.btnListView.Text = "ListView";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.btnDataGrid);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.ltvDatos);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cmbDatos);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtConsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView ltvDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnDataGrid;
        private System.Windows.Forms.Button btnListView;
    }
}

