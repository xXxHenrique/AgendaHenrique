namespace AgendaHenrique.View
{
	partial class BuscarCod
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			bnt_buscar = new Button();
			label2 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			txt_nomecodigo = new TextBox();
			txt_buscarDeletar = new TextBox();
			label1 = new Label();
			txt_emailBuscar = new TextBox();
			masked_foneBuscar = new MaskedTextBox();
			SuspendLayout();
			// 
			// bnt_buscar
			// 
			bnt_buscar.Location = new Point(340, 122);
			bnt_buscar.Name = "bnt_buscar";
			bnt_buscar.Size = new Size(104, 36);
			bnt_buscar.TabIndex = 32;
			bnt_buscar.Text = "Buscar";
			bnt_buscar.UseVisualStyleBackColor = true;
			bnt_buscar.Click += bnt_buscar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.Location = new Point(208, 329);
			label2.Name = "label2";
			label2.Size = new Size(51, 25);
			label2.TabIndex = 31;
			label2.Text = "Fone";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label5.Location = new Point(172, 57);
			label5.Name = "label5";
			label5.Size = new Size(138, 25);
			label5.TabIndex = 30;
			label5.Text = "Digite o Código";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.Location = new Point(208, 157);
			label4.Name = "label4";
			label4.Size = new Size(61, 25);
			label4.TabIndex = 29;
			label4.Text = "Nome";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(208, 243);
			label3.Name = "label3";
			label3.Size = new Size(57, 25);
			label3.TabIndex = 28;
			label3.Text = "email";
			// 
			// txt_nomecodigo
			// 
			txt_nomecodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_nomecodigo.Location = new Point(162, 194);
			txt_nomecodigo.Name = "txt_nomecodigo";
			txt_nomecodigo.Size = new Size(148, 29);
			txt_nomecodigo.TabIndex = 25;
			// 
			// txt_buscarDeletar
			// 
			txt_buscarDeletar.Location = new Point(162, 105);
			txt_buscarDeletar.Name = "txt_buscarDeletar";
			txt_buscarDeletar.Size = new Size(148, 23);
			txt_buscarDeletar.TabIndex = 24;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(135, 9);
			label1.Name = "label1";
			label1.Size = new Size(237, 37);
			label1.TabIndex = 23;
			label1.Text = "Buscar Por Codigo";
			// 
			// txt_emailBuscar
			// 
			txt_emailBuscar.Location = new Point(162, 288);
			txt_emailBuscar.Name = "txt_emailBuscar";
			txt_emailBuscar.Size = new Size(148, 23);
			txt_emailBuscar.TabIndex = 33;
			// 
			// masked_foneBuscar
			// 
			masked_foneBuscar.Location = new Point(162, 381);
			masked_foneBuscar.Mask = "(99) 00000-0000";
			masked_foneBuscar.Name = "masked_foneBuscar";
			masked_foneBuscar.Size = new Size(148, 23);
			masked_foneBuscar.TabIndex = 34;
			// 
			// BuscarCod
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(476, 501);
			Controls.Add(masked_foneBuscar);
			Controls.Add(txt_emailBuscar);
			Controls.Add(bnt_buscar);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txt_nomecodigo);
			Controls.Add(txt_buscarDeletar);
			Controls.Add(label1);
			Name = "BuscarCod";
			Text = "BuscarCod";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button bnt_Deletar;
		private Button bnt_buscar;
		private Label label2;
		private Label label5;
		private Label label4;
		private Label label3;
		private MaskedTextBox mask_foneDeletar;
		private TextBox txt_emailDeletar;
		private TextBox txt_nomecodigo;
		private TextBox txt_buscarDeletar;
		private Label label1;
		private TextBox txt_emailBuscar;
		private MaskedTextBox masked_foneBuscar;
	}
}