using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmTela : Form
    {
        //Recebe o valor da dificuldade
        public frmTela(int valor)
        {
            InitializeComponent();

            if (valor == 0)
            {
                valor = 100;
            }
            else
            {
                picRaquete.Height = valor;
            }
        }

        int velocidade = 10;
        int resultado;
        bool topo, esquerda;

        //Inicia O JOGO
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            picBola.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
        }

        private void ResetGame()
        {
            Random rand = new Random();
            picBola.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            resultado = 0;
            this.Text = "0";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mensagem de derrota.
            if (picBola.Left > picRaquete.Left)
            {
                timer1.Enabled = false; MessageBox.Show("Você perdeu e ficou com:  " + resultado.ToString() + " Pontos");
                resultado = 0;
                ResetGame();
            }

            //Verifica se a bolinha encostou em algon nas paredes, ou na raquete.
            if (picBola.Left + picBola.Width >= picRaquete.Left && picBola.Left + picBola.Width <= picRaquete.Left + picRaquete.Width
                && picBola.Top + picBola.Height >= picRaquete.Top && picBola.Top + picBola.Height <= picRaquete.Top + picRaquete.Height + picBola.Height)
            {
                esquerda = false;
                resultado += 1;
                lblPontos.Text = resultado.ToString();
            }
            //Controle de Velocidade Esquerda
            if (esquerda)
            {
                picBola.Left += velocidade;
            }
            else
            {
                picBola.Left -= velocidade;
            }

            //Controle de Velocidade Topo
            if (topo)
            {
                picBola.Top += velocidade;
            }
            else
            {
                picBola.Top -= velocidade;
            }

            if (picBola.Top >= this.Height - 50)
            {
                topo = false;
            }

            if (picBola.Top <= 0)
            {
                topo = true;
            }

            if (picBola.Left <= 0)
            {
                esquerda = true;
            }

            //Impede de entrar dentro do painel
            if (picBola.Bounds.IntersectsWith(pnlBotoes.Bounds))
            {
                picBola.Top -= 10;
                topo = !topo;
            }
        }
        //Alterar a dificuldade
        private void button1_Click(object sender, EventArgs e)
        {
            frmDificuldade frmDificuldade = new frmDificuldade();
            frmDificuldade.Show();
            this.Close();
            timer1.Enabled = false;
        }
        //Sair do Jogo
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Move a barrinha conforme o movimento do mouse
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picRaquete.Top = e.Y;

            if (picRaquete.Bottom > pnlBotoes.Top)
            {
                picRaquete.Top = pnlBotoes.Top - picRaquete.Height;
            }
        }
    }
}
