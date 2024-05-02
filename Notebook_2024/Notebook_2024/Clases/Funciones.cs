/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 18:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Notebook_2024.Clases
{
	/// <summary>
	/// Description of Funciones.
	/// </summary>
	public class Funciones:Conexion
	{
		public List <Object> consulta(string dato)
		{
			MySqlDataReader reader;
			List <Object> listado = new List<object>();
			
			string sql;
			
			
			if(dato == null)
			{
				sql = "SELECT id, Marca, Modelo, Cantidad_de_nucleos, Memoria_ram, Memoria_de_video, HDD_SSD, Puertos_usb, " +
				"Red_RJ45, Wifi, SO_base, Precio_unitario, Cantidad_Adquiridas, Cantidad_Vendidas, En_Stock, " +
					"Valor_total_del_Stock FROM caracteristicas ORDER BY Marca ASC";
			}
			else
			{
				sql = "SELECT id, Marca, Modelo, Cantidad_de_nucleos, Memoria_ram, Memoria_de_video, HDD_SSD, Puertos_usb, " +
				"Red_RJ45, Wifi, SO_base, Precio_unitario, Cantidad_Adquiridas, Cantidad_Vendidas, En_Stock, Valor_total_del_Stock FROM caracteristicas WHERE Marca LIKE '%" + dato + "%' OR Modelo LIKE '%" + dato + "%' OR  " +
					"Cantidad_de_nucleos LIKE '%" + dato + "%' OR  Memoria_ram LIKE '%" + dato + "%' OR  Memoria_de_video LIKE '%" + dato +"%' OR  " +
					"HDD_SSD LIKE '%" + dato + "%' OR  Puertos_usb LIKE '%" + dato + "%' OR  Red_RJ45 LIKE '%" + dato + "%' OR  Wifi LIKE '%" + dato + "%' OR  " +
					"SO_base LIKE '%" + dato + "%' OR  Precio_unitario LIKE '%" + dato + "%' OR " +
					"Cantidad_Adquiridas LIKE '%" + dato + "%' OR Cantidad_Vendidas LIKE '%" + dato + "%' OR En_Stock LIKE '%" + dato + "%' OR Valor_total_del_Stock LIKE '%" + dato + "%' ORDER BY Marca ASC";
				
				
				
			}
			
			try
			{
				MySqlConnection conexionBD = base.conexion();
				conexionBD.Open();
				
				MySqlCommand comando = new MySqlCommand(sql, conexionBD);
				reader = comando.ExecuteReader();
				
				while(reader.Read())
				{
					DatosNotebook datosNote = new DatosNotebook();
					
					datosNote.Id = int.Parse(reader.GetString(0));
					datosNote.Marca = reader.GetString(1);
					datosNote.Modelo = reader.GetString(2);
					datosNote.CantidadNucleos = reader.GetString(3);
					datosNote.MemoriaRam = reader.GetString(4);
					datosNote.MemoriaVideo = reader.GetString(5);
					datosNote.Disco = reader.GetString(6);
					datosNote.PuertosUsb = reader.GetString(7);
					datosNote.RedRj45 = reader.GetString(8);
					datosNote.Wifi = reader.GetString(9);
					datosNote.SistemaOperativo = reader.GetString(10);
					datosNote.PrecioUnitario = double.Parse(reader.GetString(11));
					datosNote.CantidadAdquiridas = int.Parse(reader.GetString(12));
					datosNote.CantidadVendidas = int.Parse(reader.GetString(13));
					datosNote.EnStock = int.Parse(reader.GetString(14));
					datosNote.ValorTotalStock = double.Parse(reader.GetString(15));
					
					listado.Add(datosNote);
					
				}
			}
			catch(MySqlException ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}
			
			return listado;
		}
		
		public bool insertar(DatosNotebook dato)
		{
			bool bandera = false;
			
			string sql = "INSERT INTO caracteristicas(Marca, Modelo, Cantidad_de_nucleos, Memoria_ram, " +
				"Memoria_de_video, HDD_SSD, Puertos_usb, Red_RJ45, Wifi, SO_base, Precio_unitario, " +
				"Cantidad_Adquiridas, Cantidad_Vendidas, En_Stock, Valor_total_del_Stock) VALUES(@Marca, " +
				"@Modelo, @Cantidad_de_nucleos, @Memoria_ram, @Memoria_de_video, @HDD_SSD, @Puertos_usb, " +
				"@Red_RJ45, @Wifi, @SO_base, @Precio_unitario, @Cantidad_Adquiridas, @Cantidad_Vendidas, @En_Stock, @Valor_total_del_Stock)";
			
			try
			{
				MySqlConnection conexionBD = base.conexion();
				conexionBD.Open();
				
				using(MySqlCommand comando = new MySqlCommand(sql, conexionBD))
				{
					comando.Parameters.AddWithValue("@Marca", dato.Marca);
					comando.Parameters.AddWithValue("@Modelo", dato.Modelo);
					comando.Parameters.AddWithValue("@Cantidad_de_nucleos", dato.CantidadNucleos);
					comando.Parameters.AddWithValue("@Memoria_ram", dato.MemoriaRam);
					comando.Parameters.AddWithValue("@Memoria_de_video", dato.MemoriaVideo);
					comando.Parameters.AddWithValue("@HDD_SSD", dato.Disco);
					comando.Parameters.AddWithValue("@Puertos_usb", dato.PuertosUsb);
					comando.Parameters.AddWithValue("@Red_RJ45", dato.RedRj45);
					comando.Parameters.AddWithValue("@Wifi", dato.Wifi);
					comando.Parameters.AddWithValue("@SO_base", dato.SistemaOperativo);
					comando.Parameters.AddWithValue("@Precio_unitario", dato.PrecioUnitario);
					comando.Parameters.AddWithValue("@Cantidad_Adquiridas", dato.CantidadAdquiridas);
					comando.Parameters.AddWithValue("@Cantidad_Vendidas", dato.CantidadVendidas);
					comando.Parameters.AddWithValue("@En_Stock", dato.EnStock);
					comando.Parameters.AddWithValue("@Valor_total_del_Stock", dato.ValorTotalStock);
					
					comando.ExecuteNonQuery();
				}
				
				bandera = true;
			}
			
			catch(MySqlException ex)
			{
				Console.WriteLine(ex.Message.ToString());
				bandera = false;
			}
			return bandera;
		}
		
		public bool actualizar(DatosNotebook dato)
		{
			bool bandera = false;
			
			string sql = "UPDATE caracteristicas SET Marca=@Marca, Modelo=@Modelo, Cantidad_de_nucleos=@Cantidad_de_nucleos, " +
				"Memoria_ram=@Memoria_ram, Memoria_de_video=@Memoria_de_video, HDD_SSD=@HDD_SSD, Puertos_usb=@Puertos_usb, " +
				"Red_RJ45=@Red_RJ45, Wifi=@Wifi, SO_base=@SO_base, Precio_unitario=@Precio_unitario, Cantidad_Adquiridas=@Cantidad_Adquiridas, " +
				"Cantidad_Vendidas=@Cantidad_Vendidas, En_Stock=@En_Stock, Valor_total_del_Stock=@Valor_total_del_Stock WHERE id=@id";
			
			try
			{
				MySqlConnection conexionBD = base.conexion();
				conexionBD.Open();
				
				using(MySqlCommand comando = new MySqlCommand(sql, conexionBD))
				{
					comando.Parameters.AddWithValue("@id", dato.Id);
					comando.Parameters.AddWithValue("@Marca", dato.Marca);
					comando.Parameters.AddWithValue("@Modelo", dato.Modelo);
					comando.Parameters.AddWithValue("@Cantidad_de_nucleos", dato.CantidadNucleos);
					comando.Parameters.AddWithValue("@Memoria_ram", dato.MemoriaRam);
					comando.Parameters.AddWithValue("@Memoria_de_video", dato.MemoriaVideo);
					comando.Parameters.AddWithValue("@HDD_SSD", dato.Disco);
					comando.Parameters.AddWithValue("@Puertos_usb", dato.PuertosUsb);
					comando.Parameters.AddWithValue("@Red_RJ45", dato.RedRj45);
					comando.Parameters.AddWithValue("@Wifi", dato.Wifi);
					comando.Parameters.AddWithValue("@SO_base", dato.SistemaOperativo);
					comando.Parameters.AddWithValue("@Precio_unitario", dato.PrecioUnitario);
					comando.Parameters.AddWithValue("@Cantidad_Adquiridas", dato.CantidadAdquiridas);
					comando.Parameters.AddWithValue("@Cantidad_Vendidas", dato.CantidadVendidas);
					comando.Parameters.AddWithValue("@En_Stock", dato.EnStock);
					comando.Parameters.AddWithValue("@Valor_total_del_Stock", dato.ValorTotalStock);
					
					comando.ExecuteNonQuery();
				}
				
				bandera = true;
			}
			
			catch(MySqlException ex)
			{
				Console.WriteLine(ex.Message.ToString());
				bandera = false;
			}
			return bandera;
		}
		
		public bool eliminar(int id)
		{
			bool bandera = false;
			
			string sql = "DELETE FROM caracteristicas WHERE id=@id";
			
			try
			{
				MySqlConnection conexionBD = base.conexion();
				conexionBD.Open();
				
				using(MySqlCommand comando = new MySqlCommand(sql, conexionBD))
				{
					comando.Parameters.AddWithValue("@id", id);
					
					comando.ExecuteNonQuery();
				}
				
				bandera = true;
			}
			
			catch(MySqlException ex)
			{
				Console.WriteLine(ex.Message.ToString());
				bandera = false;
			}
			return bandera;
		}
	}
}
