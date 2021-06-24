
namespace NOMINASOFT
{
    partial class Nominasoft
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
            this.btnProcesarPagos = new System.Windows.Forms.Button();
            this.btnGestionarContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesarPagos
            // 
            this.btnProcesarPagos.Location = new System.Drawing.Point(80, 131);
            this.btnProcesarPagos.Name = "btnProcesarPagos";
            this.btnProcesarPagos.Size = new System.Drawing.Size(109, 37);
            this.btnProcesarPagos.TabIndex = 3;
            this.btnProcesarPagos.Text = "Procesar Pagos";
            this.btnProcesarPagos.UseVisualStyleBackColor = true;
            this.btnProcesarPagos.Click += new System.EventHandler(this.btnProcesarPagos_Click);
            // 
            // btnGestionarContrato
            // 
            this.btnGestionarContrato.Location = new System.Drawing.Point(80, 74);
            this.btnGestionarContrato.Name = "btnGestionarContrato";
            this.btnGestionarContrato.Size = new System.Drawing.Size(109, 37);
            this.btnGestionarContrato.TabIndex = 2;
            this.btnGestionarContrato.Text = "Gestionar Contrato";
            this.btnGestionarContrato.UseVisualStyleBackColor = true;
            this.btnGestionarContrato.Click += new System.EventHandler(this.btnGestionarContrato_Click);
            // 
            // Nominasoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 242);
            this.Controls.Add(this.btnProcesarPagos);
            this.Controls.Add(this.btnGestionarContrato);
            this.Name = "Nominasoft";
            this.Text = "Nominasoft";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesarPagos;
        private System.Windows.Forms.Button btnGestionarContrato;
    }
}

