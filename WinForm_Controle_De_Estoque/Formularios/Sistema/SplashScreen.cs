using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class SplashScreen : Form
    {
		//Instancia um objeto SoundPlayer e o associa a um arquivo wav
		System.Media.SoundPlayer hino = new System.Media.SoundPlayer(@"I:\TI\DS\WinForm_Controle_De_Estoque\Hino.wav");
        public SplashScreen()
        {
            InitializeComponent();
			hino.Play();//Começa a tocar a música
			EfectTime();//Chama o procedimento que irá ativar o Temporizador(timer)
		}
		private bool Efect = true;//variavel lógica
		private void SplashTimer_Tick(object sender, EventArgs e)
		{
			if (Efect)
			{
				this.Opacity -= 0.01D;//E Diminui a opacidade do form
									//equivale a This.Opacity = this.Opcatity - 0.01 
			}
			if (this.Opacity == 0)
			{
				Efect = false;
				SplashTimer_Tick.Enabled = false;//Desliga o Timer
				frmLogin frmlogin = new frmLogin();//Instancia um form Login
				frmlogin.Show();//Mostra o login
				hino.Stop();//Para a Música
				this.Hide();//Oculta o formulario Splash sem tira-lo da memória
			}
			private void EfectTime()
			{
				SplashTimer_Tick.Interval = 190; //define 190 milisegundos para a atuação do timer
				SplashTimer_Tick.Tick += new EventHandler(SplashTimer_Tick);//Dispara o evento Tick
				SplashTimer.Enabled = true;//ativa o timer
				this.Opacity = 1;//Define opacidade do form 100%
			}
		}
    }
}
