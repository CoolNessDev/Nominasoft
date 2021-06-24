
namespace NOMINASOFT
{
    partial class GestionarContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarContrato));
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelDatosContrato = new System.Windows.Forms.GroupBox();
            this.banularInterno = new System.Windows.Forms.Button();
            this.btnGuardarContrato = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbAFP = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AsignacionNO = new System.Windows.Forms.RadioButton();
            this.AsignacionSI = new System.Windows.Forms.RadioButton();
            this.textValorHora = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textTotalDeHoras = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.TextCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAnularContrato = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textGradoResultado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textEstadoCResultado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textFechaResultado = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textTelefonoResultado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDireccionResultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNombreResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textIDResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditarContrato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.btnCrearContrato = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textDniBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDatosContrato.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(26, 386);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 3);
            this.panel5.TabIndex = 47;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // PanelDatosContrato
            // 
            this.PanelDatosContrato.Controls.Add(this.banularInterno);
            this.PanelDatosContrato.Controls.Add(this.btnGuardarContrato);
            this.PanelDatosContrato.Controls.Add(this.groupBox5);
            this.PanelDatosContrato.Controls.Add(this.groupBox4);
            this.PanelDatosContrato.Controls.Add(this.textValorHora);
            this.PanelDatosContrato.Controls.Add(this.label13);
            this.PanelDatosContrato.Controls.Add(this.textTotalDeHoras);
            this.PanelDatosContrato.Controls.Add(this.label11);
            this.PanelDatosContrato.Controls.Add(this.fechaInicio);
            this.PanelDatosContrato.Controls.Add(this.label12);
            this.PanelDatosContrato.Controls.Add(this.TextCargo);
            this.PanelDatosContrato.Controls.Add(this.label14);
            this.PanelDatosContrato.Controls.Add(this.fechaFinal);
            this.PanelDatosContrato.Controls.Add(this.label15);
            this.PanelDatosContrato.Location = new System.Drawing.Point(26, 401);
            this.PanelDatosContrato.Name = "PanelDatosContrato";
            this.PanelDatosContrato.Size = new System.Drawing.Size(650, 232);
            this.PanelDatosContrato.TabIndex = 52;
            this.PanelDatosContrato.TabStop = false;
            this.PanelDatosContrato.Text = "DATOS DE CONTRATO";
            this.PanelDatosContrato.Visible = false;
            // 
            // banularInterno
            // 
            this.banularInterno.Location = new System.Drawing.Point(551, 189);
            this.banularInterno.Name = "banularInterno";
            this.banularInterno.Size = new System.Drawing.Size(78, 31);
            this.banularInterno.TabIndex = 48;
            this.banularInterno.Text = "Anular";
            this.banularInterno.UseVisualStyleBackColor = true;
            this.banularInterno.Click += new System.EventHandler(this.banularInterno_Click);
            // 
            // btnGuardarContrato
            // 
            this.btnGuardarContrato.Location = new System.Drawing.Point(551, 152);
            this.btnGuardarContrato.Name = "btnGuardarContrato";
            this.btnGuardarContrato.Size = new System.Drawing.Size(78, 31);
            this.btnGuardarContrato.TabIndex = 40;
            this.btnGuardarContrato.Text = "Guardar";
            this.btnGuardarContrato.UseVisualStyleBackColor = true;
            this.btnGuardarContrato.Click += new System.EventHandler(this.btnGuardarContrato_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.cbAFP);
            this.groupBox5.Location = new System.Drawing.Point(380, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 73);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AFP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Tipo De AFP";
            // 
            // cbAFP
            // 
            this.cbAFP.FormattingEnabled = true;
            this.cbAFP.Location = new System.Drawing.Point(101, 30);
            this.cbAFP.Name = "cbAFP";
            this.cbAFP.Size = new System.Drawing.Size(115, 21);
            this.cbAFP.TabIndex = 48;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AsignacionNO);
            this.groupBox4.Controls.Add(this.AsignacionSI);
            this.groupBox4.Location = new System.Drawing.Point(22, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 73);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asignacion Familiar";
            // 
            // AsignacionNO
            // 
            this.AsignacionNO.AutoSize = true;
            this.AsignacionNO.Location = new System.Drawing.Point(141, 30);
            this.AsignacionNO.Name = "AsignacionNO";
            this.AsignacionNO.Size = new System.Drawing.Size(39, 17);
            this.AsignacionNO.TabIndex = 46;
            this.AsignacionNO.Text = "No";
            this.AsignacionNO.UseVisualStyleBackColor = true;
            this.AsignacionNO.CheckedChanged += new System.EventHandler(this.AsignacionNO_CheckedChanged);
            // 
            // AsignacionSI
            // 
            this.AsignacionSI.AutoSize = true;
            this.AsignacionSI.Checked = true;
            this.AsignacionSI.Location = new System.Drawing.Point(44, 34);
            this.AsignacionSI.Name = "AsignacionSI";
            this.AsignacionSI.Size = new System.Drawing.Size(34, 17);
            this.AsignacionSI.TabIndex = 45;
            this.AsignacionSI.TabStop = true;
            this.AsignacionSI.Text = "Si";
            this.AsignacionSI.UseVisualStyleBackColor = true;
            this.AsignacionSI.CheckedChanged += new System.EventHandler(this.AsignacionSI_CheckedChanged);
            // 
            // textValorHora
            // 
            this.textValorHora.Location = new System.Drawing.Point(401, 182);
            this.textValorHora.Name = "textValorHora";
            this.textValorHora.Size = new System.Drawing.Size(115, 20);
            this.textValorHora.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(377, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Valor Hora";
            // 
            // textTotalDeHoras
            // 
            this.textTotalDeHoras.Location = new System.Drawing.Point(401, 139);
            this.textTotalDeHoras.Name = "textTotalDeHoras";
            this.textTotalDeHoras.Size = new System.Drawing.Size(115, 20);
            this.textTotalDeHoras.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Total De Horas Contratadas Por Semana";
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(133, 147);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(210, 20);
            this.fechaInicio.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Fecha Inicio";
            // 
            // TextCargo
            // 
            this.TextCargo.FormattingEnabled = true;
            this.TextCargo.Items.AddRange(new object[] {
            "Gerente",
            "Logistica",
            "Secretaria(o)"});
            this.TextCargo.Location = new System.Drawing.Point(133, 114);
            this.TextCargo.Name = "TextCargo";
            this.TextCargo.Size = new System.Drawing.Size(115, 21);
            this.TextCargo.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Cargo";
            // 
            // fechaFinal
            // 
            this.fechaFinal.Location = new System.Drawing.Point(133, 183);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(210, 20);
            this.fechaFinal.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Fecha Final";
            // 
            // btnAnularContrato
            // 
            this.btnAnularContrato.Location = new System.Drawing.Point(441, 389);
            this.btnAnularContrato.Name = "btnAnularContrato";
            this.btnAnularContrato.Size = new System.Drawing.Size(75, 23);
            this.btnAnularContrato.TabIndex = 51;
            this.btnAnularContrato.Text = "Anular";
            this.btnAnularContrato.UseVisualStyleBackColor = true;
            this.btnAnularContrato.Click += new System.EventHandler(this.btnAnularContrato_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textGradoResultado);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.textEstadoCResultado);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.textFechaResultado);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textTelefonoResultado);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textDireccionResultado);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textNombreResultado);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textIDResultado);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(26, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 206);
            this.panel4.TabIndex = 48;
            // 
            // textGradoResultado
            // 
            this.textGradoResultado.Enabled = false;
            this.textGradoResultado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGradoResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textGradoResultado.Location = new System.Drawing.Point(99, 160);
            this.textGradoResultado.Name = "textGradoResultado";
            this.textGradoResultado.Size = new System.Drawing.Size(210, 20);
            this.textGradoResultado.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Grado Academico";
            // 
            // textEstadoCResultado
            // 
            this.textEstadoCResultado.Enabled = false;
            this.textEstadoCResultado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstadoCResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textEstadoCResultado.Location = new System.Drawing.Point(99, 117);
            this.textEstadoCResultado.Name = "textEstadoCResultado";
            this.textEstadoCResultado.Size = new System.Drawing.Size(114, 20);
            this.textEstadoCResultado.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estado Civil";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(330, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 120);
            this.panel3.TabIndex = 7;
            // 
            // textFechaResultado
            // 
            this.textFechaResultado.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.textFechaResultado.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.textFechaResultado.Enabled = false;
            this.textFechaResultado.Location = new System.Drawing.Point(99, 74);
            this.textFechaResultado.Name = "textFechaResultado";
            this.textFechaResultado.Size = new System.Drawing.Size(210, 20);
            this.textFechaResultado.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha De Nacimiento";
            // 
            // textTelefonoResultado
            // 
            this.textTelefonoResultado.Enabled = false;
            this.textTelefonoResultado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefonoResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textTelefonoResultado.Location = new System.Drawing.Point(415, 74);
            this.textTelefonoResultado.Name = "textTelefonoResultado";
            this.textTelefonoResultado.Size = new System.Drawing.Size(114, 20);
            this.textTelefonoResultado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono";
            // 
            // textDireccionResultado
            // 
            this.textDireccionResultado.Enabled = false;
            this.textDireccionResultado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccionResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textDireccionResultado.Location = new System.Drawing.Point(356, 117);
            this.textDireccionResultado.Name = "textDireccionResultado";
            this.textDireccionResultado.Size = new System.Drawing.Size(271, 20);
            this.textDireccionResultado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // textNombreResultado
            // 
            this.textNombreResultado.Enabled = false;
            this.textNombreResultado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textNombreResultado.Location = new System.Drawing.Point(288, 10);
            this.textNombreResultado.Name = "textNombreResultado";
            this.textNombreResultado.Size = new System.Drawing.Size(339, 20);
            this.textNombreResultado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // textIDResultado
            // 
            this.textIDResultado.Enabled = false;
            this.textIDResultado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textIDResultado.Location = new System.Drawing.Point(78, 10);
            this.textIDResultado.Name = "textIDResultado";
            this.textIDResultado.Size = new System.Drawing.Size(114, 20);
            this.textIDResultado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(26, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 3);
            this.panel2.TabIndex = 46;
            // 
            // btnEditarContrato
            // 
            this.btnEditarContrato.Location = new System.Drawing.Point(316, 389);
            this.btnEditarContrato.Name = "btnEditarContrato";
            this.btnEditarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnEditarContrato.TabIndex = 50;
            this.btnEditarContrato.Text = "Editar";
            this.btnEditarContrato.UseVisualStyleBackColor = true;
            this.btnEditarContrato.Click += new System.EventHandler(this.btnEditarContrato_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "DATOS DEL EMPLEADO";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(236, 80);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmpleado.TabIndex = 44;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnCrearContrato
            // 
            this.btnCrearContrato.Location = new System.Drawing.Point(189, 389);
            this.btnCrearContrato.Name = "btnCrearContrato";
            this.btnCrearContrato.Size = new System.Drawing.Size(75, 23);
            this.btnCrearContrato.TabIndex = 49;
            this.btnCrearContrato.Text = "Crear";
            this.btnCrearContrato.UseVisualStyleBackColor = true;
            this.btnCrearContrato.Click += new System.EventHandler(this.btnCrearContrato_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(26, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 3);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "INGRESO DE DATOS";
            // 
            // textDniBuscar
            // 
            this.textDniBuscar.Location = new System.Drawing.Point(91, 82);
            this.textDniBuscar.Name = "textDniBuscar";
            this.textDniBuscar.Size = new System.Drawing.Size(114, 20);
            this.textDniBuscar.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "DNI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 639);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GestionarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PanelDatosContrato);
            this.Controls.Add(this.btnAnularContrato);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEditarContrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.btnCrearContrato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDniBuscar);
            this.Controls.Add(this.label1);
            this.Name = "GestionarContrato";
            this.Text = "GestionarContrato";
            this.Load += new System.EventHandler(this.GestionarContrato_Load);
            this.PanelDatosContrato.ResumeLayout(false);
            this.PanelDatosContrato.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox PanelDatosContrato;
        private System.Windows.Forms.Button banularInterno;
        private System.Windows.Forms.Button btnGuardarContrato;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbAFP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton AsignacionNO;
        private System.Windows.Forms.RadioButton AsignacionSI;
        private System.Windows.Forms.TextBox textValorHora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textTotalDeHoras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TextCargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAnularContrato;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textGradoResultado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textEstadoCResultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker textFechaResultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTelefonoResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDireccionResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNombreResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIDResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditarContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnCrearContrato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDniBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}