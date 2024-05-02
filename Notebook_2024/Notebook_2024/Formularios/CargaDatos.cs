/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 17:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notebook_2024.Formularios
{
	/// <summary>
	/// Description of CargaDatos.
	/// </summary>
	public partial class CargaDatos : Form
	{
		public CargaDatos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CargaTabla(null);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void CargaTabla(string dato)
		{
			List<Clases.DatosNotebook> listado = new List<Notebook_2024.Clases.DatosNotebook>();
			Clases.Funciones funcionConsulta = new Notebook_2024.Clases.Funciones();
			dgvDatos.DataSource = funcionConsulta.consulta(dato);
		}
		
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtMarca.Text = "";
			txtModelo.Text = "";
			txtAdquiridas.Text = "";
			txtBuscar.Text = "";
			txtId.Text = "";
			txtPrecio.Text = "";
			txtVendidas.Text = "";
			
			cbxNucleos.SelectedIndex = -1;
			cbxRam.SelectedIndex = -1;
			cbxDisco.SelectedIndex = -1;
			cbxRed.SelectedIndex = -1;
			cbxSO.SelectedIndex = -1;
			cbxUsb.SelectedIndex = -1;
			cbxVideo.SelectedIndex = -1;
			cbxWifi.SelectedIndex = -1;
			
		}
		
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			bool bandera = false;
			
			if(txtMarca.Text=="" || txtModelo.Text=="" || txtPrecio.Text=="" || txtAdquiridas.Text==""
			   || txtVendidas.Text=="" || txtPrecio.Text=="" || cbxNucleos.SelectedIndex<0 || cbxRam.SelectedIndex<0
			   || cbxDisco.SelectedIndex<0 || cbxRed.SelectedIndex<0 || cbxSO.SelectedIndex<0 || cbxUsb.SelectedIndex<0
			   || cbxVideo.SelectedIndex<0 || cbxWifi.SelectedIndex<0)
			{
				MessageBox.Show("Para guardar el registros se requiere llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			
			Clases.DatosNotebook datosNote = new Notebook_2024.Clases.DatosNotebook();
			
			datosNote.Marca = txtMarca.Text;
			datosNote.Modelo = txtModelo.Text;
			int indiceNucelo = cbxNucleos.SelectedIndex;
			datosNote.CantidadNucleos = cbxNucleos.Items[indiceNucelo].ToString();
			int indiceRam = cbxRam.SelectedIndex;
			datosNote.MemoriaRam = cbxRam.Items[indiceRam].ToString();
			int indiceVideo = cbxVideo.SelectedIndex;
			datosNote.MemoriaVideo = cbxVideo.Items[indiceVideo].ToString();
			int indiceDisco = cbxDisco.SelectedIndex;
			datosNote.Disco = cbxDisco.Items[indiceDisco].ToString();
			int indiceSO = cbxSO.SelectedIndex;
			datosNote.SistemaOperativo = cbxSO.Items[indiceSO].ToString();
			int indiceWifi = cbxWifi.SelectedIndex;
			datosNote.Wifi = cbxWifi.Items[indiceWifi].ToString();
			int indiceUsb = cbxUsb.SelectedIndex;
			datosNote.PuertosUsb = cbxUsb.Items[indiceUsb].ToString();
			int indiceRed = cbxRed.SelectedIndex;
			datosNote.RedRj45 = cbxRed.Items[indiceRed].ToString();
			datosNote.PrecioUnitario = double.Parse(txtPrecio.Text);
			datosNote.CantidadAdquiridas = int.Parse(txtAdquiridas.Text);
			datosNote.CantidadVendidas = int.Parse(txtVendidas.Text);
			datosNote.EnStock = datosNote.CantidadAdquiridas - datosNote.CantidadVendidas;
			datosNote.ValorTotalStock = datosNote.EnStock * datosNote.PrecioUnitario;
			
			Clases.Funciones funcionInsertar = new Notebook_2024.Clases.Funciones();
			
			if(txtId.Text != "")
			{
				datosNote.Id = int.Parse(txtId.Text);
				bandera = funcionInsertar.actualizar(datosNote);
			}
			else
			{
				bandera = funcionInsertar.insertar(datosNote);
			}
			
			if(bandera)
			{
				MessageBox.Show("Registro Guardado");
			}
			CargaTabla(null);
			BtnLimpiarClick(null, null);
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			txtId.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
			txtMarca.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
			txtModelo.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
			cbxNucleos.SelectedItem = dgvDatos.CurrentRow.Cells[3].Value.ToString();
			cbxRam.SelectedItem = dgvDatos.CurrentRow.Cells[4].Value.ToString();
			cbxVideo.SelectedItem = dgvDatos.CurrentRow.Cells[5].Value.ToString();
			cbxDisco.SelectedItem = dgvDatos.CurrentRow.Cells[6].Value.ToString();
			cbxUsb.SelectedItem = dgvDatos.CurrentRow.Cells[7].Value.ToString();
			cbxRed.SelectedItem = dgvDatos.CurrentRow.Cells[8].Value.ToString();
			cbxWifi.SelectedItem = dgvDatos.CurrentRow.Cells[9].Value.ToString();
			cbxSO.SelectedItem = dgvDatos.CurrentRow.Cells[10].Value.ToString();
			txtPrecio.Text = dgvDatos.CurrentRow.Cells[11].Value.ToString();
			txtAdquiridas.Text = dgvDatos.CurrentRow.Cells[12].Value.ToString();
			txtVendidas.Text = dgvDatos.CurrentRow.Cells[13].Value.ToString();
			
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("Seguro que desea elmiminar el registro?","Salir", MessageBoxButtons.YesNoCancel);
			
			if(resultado == DialogResult.Yes)
			{
				int id = int.Parse(txtId.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString());
				
				Clases.Funciones funcionEliminar = new Notebook_2024.Clases.Funciones();
				funcionEliminar.eliminar(id);
			}
			CargaTabla(null);
		}
		
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			string serch = txtBuscar.Text;
			CargaTabla(serch);
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Seguro/a que desea salir del sistema?",
        	   "Consulta",
        	   MessageBoxButtons.YesNo, 
        	   MessageBoxIcon.Question)==DialogResult.Yes){
        	   	
				Application.Exit();
        	   }
		}
		
		void TxtMarcaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <=255)
        	{
        		MessageBox.Show("Solo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           		e.Handled = true;
        		return;
        	}
		}
		
		void TxtPrecioKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <=255)
        	{
        		MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           		e.Handled = true;
        		return;
        	}
		}
		
		void TxtAdquiridasKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <=255)
        	{
        		MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           		e.Handled = true;
        		return;
        	}
		}
		
		void TxtVendidasKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <=255)
        	{
        		MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           		e.Handled = true;
        		return;
        	}
		}
	}
}
