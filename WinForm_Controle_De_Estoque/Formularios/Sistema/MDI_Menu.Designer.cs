namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
	partial class MDI_Menu
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.sistemaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(638, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.cadastrosToolStripMenuItem.Text = "Cadastros";
			// 
			// movimentosToolStripMenuItem
			// 
			this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
			this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.movimentosToolStripMenuItem.Text = "Movimentos";
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.relatóriosToolStripMenuItem.Text = "Relatórios";
			// 
			// janelasToolStripMenuItem
			// 
			this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
			this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.janelasToolStripMenuItem.Text = "Janelas";
			// 
			// sistemaToolStripMenuItem
			// 
			this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.sistemaToolStripMenuItem.Text = "Sistema";
			// 
			// MDI_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 472);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDI_Menu";
			this.Text = "MDI_Menu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDI_Menu_FormClosing);
			this.Load += new System.EventHandler(this.MDI_Menu_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDI_Menu_KeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
	}
}