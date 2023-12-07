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
	public partial class Apagar : Form
	{
		public Apagar()
		{
			InitializeComponent();
		}

		private void bnt_buscar_Click(object sender, EventArgs e)
		{
			Pessoa.Id = Convert.ToInt32(txt_buscarDeletar.Text);
			ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
			manipulaPessoa.BuscarCodigo();

			txt_nomeDeletar.Text = Pessoa.Nome;
			txt_emailDeletar.Text = Pessoa.Email;
			mask_foneDeletar.Text = Pessoa.Fone;

		}

		private void bnt_Deletar_Click(object sender, EventArgs e)
		{


		}

		private void bnt_Deletar_Click_1(object sender, EventArgs e)
		{
			Pessoa.Id = Convert.ToInt32(txt_buscarDeletar.Text);

			if (txt_buscarDeletar.Text == "")
			{
				MessageBox.Show("Digite a matricula que deseja excluir.");
			}
			else
			{
				var resposta = MessageBox.Show("Deseja realmente excluir o usuário: " + txt_nomeDeletar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
				if (resposta == DialogResult.Yes)
				{

					ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
					manipulaPessoa.Apagar();


				}
				else
				{
					txt_emailDeletar.Text = "";
					txt_buscarDeletar.Text = "";
					txt_nomeDeletar.Text = "";
					mask_foneDeletar.Text = "";
				}
			}
		}
	}
}
