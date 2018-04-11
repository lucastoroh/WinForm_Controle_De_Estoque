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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.staHora = new System.Windows.Forms.ToolStripStatusLabel();
			this.staNum = new System.Windows.Forms.ToolStripStatusLabel();
			this.staCaps = new System.Windows.Forms.ToolStripStatusLabel();
			this.staUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
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
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staHora,
            this.staNum,
            this.staCaps,
            this.staUsuario});
			this.statusStrip1.Location = new System.Drawing.Point(0, 450);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(638, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// staHora
			// 
			this.staHora.Name = "staHora";
			this.staHora.Size = new System.Drawing.Size(40, 17);
			this.staHora.Text = "HORA";
			// 
			// staNum
			// 
			this.staNum.Name = "staNum";
			this.staNum.Size = new System.Drawing.Size(35, 17);
			this.staNum.Text = "NUM";
			// 
			// staCaps
			// 
			this.staCaps.Name = "staCaps";
			this.staCaps.Size = new System.Drawing.Size(36, 17);
			this.staCaps.Text = "CAPS";
			// 
			// staUsuario
			// 
			this.staUsuario.Name = "staUsuario";
			this.staUsuario.Size = new System.Drawing.Size(0, 17);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MDI_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 472);
			this.Controls.Add(this.statusStrip1);
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
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
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
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel staHora;
		private System.Windows.Forms.ToolStripStatusLabel staNum;
		private System.Windows.Forms.ToolStripStatusLabel staCaps;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel staUsuario;
	}
}