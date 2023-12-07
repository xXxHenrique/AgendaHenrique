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
	public partial class Cadastrar : Form
	{
		public Cadastrar()
		{
			InitializeComponent();
		}

		private void bnt_bsucarCadastro_Click(object sender, EventArgs e)
		{

		}

		private void bnt_cadastrar_Click(object sender, EventArgs e)
		{
			Pessoa.Nome = txt_cadastrarr.Text;
			Pessoa.Email = txt_email.Text;
			Pessoa.Fone = mask_fone.Text;

			ManipulaPessoa manipulaPessoa = new ManipulaPessoa();
			manipulaPessoa.cadastrar();
		}
	}
}
