using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JogoDaVelha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //O jogador da vez.
        string simboloJogadorDaVez = "X";
        //Quem venceu.
        string jogadorVencedor = "";
        //Verde para o vencedor
        SolidColorBrush corDaVitoria = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //Vermelho para o perdedor/empate
        SolidColorBrush corDaVelha = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

        //criar as crescentes para resultado
        int xGanha = 0;
        int oGanha = 0;
        int empate = 0;
        int rodada = 0;
        int vencedor = 0;

        public MainWindow()
        {
            InitializeComponent();

              //Método para dizer o jogador da vez
              InformaJogadorDaVez(simboloJogadorDaVez);
            }


        private void IniciarNovoJogo(object sender, RoutedEventArgs e)
        {
            //Chama o método que pinta os botões para a cor inicial
            PintarBotoesDeNovoJogo();
            numeroDeJogadas = 0;
            

            txtResultadoVencedor.Text = "";
            if (jogadorVencedor != "")
            {
                simboloJogadorDaVez = jogadorVencedor;
                jogadorVencedor = "";
            }
            InformaJogadorDaVez(simboloJogadorDaVez);
        }


        private void TrocarJogadorDaVez()
        {
            //Verifico qual o jogador atual
            if (simboloJogadorDaVez == "X")
            {
                //Trocar o jogador
                simboloJogadorDaVez = "O";
            }
            //Inverter o jogador
            else
            {
                simboloJogadorDaVez = "X";
            }

        }

            //Para ganhar
            private void Ataque()
        {
        }

        //Para impedir o adversário de vencer
        private void Defesa()
        {
        }

        //Jogada aleatória
        private void Aleatorio()
        {
        }

        // Ver quem venceu
        private void checagemVencedor()
        {
        }

        //Clicar na imagem 1x1
        private void Click1x1(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 1x2
        private void Click1x2(object sender, MouseButtonEventArgs e)
        {

        }


        //Clicar na imagem 1x3
        private void Click1x3(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 2x1
        private void Click2x1(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 2x2
        private void Click2x2(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 2x3
        private void Click2x3(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 3x1
        private void Click3x1(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 3x2
        private void Click3x2(object sender, MouseButtonEventArgs e)
        {

        }

        //Clicar na imagem 3x3
        private void Click3x3(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
