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

        //criar a crescentes para resultado
        int numerodeJogadas = 0;
        int VitoriasJogador = 0;
        int VitoriasComputador = 0;

        public MainWindow()
        {
            InitializeComponent();
            txtJogadorVencedor.Text = "";
        }

        
        public void IniciarNovoJogo(object sender, RoutedEventArgs e)
        {
            TelaEmBranco();
            //Três segundos devem ser aguardados até começar outro jogo
            txtJogadorVencedor.Text = "";

        }


        //O no 1x1
        public bool OA1()
        {
            if (imgO1x1.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        //O no 1x2
        public bool OA2()
        {
            if (imgO1x2.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 1x3
        public bool OA3()
        {
            if (imgO1x3.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 2x1
        public bool OB1()
        {
            if (imgO2x1.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 2x2
        public bool OB2()
        {
            if (imgO2x2.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 2x3
        public bool OB3()
        {
            if (imgO2x3.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 3x1
        public bool OC1()
        {
            if (imgO3x1.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 3x2
        public bool OC2()
        {
            if (imgO3x2.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //O no 3x3
        public bool OC3()
        {
            if (imgO3x3.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //---------------------------------------------------------------------------------
        //X no 1x1
        public bool XA1()
        {
            if (img1x1XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 1x2
        public bool XA2()
        {
            if (img1x2XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 1x3
        public bool XA3()
        {
            if (img1x3XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 2x1
        public bool XB1()
        {
            if (img2x1XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 2x2
        public bool XB2()
        {
            if (img2x2XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 2X3
        public bool XB3()
        {
            if (img2x3XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 3x1
        public bool XC1()
        {
            if (img3x1XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 3x2
        public bool XC2()
        {
            if (img3x2XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //X no 3x3
        public bool XC3()
        {
            if (img3x3XBranco.Visibility != Visibility.Visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

//---------------------------------------------------------------------------------

        //Clicar na imagem 1x1
        public void Click1x1(object sender, MouseButtonEventArgs e)
        {
            if (OA1() == false)
            {
                branco1x1.Visibility = Visibility.Hidden;
                img1x1XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();            }
        }

        //Clicar na imagem 1x2
        public void Click1x2(object sender, MouseButtonEventArgs e)
        {
            if (OA2() == false)
            {
                branco1x2.Visibility = Visibility.Hidden;
                img1x2XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();
            }
        }


        //Clicar na imagem 1x3
        public void Click1x3(object sender, MouseButtonEventArgs e)
        {
            if (OA3() == false)
            {
                branco1x3.Visibility = Visibility.Hidden;
                img1x3XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor(); 
                JogadaComputador();
            }
        }

        //Clicar na imagem 2x1
        public void Click2x1(object sender, MouseButtonEventArgs e)
        {
            if (OB1() == false)
            {
                branco2x1.Visibility = Visibility.Hidden;
                img2x1XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();               
            }
        }

        //Clicar na imagem 2x2
        public void Click2x2(object sender, MouseButtonEventArgs e)
        {
            if (OB2() == false)
            {
                branco2x2.Visibility = Visibility.Hidden;
                img2x2XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();
            }
        }

        //Clicar na imagem 2x3
        public void Click2x3(object sender, MouseButtonEventArgs e)
        {
            if (OB3() == false)
            {
                branco2x3.Visibility = Visibility.Hidden;
                img2x3XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();
            }
        }

        //Clicar na imagem 3x1
        public void Click3x1(object sender, MouseButtonEventArgs e)
        {
            if (OC1() == false)
            {
                branco3x1.Visibility = Visibility.Hidden;
                img3x1XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();
            }
        }


        //Clicar na imagem 3x2
        public void Click3x2(object sender, MouseButtonEventArgs e)
        {
            if (OC2() == false)
            {
                branco3x2.Visibility = Visibility.Hidden;
                img3x2XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
                JogadaComputador();
            }
        }

        //Clicar na imagem 3x3
        public void Click3x3(object sender, MouseButtonEventArgs e)
        {
            if (OC3() == false)
            {
                branco3x3.Visibility = Visibility.Hidden;
                img3x3XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();             
                JogadaComputador();
            }
        }

        //Jogada do computador
        public void JogadaComputador()
        {
            bool computadorJogando = true;
            while (computadorJogando == true)
            {
                Random jogadaO = new Random();
                int computadorJoga = jogadaO.Next(1,9);

                switch (computadorJoga)
                {
                    case 1:
                        if (XA1() == false)
                        {
                            imgO1x1.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 2:
                        if (XA2() == false)
                        {
                            imgO1x2.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 3:
                        if (XA3() == false)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 4:
                        if (XB1() == false)
                        {
                            imgO2x1.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 5:
                        if (XB2() == false)
                        {
                            imgO2x2.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 6:
                        if (XB3() == false)
                        {
                            imgO2x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 7:
                        if (XC1() == false)
                        {
                            imgO3x1.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 8:
                        if (XC2() == false)
                        {
                            imgO3x2.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 9:
                        if (XC3() == false)
                        {
                            imgO3x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                }
                break;
            }
      
        }


        public void checagemVencedor()
        {
            // Verifico se a coluna esquerda houve vencedor X
            if (img1x1XBranco.Visibility == Visibility.Visible && img2x1XBranco.Visibility == Visibility.Visible && img3x1XBranco.Visibility == Visibility.Visible)
            {
                //Chama o método para pintar as imagens

                // Atribuo o jogador da vez a variavel que informa o vencedor
                txtJogadorVencedor.Text = "Vitória do X!";
                AumentaVitoriasJogador();
                VitoriasJogador++;
            }

            // Verifico se a coluna esquerda houve vencedor O
            
            else if (imgO1x1.Visibility == Visibility.Visible && imgO2x1.Visibility == Visibility.Visible && imgO3x1.Visibility == Visibility.Visible)
            {
                //Chama o método para pintar as imagens

                // Atribuo o jogador da vez a variavel que informa o vencedor
                AumentaVitoriasComputador();
                VitoriasComputador++;
                txtJogadorVencedor.Text = "Vitória do O!";

            }
//----------------------------------------------------------------------------------------------------
            // Verifico se a coluna do meio houve vencedor X
            else if (img1x2XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x2XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                txtJogadorVencedor.Text = "Vitória do X!";
                AumentaVitoriasJogador();
                TelaEmBranco();
            }
            // Verifico se a coluna do meio houve vencedor O
            else if (imgO1x2.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x2.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }
            
//----------------------------------------------------------------------------------------------------
            // Verifico se a coluna direita houve vencedor X
            else if (img1x3XBranco.Visibility == Visibility.Visible && img2x3XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                txtJogadorVencedor.Text = "Vitória do X!";
                AumentaVitoriasJogador();
                TelaEmBranco();
            }
            // Verifico se a coluna direita houve vencedor O
            else if (imgO1x3.Visibility == Visibility.Visible && imgO2x3.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }

            //----------------------------------------------------------------------------------------------------
            // Verifico se a linha superior houve vencedor X
            else if (img1x1XBranco.Visibility == Visibility.Visible && img1x2XBranco.Visibility == Visibility.Visible && img1x3XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                AumentaVitoriasJogador();
                txtJogadorVencedor.Text = "Vitória do X!";
                TelaEmBranco();
            }
            // Verifico se a linha superior houve vencedor O
            else if (imgO1x1.Visibility == Visibility.Visible && imgO1x2.Visibility == Visibility.Visible && imgO1x3.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }

//----------------------------------------------------------------------------------------------------
            // Verifico se a linha do meio houve vencedor X
            else if (img2x1XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img2x3XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                AumentaVitoriasJogador();
                txtJogadorVencedor.Text = "Vitória do X!";
                TelaEmBranco();
            }
            // Verifico se a linha do meio houve vencedor O
            else if (imgO2x1.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO2x3.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }

//----------------------------------------------------------------------------------------------------
            // Verifico se a linha inferior houve vencedor X
            else if (img3x1XBranco.Visibility == Visibility.Visible && img3x2XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                AumentaVitoriasJogador();
                txtJogadorVencedor.Text = "Vitória do X!";
                TelaEmBranco();
            }

            // Verifico se a linha inferior houve vencedor O
            else if (imgO3x1.Visibility == Visibility.Visible && imgO3x2.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }
            //----------------------------------------------------------------------------------------------------
            // Verifico se a diagonal esquerda houve vencedor X
            else if (img1x1XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                AumentaVitoriasJogador();
                txtJogadorVencedor.Text = "Vitória do X!";
                TelaEmBranco();
            }

            // Verifico se a diagonal esquerda houve vencedor O
            else if (imgO1x1.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }
            //----------------------------------------------------------------------------------------------------
            // Verifico se a diagonal direita houve vencedor X
            else if (img1x3XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x1XBranco.Visibility == Visibility.Visible)
            {
                VitoriasJogador++;
                AumentaVitoriasJogador();
                txtJogadorVencedor.Text = "Vitória do X!";
                TelaEmBranco();
            }
            // Verifico se a diagonal direita houve vencedor O
            else if (imgO1x3.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x1.Visibility == Visibility.Visible)
            {
                VitoriasComputador++;
                AumentaVitoriasComputador();
                txtJogadorVencedor.Text = "Vitória do O!";
                TelaEmBranco();
            }

            //----------------------------------------------------------------------------------------------------
            // Se não houver vencedor, será velha.
            else
            {
                //Informo que deu velha o jogo.
                InformaVelha();
                TelaEmBranco();
            }

            //Informo se houve vencedor
        }

        public void TelaEmBranco()
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

        public void AumentaVitoriasJogador()
        {
            txtJogadorNum.Text = $"{(VitoriasJogador)}";
        }

        public void AumentaVitoriasComputador()
        {
            txtJogadorNum.Text = $"{(VitoriasComputador)}";
        }

        public void InformaVelha()
        {
            // Verifico se todos os botões foram jogados
            if (numerodeJogadas == 9)
            {
                // Informo no campo que houve velha
                txtJogadorVencedor.Text = "Deu velha!";
            }
        }
    }
}