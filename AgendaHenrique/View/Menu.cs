using AgendaHenrique.Controller;
using AgendaHenrique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaHenrique.View
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cadastrar cadastrar = new Cadastrar();
			cadastrar.Show();
		}

		private void bnt_AlterarMenu_Click(object sender, EventArgs e)
		{
			Alterar alterar = new Alterar();
			alterar.Show();
		}

		private void bnt_CodigoMenu_Click(object sender, EventArgs e)
		{
			BuscarCod buscarCod = new BuscarCod();
			buscarCod.Show();
		}

		private void bnt_NomeMenu_Click(object sender, EventArgs e)
		{
			BuscarNome buscarNome = new BuscarNome();
			buscarNome.Show();
		}

		private void bnt_DeletarMenu_Click(object sender, EventArgs e)
		{
			Apagar apagar = new Apagar();
			apagar.Show();
		}
	}
}
