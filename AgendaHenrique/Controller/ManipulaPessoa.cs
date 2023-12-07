using AgendaHenrique.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaHenrique.Controller
{
	internal class ManipulaPessoa
	{
		public  void cadastrar()
		{
			SqlConnection cn = new SqlConnection(Conexao.Conectar());
			SqlCommand cmd = new SqlCommand("P_AdicionarPessoa", cn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;


			try
			{
				cmd.Parameters.AddWithValue("nome", Pessoa.Nome);
				cmd.Parameters.AddWithValue("email", Pessoa.Email);
				cmd.Parameters.AddWithValue("fone", Pessoa.Fone);

				cn.Open();
				cmd.ExecuteNonQuery();

				MessageBox.Show("Usuario cadastrado.");
			}
			catch (Exception)
			{
				throw;
			}
		}
		public void Apagar()
		{
			SqlConnection cn = new SqlConnection(Conexao.Conectar());
			SqlCommand cmd = new SqlCommand("P_ApagarPessoa", cn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;

			try
			{
				cmd.Parameters.AddWithValue("@id", Pessoa.Id);
				cn.Open();
				cmd.ExecuteReader();
				MessageBox.Show("Registro excluido com sucesso");
			}
			catch (Exception)
			{
				throw;
			}
		}
		public void Atualizar()
		{
			SqlConnection cn = new SqlConnection(Conexao.Conectar());
			SqlCommand cmd = new SqlCommand("P_AtualizarPessoa", cn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;

			try
			{
				cmd.Parameters.AddWithValue("@id", Pessoa.Id);
				cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
				cmd.Parameters.AddWithValue("@fone", Pessoa.Fone);
				cmd.Parameters.AddWithValue("@email", Pessoa.Email);

				cn.Open();
				cmd.ExecuteReader();
				MessageBox.Show("");
			}
			catch (Exception)
			{
				throw;
			}
		}
		public void BuscarCodigo()
		{
			SqlConnection cn = new SqlConnection(Conexao.Conectar());
			SqlCommand cmd = new SqlCommand("P_VisualizarCodigoPessoa", cn);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;

			try
			{
				cmd.Parameters.AddWithValue("@id", Pessoa.Id);
				cn.Open();
				var dr = cmd.ExecuteReader();

				if (dr.Read())
				{
					Pessoa.Id = Convert.ToInt32(dr["id"]);
					Pessoa.Nome = dr["nome"].ToString();
					Pessoa.Fone = dr["fone"].ToString();
					Pessoa.Email = dr["email"].ToString();
				}
				else
				{
					Pessoa.Id = 0;
					Pessoa.Email = "";
					Pessoa.Fone = "";
					Pessoa.Nome = "";
					MessageBox.Show("Busca não Executada...");
				}
			}
			catch (Exception ex) {
			}
		}

		
		
		public static BindingSource VisualizarNome()
		{
			SqlConnection cn = new SqlConnection(Conexao.Conectar());
			SqlCommand cmd = new SqlCommand("P_VisualizarCodigoNome", cn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
			cn.Open();
			cmd.ExecuteNonQuery();

			SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();

			sqlData.Fill(table);

			BindingSource dados = new BindingSource();
			dados.DataSource = table;

			return dados;

		}
	}


	
}
