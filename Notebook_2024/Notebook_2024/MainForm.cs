/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 16:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Notebook_2024
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		
		void CbxIntegrantesSelectedIndexChanged(object sender, EventArgs e)
		{
			int seleccion = cbxIntegrantes.SelectedIndex;
			
			switch(seleccion)
			{
				case 0:
					{
						txtNombre.Text = "Sergio Fernando";
						txtApellido.Text = "Artica";
						BackColor = Color.IndianRed;;
					}break;
					
				case 1:
					{
						txtNombre.Text = "Gabriel";
						txtApellido.Text = "Avellaneda";
						BackColor = Color.LightGreen;
					}break;
						
				case 2:
					{
						txtNombre.Text = "Agustin";
						txtApellido.Text = "Boquete";
						BackColor = Color.LightSkyBlue;
					}break;
						
				case 3:
					{
						txtNombre.Text = "Miguel";
						txtApellido.Text = "Carabajal";
						BackColor = Color.LightSteelBlue;
					}break;
					
				case 4:
					{
						txtNombre.Text = "Cristian";
						txtApellido.Text = "Diaz";
						BackColor = Color.LightSeaGreen;
					}break;
			}
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
		
		void BtnAccederClick(object sender, EventArgs e)
		{
			if(txtNombre.Text =="" || txtApellido.Text=="")
			{
				MessageBox.Show("Para acceder al sistema debe seleccionar un integrante del equipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				MessageBox.Show("Bienvenido "+txtNombre.Text+" al software de gestion para cargar Notebooks");
			}
			
			Formularios.CargaDatos carga = new Notebook_2024.Formularios.CargaDatos();
			carga.Show();
		}

		
		void BtnCreateTableClick(object sender, EventArgs e)
		{
			Clases.Conexion miConexion = new Notebook_2024.Clases.Conexion();
		
		    string crearBaseDatos = "CREATE DATABASE IF NOT EXISTS notebook_2024";
		    string crearTablaCaracteristicas = "CREATE TABLE `notebook_2024`.`caracteristicas` (`id` INT NOT NULL AUTO_INCREMENT , `Marca` VARCHAR(20) NOT NULL , `Modelo` VARCHAR(20) NOT NULL , `Cantidad_de_nucleos` INT(2) NOT NULL , `Memoria_ram` INT(2) NOT NULL , `Memoria_de_video` INT(2) NOT NULL , `HDD_SSD` CHAR(3) NOT NULL , `Puertos_usb` VARCHAR(2) NOT NULL , `Red_RJ45` CHAR(2) NOT NULL , `Wifi` VARCHAR(12) NOT NULL , `SO_base` VARCHAR(10) NOT NULL , `Precio_unitario` FLOAT(10,2) NOT NULL , `Cantidad_Adquiridas` INT(5) NOT NULL , `Cantidad_Vendidas` INT(5) NOT NULL , `En_Stock` INT(5) NOT NULL , `Valor_total_del_Stock` DOUBLE(15,4) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB";
		
		    MySqlConnection conexionBD = miConexion.conexion();
		    conexionBD.Open();
		
		    try
		    {
		        MySqlCommand comando = new MySqlCommand(crearBaseDatos, conexionBD);
		        comando.ExecuteNonQuery();
		
		        MySqlCommand comando2 = new MySqlCommand(crearTablaCaracteristicas, conexionBD);
		        comando2.ExecuteNonQuery();
		
		        MessageBox.Show("La base de datos y la tabla fueron creadas exitosamente");
		    }
		    catch (MySqlException ex)
		    {
		        MessageBox.Show("Error al crear la base de datos o la tabla: " + ex.Message);
		    }
		    finally
		    {
		        conexionBD.Close();
		    }
		}
		
		void BtnAccederMouseHover(object sender, EventArgs e)
		{
			btnAcceder.BackColor = Color.Green;
			btnAcceder.ForeColor = Color.White;
		}
		
		void BtnAccederMouseLeave(object sender, EventArgs e)
		{
			btnAcceder.BackColor = Color.LightGray;
			btnAcceder.ForeColor = Color.Black;
		}
		
		void BtnSalirMouseHover(object sender, EventArgs e)
		{
			btnSalir.BackColor = Color.Red;
			btnSalir.ForeColor = Color.White;
		}
		
		void BtnSalirMouseLeave(object sender, EventArgs e)
		{
			btnSalir.BackColor = Color.LightGray;
			btnSalir.ForeColor = Color.Black;
		}
		
		
		void BtnCreateTableMouseHover(object sender, EventArgs e)
		{
			btnCreateTable.BackColor = Color.Black;
			btnCreateTable.ForeColor = Color.White;
		}
		
		void BtnCreateTableMouseLeave(object sender, EventArgs e)
		{
			btnCreateTable.BackColor = Color.LightGray;
			btnCreateTable.ForeColor = Color.Black;
		}
	}
}
