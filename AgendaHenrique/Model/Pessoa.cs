using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaHenrique.Model
{
	internal class Pessoa
	{
		private static int id;
		private static string nome;
		private static string fone;
		private static string email;

		public static int Id { get => id; set => id = value; }
		public static string Nome { get => nome; set => nome = value; }
		public static string Fone { get => fone; set => fone = value; }
		public static string Email { get => email; set => email = value; }
	}
}
