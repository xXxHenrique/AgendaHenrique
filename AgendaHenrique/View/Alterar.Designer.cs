namespace AgendaHenrique.View
{
	partial class Alterar
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
			label1 = new Label();
			textBox1 = new TextBox();
			txt_nomeAlterar = new TextBox();
			txt_emailAlterar = new TextBox();
			mask_foneAlterar = new MaskedTextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label2 = new Label();
			bnt_buscar = new Button();
			bnt_alterar = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(159, 21);
			label1.Name = "label1";
			label1.Size = new Size(201, 37);
			label1.TabIndex = 0;
			label1.Text = "Alterar Agenda";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(186, 107);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(148, 23);
			textBox1.TabIndex = 1;
			// 
			// txt_nomeAlterar
			// 
			txt_nomeAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_nomeAlterar.Location = new Point(186, 206);
			txt_nomeAlterar.Name = "txt_nomeAlterar";
			txt_nomeAlterar.Size = new Size(148, 29);
			txt_nomeAlterar.TabIndex = 2;
			// 
			// txt_emailAlterar
			// 
			txt_emailAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_emailAlterar.Location = new Point(186, 293);
			txt_emailAlterar.Name = "txt_emailAlterar";
			txt_emailAlterar.Size = new Size(148, 29);
			txt_emailAlterar.TabIndex = 3;
			// 
			// mask_foneAlterar
			// 
			mask_foneAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			mask_foneAlterar.Location = new Point(186, 379);
			mask_foneAlterar.Mask = "(99) 00000-0000";
			mask_foneAlterar.Name = "mask_foneAlterar";
			mask_foneAlterar.Size = new Size(148, 29);
			mask_foneAlterar.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(232, 255);
			label3.Name = "label3";
			label3.Size = new Size(57, 25);
			label3.TabIndex = 6;
			label3.Text = "email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.Location = new Point(232, 169);
			label4.Name = "label4";
			label4.Size = new Size(61, 25);
			label4.TabIndex = 7;
			label4.Text = "Nome";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label5.Location = new Point(232, 68);
			label5.Name = "label5";
			label5.Size = new Size(67, 25);
			label5.TabIndex = 8;
			label5.Text = "Buscar";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.Location = new Point(232, 341);
			label2.Name = "label2";
			label2.Size = new Size(51, 25);
			label2.TabIndex = 9;
			label2.Text = "Fone";
			// 
			// bnt_buscar
			// 
			bnt_buscar.Location = new Point(364, 134);
			bnt_buscar.Name = "bnt_buscar";
			bnt_buscar.Size = new Size(104, 36);
			bnt_buscar.TabIndex = 10;
			bnt_buscar.Text = "Buscar";
			bnt_buscar.UseVisualStyleBackColor = true;
			bnt_buscar.Click += bnt_buscar_Click;
			// 
			// bnt_alterar
			// 
			bnt_alterar.Location = new Point(364, 460);
			bnt_alterar.Name = "bnt_alterar";
			bnt_alterar.Size = new Size(102, 41);
			bnt_alterar.TabIndex = 11;
			bnt_alterar.Text = "Alterar";
			bnt_alterar.UseVisualStyleBackColor = true;
			bnt_alterar.Click += bnt_alterar_Click;
			// 
			// Alterar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(519, 523);
			Controls.Add(bnt_alterar);
			Controls.Add(bnt_buscar);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(mask_foneAlterar);
			Controls.Add(txt_emailAlterar);
			Controls.Add(txt_nomeAlterar);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Alterar";
			Text = "Alterar";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private TextBox txt_nomeAlterar;
		private TextBox txt_emailAlterar;
		private MaskedTextBox mask_foneAlterar;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label2;
		private Button bnt_buscar;
		private Button bnt_alterar;
	}
}