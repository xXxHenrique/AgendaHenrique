namespace AgendaHenrique.View
{
	partial class Apagar
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
			bnt_Deletar = new Button();
			bnt_buscar = new Button();
			label2 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			mask_foneDeletar = new MaskedTextBox();
			txt_emailDeletar = new TextBox();
			txt_nomeDeletar = new TextBox();
			txt_buscarDeletar = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// bnt_Deletar
			// 
			bnt_Deletar.Location = new Point(318, 452);
			bnt_Deletar.Name = "bnt_Deletar";
			bnt_Deletar.Size = new Size(102, 41);
			bnt_Deletar.TabIndex = 22;
			bnt_Deletar.Text = "Deletar";
			bnt_Deletar.UseVisualStyleBackColor = true;
			bnt_Deletar.Click += bnt_Deletar_Click_1;
			// 
			// bnt_buscar
			// 
			bnt_buscar.Location = new Point(318, 126);
			bnt_buscar.Name = "bnt_buscar";
			bnt_buscar.Size = new Size(104, 36);
			bnt_buscar.TabIndex = 21;
			bnt_buscar.Text = "Buscar";
			bnt_buscar.UseVisualStyleBackColor = true;
			bnt_buscar.Click += bnt_buscar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.Location = new Point(186, 333);
			label2.Name = "label2";
			label2.Size = new Size(51, 25);
			label2.TabIndex = 20;
			label2.Text = "Fone";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label5.Location = new Point(186, 60);
			label5.Name = "label5";
			label5.Size = new Size(67, 25);
			label5.TabIndex = 19;
			label5.Text = "Buscar";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.Location = new Point(186, 161);
			label4.Name = "label4";
			label4.Size = new Size(61, 25);
			label4.TabIndex = 18;
			label4.Text = "Nome";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(186, 247);
			label3.Name = "label3";
			label3.Size = new Size(57, 25);
			label3.TabIndex = 17;
			label3.Text = "email";
			// 
			// mask_foneDeletar
			// 
			mask_foneDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			mask_foneDeletar.Location = new Point(140, 371);
			mask_foneDeletar.Mask = "(99) 00000-0000";
			mask_foneDeletar.Name = "mask_foneDeletar";
			mask_foneDeletar.Size = new Size(148, 29);
			mask_foneDeletar.TabIndex = 16;
			// 
			// txt_emailDeletar
			// 
			txt_emailDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_emailDeletar.Location = new Point(140, 285);
			txt_emailDeletar.Name = "txt_emailDeletar";
			txt_emailDeletar.Size = new Size(148, 29);
			txt_emailDeletar.TabIndex = 15;
			// 
			// txt_nomeDeletar
			// 
			txt_nomeDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_nomeDeletar.Location = new Point(140, 198);
			txt_nomeDeletar.Name = "txt_nomeDeletar";
			txt_nomeDeletar.Size = new Size(148, 29);
			txt_nomeDeletar.TabIndex = 14;
			// 
			// txt_buscarDeletar
			// 
			txt_buscarDeletar.Location = new Point(140, 99);
			txt_buscarDeletar.Name = "txt_buscarDeletar";
			txt_buscarDeletar.Size = new Size(148, 23);
			txt_buscarDeletar.TabIndex = 13;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(113, 13);
			label1.Name = "label1";
			label1.Size = new Size(205, 37);
			label1.TabIndex = 12;
			label1.Text = "Apagar Agenda";
			// 
			// Apagar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(464, 496);
			Controls.Add(bnt_Deletar);
			Controls.Add(bnt_buscar);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(mask_foneDeletar);
			Controls.Add(txt_emailDeletar);
			Controls.Add(txt_nomeDeletar);
			Controls.Add(txt_buscarDeletar);
			Controls.Add(label1);
			Name = "Apagar";
			Text = "Apagar";
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
		private TextBox txt_nomeDeletar;
		private TextBox txt_buscarDeletar;
		private Label label1;
	}
}