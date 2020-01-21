using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Carro
    {
        private String marca { get; set; }
        private String modelo { get; set; }
        private String placa { get; set; }
        private String cor { get; set; }
        private float km { get; set; }
        private Boolean isLigado { get; set; }
        private int litrosCombustivel { get; set; }
        private int velocidade { get; set; }
        private double preco { get; set; }

        public Carro(String marca, String modelo, String placa, String cor, float km, Boolean isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.km = km;
            this.isLigado = false;
            this.litrosCombustivel = 50;
            this.velocidade = 0;
            this.preco = preco;
        }
        public Carro()
        {
        }
        public void acelerar()
        {
            if (this.isLigado == true)
            {
                this.velocidade = this.velocidade + 20;
                this.litrosCombustivel -= 1;
            }
            else
            {
                Console.WriteLine("Não é possivel acelerar, pois, o carro está desligado.");
            }
        }
        int dif;
        public void abastecer(int li)
        { if (this.litrosCombustivel < 100)
            { if (this.litrosCombustivel + li > 100)
                {
                    this.litrosCombustivel = 100;
                    dif = li - 50;
                    Console.WriteLine("Não pode passar do limite do combustivel");
                    Console.WriteLine("Passou em " + dif + " litros de gasolina do limite");
                }
                else
                {
                    this.litrosCombustivel += li;
                    Console.WriteLine("Abastecimento " + li + " litros de combustivel, a quantidade de gasolina é " + this.litrosCombustivel + " litros");
                }
            }
            else
            {
                Console.WriteLine("Não é possivel abastecer o tanque cheio");
            }
        }

        public void frear()
        {
            if (this.isLigado == true)
            {
                if (this.velocidade < 0)
                {
                    Console.WriteLine(" O carro esta parado");
                }
                else
                {
                    this.velocidade -= 10;
                }
            }
            else
            {
                Console.WriteLine("Não é possivel freiar com o carro desligado");
            }
        }

        public void pintar( String cor)
        {
            this.cor = cor;
        }

        public void ligar()
        {
            if (isLigado == false)
            {
                this.isLigado = true;
                Console.WriteLine("O carro ligou.");
            }
            else
            {
                Console.WriteLine("O carro esta desligaDO.");
            }
        }

        public void desligar()
        {
            if (isLigado == true)
            {
                this.isLigado = false;
                Console.WriteLine("O carro desligou");
            }
            else
            {
                Console.WriteLine("O carro esta ligado");
            }
        }

        public void status()
        {
            Console.WriteLine("A marca do carro é: " + this.marca);
            Console.WriteLine("O modelo do carro é: " + this.modelo);
            Console.WriteLine("A placa do carro é: " + this.placa);
            Console.WriteLine("A cor do carro é: " + this.cor);
            Console.WriteLine("O km do carro é: " + this.km);
            Console.WriteLine("Ligado: " + this.isLigado);
            Console.WriteLine("o carro tem: " + this.litrosCombustivel + " Litros de gasolina");
            Console.WriteLine("A velocidade do carro é: " + this.velocidade);
            Console.WriteLine("O preço do carro é: " + this.preco);
        }
    }
} 

