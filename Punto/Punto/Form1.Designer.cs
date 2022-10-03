namespace Punto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPuntoA = new System.Windows.Forms.TextBox();
            this.txtPuntoB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPuntoC = new System.Windows.Forms.TextBox();
            this.txtPuntoD = new System.Windows.Forms.TextBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.btnCalcularBidimencional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPuntoA
            // 
            this.txtPuntoA.Location = new System.Drawing.Point(122, 32);
            this.txtPuntoA.Name = "txtPuntoA";
            this.txtPuntoA.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoA.TabIndex = 0;
            // 
            // txtPuntoB
            // 
            this.txtPuntoB.Location = new System.Drawing.Point(122, 95);
            this.txtPuntoB.Name = "txtPuntoB";
            this.txtPuntoB.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoB.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(343, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPuntoC
            // 
            this.txtPuntoC.Location = new System.Drawing.Point(266, 32);
            this.txtPuntoC.Name = "txtPuntoC";
            this.txtPuntoC.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoC.TabIndex = 3;
            // 
            // txtPuntoD
            // 
            this.txtPuntoD.Location = new System.Drawing.Point(266, 95);
            this.txtPuntoD.Name = "txtPuntoD";
            this.txtPuntoD.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoD.TabIndex = 4;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(159, 9);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(20, 13);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "X1";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(159, 79);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(20, 13);
            this.lblX2.TabIndex = 6;
            this.lblX2.Text = "X2";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(308, 9);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(20, 13);
            this.lblY1.TabIndex = 7;
            this.lblY1.Text = "Y1";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(308, 79);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(20, 13);
            this.lblY2.TabIndex = 8;
            this.lblY2.Text = "Y2";
            // 
            // btnCalcularBidimencional
            // 
            this.btnCalcularBidimencional.Location = new System.Drawing.Point(452, 200);
            this.btnCalcularBidimencional.Name = "btnCalcularBidimencional";
            this.btnCalcularBidimencional.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularBidimencional.TabIndex = 9;
            this.btnCalcularBidimencional.Text = "X y Y";
            this.btnCalcularBidimencional.UseVisualStyleBackColor = true;
            this.btnCalcularBidimencional.Click += new System.EventHandler(this.btnCalcularBidimencional_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.btnCalcularBidimencional);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.txtPuntoD);
            this.Controls.Add(this.txtPuntoC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPuntoB);
            this.Controls.Add(this.txtPuntoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuntoA;
        private System.Windows.Forms.TextBox txtPuntoB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPuntoC;
        private System.Windows.Forms.TextBox txtPuntoD;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Button btnCalcularBidimencional;
    }
}

