namespace AgendaHenrique.View
{
	partial class Menu
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
			bnt_cadastrarMenu = new Button();
			bnt_AlterarMenu = new Button();
			bnt_DeletarMenu = new Button();
			label1 = new Label();
			bnt_CodigoMenu = new Button();
			bnt_NomeMenu = new Button();
			SuspendLayout();
			// 
			// bnt_cadastrarMenu
			// 
			bnt_cadastrarMenu.Location = new Point(43, 87);
			bnt_cadastrarMenu.Name = "bnt_cadastrarMenu";
			bnt_cadastrarMenu.Size = new Size(166, 63);
			bnt_cadastrarMenu.TabIndex = 0;
			bnt_cadastrarMenu.Text = "Cadastrar";
			bnt_cadastrarMenu.UseVisualStyleBackColor = true;
			bnt_cadastrarMenu.Click += button1_Click;
			// 
			// bnt_AlterarMenu
			// 
			bnt_AlterarMenu.Location = new Point(249, 87);
			bnt_AlterarMenu.Name = "bnt_AlterarMenu";
			bnt_AlterarMenu.Size = new Size(166, 63);
			bnt_AlterarMenu.TabIndex = 1;
			bnt_AlterarMenu.Text = "Alterar";
			bnt_AlterarMenu.UseVisualStyleBackColor = true;
			bnt_AlterarMenu.Click += bnt_AlterarMenu_Click;
			// 
			// bnt_DeletarMenu
			// 
			bnt_DeletarMenu.Location = new Point(149, 284);
			bnt_DeletarMenu.Name = "bnt_DeletarMenu";
			bnt_DeletarMenu.Size = new Size(166, 63);
			bnt_DeletarMenu.TabIndex = 3;
			bnt_DeletarMenu.Text = "Deletar";
			bnt_DeletarMenu.UseVisualStyleBackColor = true;
			bnt_DeletarMenu.Click += bnt_DeletarMenu_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(121, 9);
			label1.Name = "label1";
			label1.Size = new Size(213, 37);
			label1.TabIndex = 4;
			label1.Text = "Agenda Pessoas";
			// 
			// bnt_CodigoMenu
			// 
			bnt_CodigoMenu.Location = new Point(43, 178);
			bnt_CodigoMenu.Name = "bnt_CodigoMenu";
			bnt_CodigoMenu.Size = new Size(166, 63);
			bnt_CodigoMenu.TabIndex = 5;
			bnt_CodigoMenu.Text = "Buscar Por Codigo";
			bnt_CodigoMenu.UseVisualStyleBackColor = true;
			bnt_CodigoMenu.Click += bnt_CodigoMenu_Click;
			// 
			// bnt_NomeMenu
			// 
			bnt_NomeMenu.Location = new Point(249, 178);
			bnt_NomeMenu.Name = "bnt_NomeMenu";
			bnt_NomeMenu.Size = new Size(166, 63);
			bnt_NomeMenu.TabIndex = 6;
			bnt_NomeMenu.Text = "Buscar Por Nome";
			bnt_NomeMenu.UseVisualStyleBackColor = true;
			bnt_NomeMenu.Click += bnt_NomeMenu_Click;
			// 
			// Menu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(467, 410);
			Controls.Add(bnt_NomeMenu);
			Controls.Add(bnt_CodigoMenu);
			Controls.Add(label1);
			Controls.Add(bnt_DeletarMenu);
			Controls.Add(bnt_AlterarMenu);
			Controls.Add(bnt_cadastrarMenu);
			Name = "Menu";
			Text = "Menu";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button bnt_cadastrarMenu;
		private Button bnt_AlterarMenu;
		private Button bnt_DeletarMenu;
		private Label label1;
		private Button bnt_CodigoMenu;
		private Button bnt_NomeMenu;
	}
}