using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Carro
    {
        #region Atributos

        
        private string modelo;
        private int ano;
        private bool ligado;

        #endregion

        #region Constantes

        private const float CONSUMO = 2;
        private const float MAXCOMBUSTIVEL = 50;

        #endregion

        #region Propriedades

        public string Modelo { get; set; }
        public float QuantidadeAtualCombustivel { get; private set; }
        //public float QuantidadeAtualCombustivel { get; }


        #endregion

        #region Construtores

        public Carro(string modelo, int ano, int quantidadeAtualCombustivel)
        {
            this.modelo = modelo;
            this.ano = ano;
            QuantidadeAtualCombustivel = quantidadeAtualCombustivel;
        }

        #endregion

        #region Metodos privados

        private float porcentagemCombustivel()
        {
            return (QuantidadeAtualCombustivel / MAXCOMBUSTIVEL) * 100;
        }
        private void InformacoesCombustivel()
        {
            Console.WriteLine($"Litros de combustível: {QuantidadeAtualCombustivel}");
            Console.WriteLine($"Porcentagem de combustível: {this.porcentagemCombustivel()}%");
        }

        #endregion

        #region Metodos publicos

        public void Status()
        {
            if (this.ligado)
            {
                Console.WriteLine($"O carro está ligado");
            }
            else
            {
                Console.WriteLine($"O carro está desligado");
            }

            this.InformacoesCombustivel();
        }
      

        public void Ligar()
        {
            this.ligado = true;
        }

        public void Desligar()
        {
            this.ligado = false;
        }

        public void Abastecer(float quantidadeCombustivel)
        {
            if(QuantidadeAtualCombustivel.Equals(MAXCOMBUSTIVEL))
            {
                Console.WriteLine("Tanque cheio!");
            }
            else if((quantidadeCombustivel + QuantidadeAtualCombustivel) > MAXCOMBUSTIVEL)
            {
                Console.WriteLine("Quantidade de combustivel maior que o suportado pelo tanque!");
                Console.WriteLine($"Quantidade disponivel eh de: {MAXCOMBUSTIVEL - QuantidadeAtualCombustivel} litros");
            }
            else
            {
                QuantidadeAtualCombustivel = QuantidadeAtualCombustivel + quantidadeCombustivel;
                Console.WriteLine("Abastecimento concluido!");
                this.InformacoesCombustivel();
            }
        }

        public void Acelerar()
        {
            if(!this.ligado)
            {
                Console.WriteLine("O carro precisa estar ligado para acelerar!");
                return;
            }

            if(QuantidadeAtualCombustivel <0 )
            {
                Console.WriteLine("Acabou o combustivel! Abasteca antes de acelerar!");
            }

            this.QuantidadeAtualCombustivel = this.QuantidadeAtualCombustivel - CONSUMO;
            Console.WriteLine("Vruumm!");
        }

        #endregion
    }
}