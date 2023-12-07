namespace AgendaHenrique.View
{
	partial class BuscarNome
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
			dataGridView1 = new DataGridView();
			txt_id = new DataGridViewTextBoxColumn();
			txt_nome = new DataGridViewTextBoxColumn();
			txt_email = new DataGridViewTextBoxColumn();
			txt_fone = new DataGridViewTextBoxColumn();
			bnt_buscar = new Button();
			label5 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txt_id, txt_nome, txt_email, txt_fone });
			dataGridView1.Location = new Point(63, 202);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.Size = new Size(442, 150);
			dataGridView1.TabIndex = 0;
			// 
			// txt_id
			// 
			txt_id.HeaderText = "id";
			txt_id.Name = "txt_id";
			// 
			// txt_nome
			// 
			txt_nome.HeaderText = "nome";
			txt_nome.Name = "txt_nome";
			// 
			// txt_email
			// 
			txt_email.HeaderText = "email";
			txt_email.Name = "txt_email";
			// 
			// txt_fone
			// 
			txt_fone.HeaderText = "fone";
			txt_fone.Name = "txt_fone";
			// 
			// bnt_buscar
			// 
			bnt_buscar.Location = new Point(326, 132);
			bnt_buscar.Name = "bnt_buscar";
			bnt_buscar.Size = new Size(78, 27);
			bnt_buscar.TabIndex = 15;
			bnt_buscar.Text = "Buscar";
			bnt_buscar.UseVisualStyleBackColor = true;
			bnt_buscar.Click += bnt_buscar_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label5.Location = new Point(179, 77);
			label5.Name = "label5";
			label5.Size = new Size(67, 25);
			label5.TabIndex = 14;
			label5.Text = "Buscar";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(140, 122);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(148, 23);
			textBox1.TabIndex = 12;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(157, 9);
			label1.Name = "label1";
			label1.Size = new Size(178, 37);
			label1.TabIndex = 11;
			label1.Text = "Buscar Nome";
			// 
			// BuscarNome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(567, 450);
			Controls.Add(bnt_buscar);
			Controls.Add(label5);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Name = "BuscarNome";
			Text = "BuscarNome";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button bnt_buscar;
		private Label label5;
		private TextBox textBox1;
		private Label label1;
		private DataGridViewTextBoxColumn txt_id;
		private DataGridViewTextBoxColumn txt_nome;
		private DataGridViewTextBoxColumn txt_email;
		private DataGridViewTextBoxColumn txt_fone;
	}
}