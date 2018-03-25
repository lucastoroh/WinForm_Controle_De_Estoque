using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Modelos
{
	public partial class frmBase : Form
	{
		public frmBase()
		{
			InitializeComponent();
		}
		public int nCodGenerico;
		public DataTable dtGenerico = new DataTable();

		public enum StatusCadastro
		{
			scIncluindo,
			scConsultando,
			scAlterando
		}
		public StatusCadastro sStatus;
		private void LimpaControles()
		{
			foreach(ControlEventArgs ctr in this.groupBox1.Controls)
			{
				if(ctr is TextBox)
					(ctr as TextBox).Text = "";
				if (ctr is ComboBox)
					(ctr as ComboBox).SelectedIndex = -1;
				if (ctr is ListBox)
					(ctr as ListBox).SelectedIndex= -1;
				if (ctr is RadioButton)
					(ctr as RadioButton).Checked = false;
				if (ctr is CheckBox)
					(ctr as CheckBox).Checked = false;
			}
		}
		private void HabilitaDesabilitaControles(bool bValue)
		{
			//habilitar os botões

			//Novo = será habilitado somente quando for navegação
			btnIncluir.Enabled = (sStatus == StatusCadastro.scConsultando);
			//Salvar
			btnGravar.Enabled = (sStatus == StatusCadastro.scAlterando || sStatus == StatusCadastro.scIncluindo);
			//Excluir
			btnExcluir.Enabled = (sStatus == StatusCadastro.scConsultando);
			//Localizar
			btnPesquisar.Enabled = (sStatus == StatusCadastro.scConsultando);
			//Cancelar
			btnCancelar.Visible = (sStatus == StatusCadastro.scAlterando || sStatus == StatusCadastro.scIncluindo);
			//Fechar
			btnFechar.Enabled = true;
		}
		public virtual void CarregaValores() { }
		public virtual void Atualiza_Grid() { }
		public virtual bool Salvar()
		{
			return false;
		}
		public virtual bool Excluir()
		{
			return false;
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmBase_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void btnIncluir_Click(object sender, EventArgs e)
		{
			LimpaControles();
			sStatus = StatusCadastro.scIncluindo;
			lblModo.Text = "Incluindo";
			HabilitaDesabilitaControles(true);
			TabControl.SelectTab(1);
			LimpaControles();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(0);
			sStatus = StatusCadastro.scConsultando;
			lblModo.Text = "Consultando";
			HabilitaDesabilitaControles(true);
		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(TabControl.SelectedIndex == 1)
			{
				if(sStatus == StatusCadastro.scIncluindo)
				{
					lblModo.Text = "Incluindo";
					LimpaControles();
					TabControl.SelectNextControl(groupBox1 = true);
				}
				else
				{
					lblModo.Text = "Alterando";
					sStatus = StatusCadastro.scAlterando;
				}
			}
			else
			{
				sStatus = StatusCadastro.scConsultando;
				lblModo.Text = "Consultando";
			}
			HabilitaDesabilitaControles(true);
		}

		private void dgvGrid_DoubleClick(object sender, EventArgs e)
		{
			CarregaValores();
			if(dgvGrid.Rows.Count != 0)
			{
				nCodGenerico = (int)dgvGrid.CurrentRow.Cells[0].Value;
			}
			TabControl.SelectTab(1);
		}

		private void dgvGrid_SelectionChanged(object sender, EventArgs e)
		{
			if(dgvGrid.Rows.Count != 0)
			{
				CarregaValores();
				nCodGenerico = (int)dgvGrid.CurrentRow.Cells[0].Value;
			}
		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
			if (Salvar())
			{
				Atualiza_Grid();
				//Quando for inclusão, seleciona a ultima linha do DataGridView
				if(sStatus == StatusCadastro.scIncluindo)
				{
					dataSetDadosDoBancoBindingSource.Position = dataSetDadosDoBancoBindingSouce.Count - 1;
				}
				sStatus = StatusCadastro.scConsultando;
				HabilitaDesabilitaControles(false);
				//MessageBox.Show("Registro salvo com sucesso", "Aviso do Sistema", MessageBoxButtons.OK );
			}
			else
			{
				MessageBox.Show("O registro não foi salvo, por favor verifique os erros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			}
			TabControl.SelectedTab(0);
		}

	}
}
