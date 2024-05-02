/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 16:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Notebook_2024
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.cbxIntegrantes = new System.Windows.Forms.ComboBox();
			this.btnCreateTable = new System.Windows.Forms.Button();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(76, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(277, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "APELLIDO";
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.Black;
			this.txtNombre.Location = new System.Drawing.Point(35, 49);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(155, 21);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtApellido
			// 
			this.txtApellido.Enabled = false;
			this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(234, 49);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(151, 21);
			this.txtApellido.TabIndex = 3;
			this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbxIntegrantes
			// 
			this.cbxIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxIntegrantes.FormattingEnabled = true;
			this.cbxIntegrantes.Items.AddRange(new object[] {
									"Artica Sergio Fernando",
									"Avellaneda Gabriel",
									"Boquete Agustin",
									"Carabajal Miguel",
									"Diaz Cristian"});
			this.cbxIntegrantes.Location = new System.Drawing.Point(67, 95);
			this.cbxIntegrantes.Name = "cbxIntegrantes";
			this.cbxIntegrantes.Size = new System.Drawing.Size(286, 23);
			this.cbxIntegrantes.TabIndex = 4;
			this.cbxIntegrantes.Text = "INTEGRANTES";
			this.cbxIntegrantes.SelectedIndexChanged += new System.EventHandler(this.CbxIntegrantesSelectedIndexChanged);
			// 
			// btnCreateTable
			// 
			this.btnCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateTable.Location = new System.Drawing.Point(35, 151);
			this.btnCreateTable.Name = "btnCreateTable";
			this.btnCreateTable.Size = new System.Drawing.Size(350, 23);
			this.btnCreateTable.TabIndex = 5;
			this.btnCreateTable.Text = "Crear la tabla para la base de datos Notebook";
			this.btnCreateTable.UseVisualStyleBackColor = true;
			this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTableClick);
			this.btnCreateTable.MouseLeave += new System.EventHandler(this.BtnCreateTableMouseLeave);
			this.btnCreateTable.MouseHover += new System.EventHandler(this.BtnCreateTableMouseHover);
			// 
			// btnAcceder
			// 
			this.btnAcceder.Location = new System.Drawing.Point(67, 209);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(75, 23);
			this.btnAcceder.TabIndex = 6;
			this.btnAcceder.Text = "ACCEDER";
			this.btnAcceder.UseVisualStyleBackColor = true;
			this.btnAcceder.Click += new System.EventHandler(this.BtnAccederClick);
			this.btnAcceder.MouseLeave += new System.EventHandler(this.BtnAccederMouseLeave);
			this.btnAcceder.MouseHover += new System.EventHandler(this.BtnAccederMouseHover);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(267, 209);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			this.btnSalir.MouseLeave += new System.EventHandler(this.BtnSalirMouseLeave);
			this.btnSalir.MouseHover += new System.EventHandler(this.BtnSalirMouseHover);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tomato;
			this.ClientSize = new System.Drawing.Size(420, 240);
			this.ControlBox = false;
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAcceder);
			this.Controls.Add(this.btnCreateTable);
			this.Controls.Add(this.cbxIntegrantes);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Notebook_2024                                                      ©Copyright - G" +
			"rupo: HALCÓN";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAcceder;
		private System.Windows.Forms.Button btnCreateTable;
		private System.Windows.Forms.ComboBox cbxIntegrantes;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
