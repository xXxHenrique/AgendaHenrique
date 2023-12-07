namespace AgendaHenrique.View
{
	partial class Cadastrar
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
			bnt_cadastrar = new Button();
			label2 = new Label();
			label4 = new Label();
			label3 = new Label();
			mask_fone = new MaskedTextBox();
			txt_email = new TextBox();
			txt_cadastrarr = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// bnt_cadastrar
			// 
			bnt_cadastrar.Location = new Point(351, 361);
			bnt_cadastrar.Name = "bnt_cadastrar";
			bnt_cadastrar.Size = new Size(102, 41);
			bnt_cadastrar.TabIndex = 22;
			bnt_cadastrar.Text = "Cadastrar";
			bnt_cadastrar.UseVisualStyleBackColor = true;
			bnt_cadastrar.Click += bnt_cadastrar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.Location = new Point(78, 296);
			label2.Name = "label2";
			label2.Size = new Size(51, 25);
			label2.TabIndex = 20;
			label2.Text = "Fone";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.Location = new Point(78, 100);
			label4.Name = "label4";
			label4.Size = new Size(61, 25);
			label4.TabIndex = 18;
			label4.Text = "Nome";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(78, 213);
			label3.Name = "label3";
			label3.Size = new Size(57, 25);
			label3.TabIndex = 17;
			label3.Text = "email";
			// 
			// mask_fone
			// 
			mask_fone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			mask_fone.Location = new Point(175, 296);
			mask_fone.Mask = "(99) 00000-0000";
			mask_fone.Name = "mask_fone";
			mask_fone.Size = new Size(148, 29);
			mask_fone.TabIndex = 16;
			// 
			// txt_email
			// 
			txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_email.Location = new Point(175, 209);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(148, 29);
			txt_email.TabIndex = 15;
			// 
			// txt_cadastrarr
			// 
			txt_cadastrarr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_cadastrarr.Location = new Point(175, 96);
			txt_cadastrarr.Name = "txt_cadastrarr";
			txt_cadastrarr.Size = new Size(148, 29);
			txt_cadastrarr.TabIndex = 14;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(148, 9);
			label1.Name = "label1";
			label1.Size = new Size(234, 37);
			label1.TabIndex = 12;
			label1.Text = "Cadastrar Agenda";
			// 
			// Cadastrar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(488, 523);
			Controls.Add(bnt_cadastrar);
			Controls.Add(label2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(mask_fone);
			Controls.Add(txt_email);
			Controls.Add(txt_cadastrarr);
			Controls.Add(label1);
			Name = "Cadastrar";
			Text = "Cadastrar";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button bnt_cadastrar;
		private Label label2;
		private Label label4;
		private Label label3;
		private MaskedTextBox mask_fone;
		private TextBox txt_email;
		private TextBox txt_cadastrarr;
		private Label label1;
	}
}