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
	public partial class BuscarNome : Form
	{
		public BuscarNome()
		{
			InitializeComponent();
		}

		private void bnt_buscar_Click(object sender, EventArgs e)
		{
			Pessoa.Nome = textBox1.Text;

			ManipulaPessoa.VisualizarNome();

			dataGridView1.DataSource = ManipulaPessoa.VisualizarNome();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].Visible = false;
			dataGridView1.Columns[2].Visible = false;
			dataGridView1.Columns[3].Visible = false;
			dataGridView1.Columns[4].HeaderCell.Value = "Id";
			dataGridView1.Columns[5].HeaderCell.Value = "Nome";
			dataGridView1.Columns[6].HeaderCell.Value = "Celular";
			dataGridView1.Columns[7].HeaderCell.Value = "Email";
		}
	}

	
	
			
	
}
