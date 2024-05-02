/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 18:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace Notebook_2024.Clases
{
	/// <summary>
	/// Description of Conexion.
	/// </summary>
	public class Conexion
	{
		public MySqlConnection conexion()
		{
			string servidor = "localhost";
			string puerto = "3306";
			string bd = "notebook_2024";
			string usuario = "root";
			string password = "";
			
			string cadenaConexion = "Database="+bd+"; Data Source="+servidor+"; Port="+puerto+"; User Id="+usuario+"; Password="+password+"";
			
			
			try {
				MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
				return conexionBD;
			} catch (MySqlException ex) {
				
				Console.WriteLine("Error: " + ex.Message);
				return null;
			}
		}
	}
}
