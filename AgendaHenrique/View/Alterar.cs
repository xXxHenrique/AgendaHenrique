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
	public partial class Alterar : Form
	{
		public Alterar()
		{
			InitializeComponent();
		}

		private void bnt_buscar_Click(object sender, EventArgs e)
		{
			Pessoa.Id = Convert.ToInt32(textBox1.Text);
			ManipulaPessoa manipula = new ManipulaPessoa();
			manipula.BuscarCodigo();

			txt_nomeAlterar.Text = Pessoa.Nome;
			txt_emailAlterar.Text = Pessoa.Email;
			mask_foneAlterar.Text = Pessoa.Fone;

		}

		private void bnt_alterar_Click(object sender, EventArgs e)
		{
			Pessoa.Id = Convert.ToInt32(textBox1.Text);


			if (textBox1.Text == "")
			{
				MessageBox.Show("Digite a matricula que deseja alterar.");
			}
			else
			{
				var resposta = MessageBox.Show("Deseja realmente alterar o usuário: " + txt_nomeAlterar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
				if (resposta == DialogResult.Yes)
				{
					Pessoa.Nome = txt_nomeAlterar.Text;
					Pessoa.Email = txt_emailAlterar.Text;
					Pessoa.Fone = mask_foneAlterar.Text;
					ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
					manipulaPessoa.Atualizar();

				}
				else
				{
					txt_emailAlterar.Text = "";
					txt_nomeAlterar.Text = "";
					mask_foneAlterar.Text = "";

				}
			}
		}
	}
}