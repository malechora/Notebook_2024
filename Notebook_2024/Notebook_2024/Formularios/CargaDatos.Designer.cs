/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 17:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Notebook_2024.Formularios
{
	partial class CargaDatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaDatos));
			this.plTitulo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxNucleos = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxRam = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxVideo = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxDisco = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbxSO = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cbxUsb = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbxWifi = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxRed = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtAdquiridas = new System.Windows.Forms.TextBox();
			this.txtVendidas = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.plTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// plTitulo
			// 
			this.plTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plTitulo.BackgroundImage")));
			this.plTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.plTitulo.Controls.Add(this.label1);
			this.plTitulo.Location = new System.Drawing.Point(1, 1);
			this.plTitulo.Name = "plTitulo";
			this.plTitulo.Size = new System.Drawing.Size(774, 100);
			this.plTitulo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label1.Location = new System.Drawing.Point(35, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOTEBOOK";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "MARCA:";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(72, 114);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(125, 20);
			this.txtMarca.TabIndex = 2;
			this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarcaKeyPress);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(225, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "MODELO:";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(301, 114);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(125, 20);
			this.txtModelo.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(449, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "CANT. NÚCLEOS:";
			// 
			// cbxNucleos
			// 
			this.cbxNucleos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxNucleos.FormattingEnabled = true;
			this.cbxNucleos.Items.AddRange(new object[] {
									"2",
									"4",
									"6",
									"8"});
			this.cbxNucleos.Location = new System.Drawing.Point(579, 114);
			this.cbxNucleos.Name = "cbxNucleos";
			this.cbxNucleos.Size = new System.Drawing.Size(155, 23);
			this.cbxNucleos.TabIndex = 6;
			this.cbxNucleos.Text = "ELIJA UNA OPCIÓN";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(12, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "MEMORIA RAM:";
			// 
			// cbxRam
			// 
			this.cbxRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxRam.FormattingEnabled = true;
			this.cbxRam.Items.AddRange(new object[] {
									"4",
									"8",
									"16",
									"32"});
			this.cbxRam.Location = new System.Drawing.Point(124, 149);
			this.cbxRam.Name = "cbxRam";
			this.cbxRam.Size = new System.Drawing.Size(155, 23);
			this.cbxRam.TabIndex = 8;
			this.cbxRam.Text = "ELIJA UNA OPCIÓN";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(301, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "MEMORIA VIDEO:";
			// 
			// cbxVideo
			// 
			this.cbxVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxVideo.FormattingEnabled = true;
			this.cbxVideo.Items.AddRange(new object[] {
									"2",
									"4",
									"6",
									"8"});
			this.cbxVideo.Location = new System.Drawing.Point(432, 149);
			this.cbxVideo.Name = "cbxVideo";
			this.cbxVideo.Size = new System.Drawing.Size(155, 23);
			this.cbxVideo.TabIndex = 10;
			this.cbxVideo.Text = "ELIJA UNA OPCIÓN";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(12, 186);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "HDD/SSD:";
			// 
			// cbxDisco
			// 
			this.cbxDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDisco.FormattingEnabled = true;
			this.cbxDisco.Items.AddRange(new object[] {
									"HDD",
									"SSD"});
			this.cbxDisco.Location = new System.Drawing.Point(84, 183);
			this.cbxDisco.Name = "cbxDisco";
			this.cbxDisco.Size = new System.Drawing.Size(155, 23);
			this.cbxDisco.TabIndex = 12;
			this.cbxDisco.Text = "ELIJA UNA OPCIÓN";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(258, 186);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(128, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "SIST. OPERATIVO:";
			// 
			// cbxSO
			// 
			this.cbxSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSO.FormattingEnabled = true;
			this.cbxSO.Items.AddRange(new object[] {
									"Windows",
									"Linux"});
			this.cbxSO.Location = new System.Drawing.Point(392, 183);
			this.cbxSO.Name = "cbxSO";
			this.cbxSO.Size = new System.Drawing.Size(155, 23);
			this.cbxSO.TabIndex = 14;
			this.cbxSO.Text = "ELIJA UNA OPCIÓN";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(12, 218);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "PUERTOS USB:";
			// 
			// cbxUsb
			// 
			this.cbxUsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUsb.FormattingEnabled = true;
			this.cbxUsb.Items.AddRange(new object[] {
									"2",
									"3",
									"4"});
			this.cbxUsb.Location = new System.Drawing.Point(124, 215);
			this.cbxUsb.Name = "cbxUsb";
			this.cbxUsb.Size = new System.Drawing.Size(155, 23);
			this.cbxUsb.TabIndex = 16;
			this.cbxUsb.Text = "ELIJA UNA OPCIÓN";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(562, 186);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "WIFI:";
			// 
			// cbxWifi
			// 
			this.cbxWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxWifi.FormattingEnabled = true;
			this.cbxWifi.Items.AddRange(new object[] {
									"802,11 AX",
									"802,11 AC",
									"802,11 AC wave2",
									"802,11 AC wave1",
									"802,11 N",
									"802,11 B",
									"802,11 A",
									"802,11 B",
									"802,11 Tradicional"});
			this.cbxWifi.Location = new System.Drawing.Point(609, 183);
			this.cbxWifi.Name = "cbxWifi";
			this.cbxWifi.Size = new System.Drawing.Size(155, 23);
			this.cbxWifi.TabIndex = 18;
			this.cbxWifi.Text = "ELIJA UNA OPCIÓN";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(301, 218);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "RED RJ45:";
			// 
			// cbxRed
			// 
			this.cbxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxRed.FormattingEnabled = true;
			this.cbxRed.Items.AddRange(new object[] {
									"SI",
									"NO"});
			this.cbxRed.Location = new System.Drawing.Point(383, 215);
			this.cbxRed.Name = "cbxRed";
			this.cbxRed.Size = new System.Drawing.Size(155, 23);
			this.cbxRed.TabIndex = 20;
			this.cbxRed.Text = "ELIJA UNA OPCIÓN";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.Control;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(12, 252);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(134, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "PRECIO UNITARIO:";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.Control;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(291, 252);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(145, 23);
			this.label13.TabIndex = 23;
			this.label13.Text = "CANT. ADQUIRIDAS:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(142, 251);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(125, 20);
			this.txtPrecio.TabIndex = 25;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioKeyPress);
			// 
			// txtAdquiridas
			// 
			this.txtAdquiridas.Location = new System.Drawing.Point(432, 252);
			this.txtAdquiridas.Name = "txtAdquiridas";
			this.txtAdquiridas.Size = new System.Drawing.Size(76, 20);
			this.txtAdquiridas.TabIndex = 26;
			this.txtAdquiridas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAdquiridasKeyPress);
			// 
			// txtVendidas
			// 
			this.txtVendidas.Location = new System.Drawing.Point(656, 250);
			this.txtVendidas.Name = "txtVendidas";
			this.txtVendidas.Size = new System.Drawing.Size(76, 20);
			this.txtVendidas.TabIndex = 28;
			this.txtVendidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVendidasKeyPress);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.Control;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(525, 252);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(129, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "CANT. VENDIDAS:";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.Control;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(61, 304);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(134, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "BÚSQUEDA:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(201, 307);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(373, 20);
			this.txtBuscar.TabIndex = 30;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(593, 304);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(127, 26);
			this.btnBuscar.TabIndex = 31;
			this.btnBuscar.Text = "FILTRAR";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(12, 333);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.Size = new System.Drawing.Size(752, 273);
			this.dgvDatos.TabIndex = 32;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(41, 612);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(104, 31);
			this.btnGuardar.TabIndex = 33;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.Location = new System.Drawing.Point(189, 612);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(118, 31);
			this.btnModificar.TabIndex = 34;
			this.btnModificar.Text = "MODIFICAR";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.Location = new System.Drawing.Point(356, 612);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(108, 31);
			this.btnEliminar.TabIndex = 35;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.Location = new System.Drawing.Point(644, 612);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(90, 31);
			this.btnSalir.TabIndex = 37;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(738, 304);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(26, 20);
			this.txtId.TabIndex = 38;
			this.txtId.Visible = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
			this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpiar.Location = new System.Drawing.Point(509, 612);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(95, 31);
			this.btnLimpiar.TabIndex = 39;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// CargaDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(776, 652);
			this.ControlBox = false;
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvDatos);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtVendidas);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtAdquiridas);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cbxRed);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbxWifi);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbxUsb);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbxSO);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbxDisco);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxVideo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbxRam);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxNucleos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.plTitulo);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CargaDatos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = resources.GetString("$this.Text");
			this.plTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtVendidas;
		private System.Windows.Forms.TextBox txtAdquiridas;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cbxRed;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbxWifi;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbxUsb;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbxSO;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbxDisco;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxVideo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxRam;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxNucleos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel plTitulo;
	}
}
