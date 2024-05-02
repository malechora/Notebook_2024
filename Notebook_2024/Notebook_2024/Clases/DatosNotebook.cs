/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 5/1/2024
 * Time: 18:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Notebook_2024.Clases
{
	/// <summary>
	/// Description of DatosNotebook.
	/// </summary>
	public class DatosNotebook
	{
		private int id;
		private string marca;
		private string modelo;
		private string cantidadNucleos;
		private string memoriaRam;
		private string memoriaVideo;
		private string disco;
		private string puertosUsb;
		private string redRj45;
		private string wifi;
		private string sistemaOperativo;
		private double precioUnitario;
		private int cantidadAdquiridas;
		private int cantidadVendidas;
		private int enStock;
		private double valorTotalStock;
		
		public int Id {
			get { return id; }
			set { id = value; }
		}

		public string Marca {
			get { return marca; }
			set { marca = value; }
		}

		public string Modelo {
			get { return modelo; }
			set { modelo = value; }
		}

		public string CantidadNucleos {
			get { return cantidadNucleos; }
			set { cantidadNucleos = value; }
		}

		public string MemoriaRam {
			get { return memoriaRam; }
			set { memoriaRam = value; }
		}

		public string MemoriaVideo {
			get { return memoriaVideo; }
			set { memoriaVideo = value; }
		}

		public string Disco {
			get { return disco; }
			set { disco = value; }
		}

		public string PuertosUsb {
			get { return puertosUsb; }
			set { puertosUsb = value; }
		}

		public string RedRj45 {
			get { return redRj45; }
			set { redRj45 = value; }
		}

		public string Wifi {
			get { return wifi; }
			set { wifi = value; }
		}

		public string SistemaOperativo {
			get { return sistemaOperativo; }
			set { sistemaOperativo = value; }
		}

		public double PrecioUnitario {
			get { return precioUnitario; }
			set { precioUnitario = value; }
		}
		
		public int CantidadAdquiridas {
			get { return cantidadAdquiridas; }
			set { cantidadAdquiridas = value; }
		}

		public int CantidadVendidas {
			get { return cantidadVendidas; }
			set { cantidadVendidas = value; }
		}

		public int EnStock {
			get { return enStock; }
			set { enStock = value; }
		}

		public double ValorTotalStock {
			get { return valorTotalStock; }
			set { valorTotalStock = value; }
		}
	}
}
