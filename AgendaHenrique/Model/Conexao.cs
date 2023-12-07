using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaHenrique.Model
{
	internal class Conexao
	{
		public static string Conectar()
		{
			return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\henrique.afsilva1\source\repos\AgendaHenrique\AgendaHenrique\BancoDeDados\AgendaFinal.mdf;Integrated Security=True";
		}
	}
}
