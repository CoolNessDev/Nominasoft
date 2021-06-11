
namespace NOMINASOFT
{
    partial class ProcesarPago
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
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.procesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inEstado = new System.Windows.Forms.TextBox();
            this.inCodigo = new System.Windows.Forms.TextBox();
            this.inFechaInicio = new System.Windows.Forms.TextBox();
            this.inFechaFin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContratos
            // 
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Location = new System.Drawing.Point(21, 84);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.Size = new System.Drawing.Size(748, 276);
            this.dgvContratos.TabIndex = 0;
            // 
            // procesar
            // 
            this.procesar.Location = new System.Drawing.Point(21, 388);
            this.procesar.Name = "procesar";
            this.procesar.Size = new System.Drawing.Size(111, 31);
            this.procesar.TabIndex = 1;
            this.procesar.Text = "Procesar periodo";
            this.procesar.UseVisualStyleBackColor = true;
            this.procesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Periodo";
            // 
            // inEstado
            // 
            this.inEstado.Location = new System.Drawing.Point(252, 38);
            this.inEstado.Name = "inEstado";
            this.inEstado.Size = new System.Drawing.Size(100, 20);
            this.inEstado.TabIndex = 7;
            // 
            // inCodigo
            // 
            this.inCodigo.Location = new System.Drawing.Point(76, 39);
            this.inCodigo.Name = "inCodigo";
            this.inCodigo.Size = new System.Drawing.Size(100, 20);
            this.inCodigo.TabIndex = 8;
            // 
            // inFechaInicio
            // 
            this.inFechaInicio.Location = new System.Drawing.Point(466, 39);
            this.inFechaInicio.Name = "inFechaInicio";
            this.inFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.inFechaInicio.TabIndex = 9;
            // 
            // inFechaFin
            // 
            this.inFechaFin.Location = new System.Drawing.Point(669, 38);
            this.inFechaFin.Name = "inFechaFin";
            this.inFechaFin.Size = new System.Drawing.Size(100, 20);
            this.inFechaFin.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProcesarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inFechaFin);
            this.Controls.Add(this.inFechaInicio);
            this.Controls.Add(this.inCodigo);
            this.Controls.Add(this.inEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procesar);
            this.Controls.Add(this.dgvContratos);
            this.Name = "ProcesarPago";
            this.Text = "ProcesarPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.Button procesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inEstado;
        private System.Windows.Forms.TextBox inCodigo;
        private System.Windows.Forms.TextBox inFechaInicio;
        private System.Windows.Forms.TextBox inFechaFin;
        private System.Windows.Forms.Button button1;
    }
}