﻿using System;
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
       
        //Quem venceu.
        string jogadorVencedor = "";

        //criar a crescentes para resultado
        int numerodeJogadas = 0;
       
        int jogadorGanha = 0;
        int computadorGanha = 0;
        bool xGanha = false;
        bool oGanha = false;

        public MainWindow()
        {
            InitializeComponent();
            //Deixa vazio o campo vencedor
            txtJogadorVencedor.Text = "";
        }

        public void SimbolosEscondidos()
        {
            //X escondido
            img1x1XBranco.Visibility = Visibility.Hidden;
            img1x2XBranco.Visibility = Visibility.Hidden;
            img1x3XBranco.Visibility = Visibility.Hidden;
            img2x1XBranco.Visibility = Visibility.Hidden;
            img2x2XBranco.Visibility = Visibility.Hidden;
            img2x3XBranco.Visibility = Visibility.Hidden;
            img3x1XBranco.Visibility = Visibility.Hidden;
            img3x2XBranco.Visibility = Visibility.Hidden;
            img3x3XBranco.Visibility = Visibility.Hidden;
            //O escondido
            imgO1x1.Visibility = Visibility.Hidden;
            imgO1x2.Visibility = Visibility.Hidden;
            imgO1x3.Visibility = Visibility.Hidden;
            imgO2x1.Visibility = Visibility.Hidden;
            imgO2x2.Visibility = Visibility.Hidden;
            imgO2x3.Visibility = Visibility.Hidden;
            imgO3x1.Visibility = Visibility.Hidden;
            imgO3x2.Visibility = Visibility.Hidden;
            imgO3x3.Visibility = Visibility.Hidden;
        }

        public void IniciarNovoJogo(object sender, RoutedEventArgs e)
        {
            //Volta ao início
            TelaEmBranco();
            SimbolosEscondidos();
            //Três segundos devem ser aguardados até começar outro jogo
            txtJogadorVencedor.Text = "";

        }

        //Jogador da vez
       public bool simboloJogadorDaVez()
        {
            if (imgO1x1.Visibility == Visibility.Visible || imgO1x2.Visibility == Visibility.Visible || imgO1x3.Visibility == Visibility.Visible
                || imgO2x1.Visibility == Visibility.Visible || imgO2x2.Visibility == Visibility.Visible || imgO2x3.Visibility == Visibility.Visible 
                || imgO3x1.Visibility == Visibility.Visible || imgO3x2.Visibility == Visibility.Visible || imgO3x3.Visibility == Visibility.Visible)
                return true;
            else
            {
                return false;
            }
        }

        //Jogada aleatória
        public void Aleatorio()
        {
            bool looping = false;

            while (looping != false)
            {
                Random rdn = new Random();
                int randomizar = rdn.Next(1, 9);

                switch (randomizar)
                {
                    case 1:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x1.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            checagemVencedor();
                        }
                        break;
                    case 2:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x2.Visibility = Visibility.Visible;
                            numerodeJogadas++;
  
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 3:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 4:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 5:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 6:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 7:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 8:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 9:
                        if (simboloJogadorDaVez() == true)
                        {
                            imgO1x3.Visibility = Visibility.Visible;
                            numerodeJogadas++;
                            looping = false;
                           checagemVencedor();
                        }
                        break;
                }
            }
        }

 
        //Clicar na imagem 1x1
        public bool Click1x1(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                //branco1x1.Visibility = Visibility.Hidden;
                img1x1XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }

        //Clicar na imagem 1x2
        public bool Click1x2(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco1x2.Visibility = Visibility.Hidden;
                img1x2XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }


        //Clicar na imagem 1x3
        public bool Click1x3(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco1x3.Visibility = Visibility.Hidden;
                img1x3XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }

        //Clicar na imagem 2x1
        public bool Click2x1(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco2x1.Visibility = Visibility.Hidden;
                img2x1XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();               
            }
            return true;
        }

        //Clicar na imagem 2x2
        public bool Click2x2(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco2x2.Visibility = Visibility.Hidden;
                img2x2XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }

        //Clicar na imagem 2x3
        public bool Click2x3(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco2x3.Visibility = Visibility.Hidden;
                img2x3XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
               checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }

        //Clicar na imagem 3x1
        public bool Click3x1(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco3x1.Visibility = Visibility.Hidden;
                img3x1XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }


        //Clicar na imagem 3x2
        public bool Click3x2(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco3x2.Visibility = Visibility.Hidden;
                img3x2XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }
          
        //Clicar na imagem 3x3
            public bool Click3x3(object sender, MouseButtonEventArgs e)
        {
            if (simboloJogadorDaVez() == false)
            {
                branco3x3.Visibility = Visibility.Hidden;
                img3x3XBranco.Visibility = Visibility.Visible;
                numerodeJogadas++;
                checagemVencedor();
            }
            else
            {
                Aleatorio();
            }
            return true;
        }

        public void checagemVencedor()
        {
            // Verifico se a coluna esquerda houve vencedor
            if (img1x1XBranco.Visibility == Visibility.Visible && img2x1XBranco.Visibility == Visibility.Visible && img3x1XBranco.Visibility == Visibility.Visible
                || imgO1x1.Visibility == Visibility.Visible && imgO2x1.Visibility == Visibility.Visible && imgO3x1.Visibility == Visibility.Visible)
            {
                //Chama o método para pintar os botões

                // Atribuo o jogador da vez a variavel que informa o vencedor
                txtJogadorVencedor.Text = "Fim de jogo";
            }

            // Verifico se a coluna do meio houve vencedor
            else if (img1x2XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x2XBranco.Visibility == Visibility.Visible
                || imgO1x2.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x2.Visibility == Visibility.Visible)
            {
                txtJogadorVencedor.Text = "Fim de jogo";
            }
            // Verifico se a coluna direita houve vencedor
            else if (img1x3XBranco.Visibility == Visibility.Visible && img2x3XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible
                || imgO1x3.Visibility == Visibility.Visible && imgO2x3.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {

                txtJogadorVencedor.Text = "Fim de jogo";
            }
            // Verifico se a linha superior houve vencedor
            else if (img1x1XBranco.Visibility == Visibility.Visible && img1x2XBranco.Visibility == Visibility.Visible && img1x3XBranco.Visibility == Visibility.Visible
                || imgO1x1.Visibility == Visibility.Visible && imgO1x2.Visibility == Visibility.Visible && imgO1x3.Visibility == Visibility.Visible)
            {

                txtJogadorVencedor.Text = "Fim de jogo";
            }
            // Verifico se a linha do meio houve vencedor
            else if (img2x1XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img2x3XBranco.Visibility == Visibility.Visible
                || imgO2x1.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO2x3.Visibility == Visibility.Visible)
            {

                txtJogadorVencedor.Text = "Fim de jogo";
            }
            // Verifico se a linha inferior houve vencedor
            else if (img3x1XBranco.Visibility == Visibility.Visible && img3x2XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible
                || imgO3x1.Visibility == Visibility.Visible && imgO3x2.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {

                txtJogadorVencedor.Text = "Fim de jogo";
            }
            // Verifico se a diagonal esquerda houve vencedor
            else if (img1x1XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x3XBranco.Visibility == Visibility.Visible
                || imgO1x1.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x3.Visibility == Visibility.Visible)
            {

                txtJogadorVencedor.Text = "Fim de jogo";
            }
            // Verifico se a diagonal direita houve vencedor
            else if (img1x3XBranco.Visibility == Visibility.Visible && img2x2XBranco.Visibility == Visibility.Visible && img3x1XBranco.Visibility == Visibility.Visible
                || imgO1x3.Visibility == Visibility.Visible && imgO2x2.Visibility == Visibility.Visible && imgO3x1.Visibility == Visibility.Visible)
            {

                txtJogadorVencedor.Text = "Fim de jogo";
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
                // Informo no campo que houve velha
                txtJogadorVencedor.Text = "Deu velha!";
            }
        }
    }
}