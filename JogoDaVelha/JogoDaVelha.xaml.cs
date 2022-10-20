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
        int numerodeJogadas = 0;
        int velha = 0;
        int jogadorGanha = 0;
        int computadorGanha = 0;

        public MainWindow()
        {
            InitializeComponent();
            //Deixa vazio o campo vencedor
            txtJogadorVencedor.Text = "";
            }


        public void IniciarNovoJogo(object sender, RoutedEventArgs e)
        {
            //Volta ao início
            TelaEmBranco();
            //Três segundos devem ser aguardados até começar outro jogo
            txtJogadorVencedor.Text = "";
            if (jogadorVencedor != "")
            {
                simboloJogadorDaVez = jogadorVencedor;
                jogadorVencedor = "";
            }
        }


        public void TrocarJogadorDaVez()
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
        public void Defesa()
        {

        }

        //Jogada aleatória
        public void Aleatorio()
        {

        }

        // Ver quem venceu
        public void checagemVencedor()
        {

        }

        //Clicar na imagem 1x1
        public void Click1x1(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco1x1);
        }

        //Clicar na imagem 1x2
        public void Click1x2(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco1x2);
        }


        //Clicar na imagem 1x3
        public void Click1x3(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco1x3);
        }

        //Clicar na imagem 2x1
        public void Click2x1(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco2x1);
        }

        //Clicar na imagem 2x2
        public void Click2x2(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco2x2);
        }

        //Clicar na imagem 2x3
        public void Click2x3(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco2x3);
        }

        //Clicar na imagem 3x1
        public void Click3x1(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco3x1);
        }

        //Clicar na imagem 3x2
        public void Click3x2(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco3x2);
        }

        //Clicar na imagem 3x3
        public void Click3x3(object sender, MouseButtonEventArgs e)
        {
            PreencheSimboloDaVezDoJogador(branco3x3);
        }

        public void PreencheSimboloDaVezDoJogador(Image imagemSelecionada)
        {
            //Verifico se houve um vencedor e se houve menos que 9 jogadas 
            if (jogadorVencedor == "" && numerodeJogadas < 9)
            {
                //Verifico se o espaço está vazio
                if (imagemSelecionada.IsVisible)
                {
                    //Apago o espaço em branco
                    imagemSelecionada.Visibility = Visibility.Collapsed;
                    //Aparece o símbolo do jogador
                    if (simboloJogadorDaVez == "X")
                    {
                        //Trocar o jogador 1x1
                        branco1x1.Visibility = Visibility.Collapsed;
                        img1x1XBranco.Visibility = Visibility.Visible;
                    }
                    //Inverter o jogador
                    else
                    {
                        branco1x1.Visibility = Visibility.Collapsed;
                        imgO1x1.Visibility = Visibility.Visible;
                    }
                    //Computo uma jogada.
                    numerodeJogadas++;

                    // Verifica se houve vitória do X
                    VerificaVencedor();

                    // Verifico se ainda não houve vencedor
                    if (jogadorVencedor == "")
                    {
                        //Troco a vez do jogador
                        TrocarJogadorDaVez();
                    }
                }
            }
        }

        public void VerificaVencedor()
        {
            // Verifico se a coluna esquerda houve vencedor
            if (img1x1XBranco.Visibility == Visibility.Visible && img2x1XBranco.Visibility == Visibility.Visible && img3x1XBranco.Visibility == Visibility.Visible
                || imgO1x1.Visibility == Visibility.Visible && imgO2x1.Visibility == Visibility.Visible && imgO3x1.Visibility == Visibility.Visible)
            {
                //Chama o método para pintar os botões

                // Atribuo o jogador da vez a variavel que informa o vencedor
                jogadorVencedor = simboloJogadorDaVez;
            }

            // Verifico se a coluna do meio houve vencedor
            else if (img1x2XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x2XBranco.Visibility == Visibility.Visible
                || imgO1x2.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x2.Visibility == Visibility.Visible)
            {

                jogadorVencedor = simboloJogadorDaVez;
            }
            // Verifico se a coluna direita houve vencedor
            else if (img1x3XBranco.Visibility == Visibility.Visible && img2x3XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible
                || imgO1x3.Visibility == Visibility.Visible && imgO2x3.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {

                jogadorVencedor = simboloJogadorDaVez;
            }
            // Verifico se a linha superior houve vencedor
            else if (img1x1XBranco.Visibility == Visibility.Visible && img1x2XBranco.Visibility == Visibility.Visible && img1x3XBranco.Visibility == Visibility.Visible
                || imgO1x1.Visibility == Visibility.Visible && imgO1x2.Visibility == Visibility.Visible && imgO1x3.Visibility == Visibility.Visible)
            {

                jogadorVencedor = simboloJogadorDaVez;
            }
            // Verifico se a linha do meio houve vencedor
            else if (img2x1XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img2x3XBranco.Visibility == Visibility.Visible
                || imgO2x1.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO2x3.Visibility == Visibility.Visible)
            {

                jogadorVencedor = simboloJogadorDaVez;
            }
            // Verifico se a linha inferior houve vencedor
            else if (img3x1XBranco.Visibility == Visibility.Visible && img3x2XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible
                || imgO3x1.Visibility == Visibility.Visible && imgO3x2.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {

                jogadorVencedor = simboloJogadorDaVez;
            }
            // Verifico se a diagonal esquerda houve vencedor
            else if (img1x1XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible
                || imgO1x1.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {

                jogadorVencedor = simboloJogadorDaVez;
            }
            // Verifico se a diagonal direita houve vencedor
            else if (img1x3XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x1XBranco.Visibility == Visibility.Visible
                || imgO1x3.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x1.Visibility == Visibility.Visible)
            {
                jogadorVencedor = simboloJogadorDaVez;
            }
            // Se não houver vencedor, será velha.
            else
            {
                //Informo que deu velha o jogo.
                InformaVelha();
            }

            //Informo se houve vencedor
        }

            private void TelaEmBranco()
        {
            //Reinicia tudo
            branco1x1.Visibility = Visibility.Visible;
            branco1x2.Visibility = Visibility.Visible;
            branco1x3.Visibility = Visibility.Visible;
            branco2x1.Visibility = Visibility.Visible;
            branco2x2.Visibility = Visibility.Visible;
            branco2x3.Visibility = Visibility.Visible;
            branco3x1.Visibility = Visibility.Visible;
            branco3x2.Visibility = Visibility.Visible;
            branco3x3.Visibility = Visibility.Visible;
        }

        private void InformaVelha()
        {
            // Verifico se todos os botões foram jogados
            if (numerodeJogadas == 9)
            {
                // Chama o método para pintar os botões que resultou em velha
   
                // Informo no campo que houve velha
                txtVencedor.Visibility = Visibility.Collapsed;
                txtJogadorVencedor.Text = "Deu velha!";
            }
        }

    }
}
