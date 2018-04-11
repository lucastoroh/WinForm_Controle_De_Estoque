using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WinForm_Controle_De_Estoque.Dados.DataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
		int vErros = 0;
		private void frmLogin_Enter(object sender, EventArgs e)
		{
			//btnOk_Click();
		}
		private bool CaixasOK()
		{
			if (txtLogin.Text == "")
			{
				errErro.SetError(txtLogin, "Informar o usuário");
				return false;
			}
			else
			{
				errErro.SetError(txtLogin, "");
			}
			if (txtSenha.Text == "")
			{
				errErro.SetError(txtSenha, "Informar a Senha");
				return false;
			}
			else
			{
				errErro.SetError(txtSenha, "");
			}
			return true;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (CaixasOK())
			{
				//Enquanto não temos o banco de dados
				if (txtLogin.Text != "Eu" || txtSenha.Text != "123")
				{
					MessageBox.Show("Usuário ou Senha inválidos");
					vErros++;
					if (vErros == 3)
					{
						MessageBox.Show("Número de Tentativas esgotado...");
						this.Close();
					}
				}
				else
				{
					//Properties.Settings.Default.NivelUsuarioLogado = 1;
					//Properties.Settings.Default.NivelUsuarioLogado = txtLogin.Text;
					MDI_Menu frmMenuPrincipal = new MDI_Menu();
					frmMenuPrincipal.Show();
					this.Close();
				}
			}
			//Quando Estivermos acessando o bancod e dados
			/*if (CaixasOK())
			{
				DataSet_Dados_Do_Banco.UsuarioDataTable dtUsuario;
				UsuarioTableAdapter taUsuario = new UsuarioTableAdapter();
				dtUsuario = taUsuario.VerificaNivel(txtNomeUsuario.Text, txtSenha.Text);
				if(dtUsuario.Rows.Count == 0)
				{
					MessageBox.Show("Usuário ou Senha inválidos");
					vErros++;
					if (vErros == 3)
					{
						MessageBox.Show("Número de Tentativas esgotado...");
						this.Close();
					}
				}
				else
				{
					Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
					Properties.Settings.Default.NivelUsuarioLogado = txtLogin.Text;
					MDI_Menu frmMenuPrincipal = new MDI_Menu();
					frmMenuPrincipal.Show();
					this.Close();
				}*/
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}
	}
}
