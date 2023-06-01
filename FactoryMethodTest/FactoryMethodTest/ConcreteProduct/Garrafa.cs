using FactoryMethodTest.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTest.ConcreteProduct
{
    public class Garrafa : Refrigerante
    {
        private readonly string _tipoRecipiente;
        private string _tamanhoRecipiente;
        private string _saborRefrigerante;
        private int _quantidadeRefrigerante;
        private int _valorRefrigerante;
        private int _valorTotal;

        //construtor
        //como o tipo de recipiente não será 'setado', ele não é passado no parâmetro
        public Garrafa(string tamanhoRecipiente, string saborRefrigerante, int quantidadeRefrigerante, int _valorRefrigerante)
        {
            this._tipoRecipiente = "Garrafa"; // tamanho e sabor receberão os valores do construtor
            this._tamanhoRecipiente = tamanhoRecipiente;
            this._saborRefrigerante = saborRefrigerante;
            this._quantidadeRefrigerante = quantidadeRefrigerante;
            this._valorRefrigerante = 10;
            this._valorTotal = _valorRefrigerante * quantidadeRefrigerante;
           
        }

        //polimorfismo
        //declarando os overrides
        public override string TipoRecipiente
        {
            get { return _tipoRecipiente; }
        }
        public override string TamanhoRecipiente
        {
            get { return this._tamanhoRecipiente; }
            set { _tamanhoRecipiente = value; }
        }
        public override string SaborRefrigerante
        {
            get { return this._saborRefrigerante; }
            set { _saborRefrigerante = value; }
        }
        public override int QuantidadeRefrigerante
        {
            get { return this._quantidadeRefrigerante; }
            set { _quantidadeRefrigerante = value; }
        }
        public override int ValorRefrigerante
        {
            get { return this._valorRefrigerante; }
        }
        public override int ValorTotal
        {
            get { return this._valorTotal; }
            set { _valorTotal = value; }
        }
    }
}

