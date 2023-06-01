using FactoryMethodTest.ConcreteProduct;
using FactoryMethodTest.Creator;
using FactoryMethodTest.Product;


namespace FactoryMethodTest.ConcreteCreator
{
    public class LataFactory : RefriFactory
    {
        private string _tamanhoRecipiente;
        private string _saborRefrigerante;
        private int _quantidadeRefrigerante;
        private int _valorRefrigerante;

        public LataFactory(string tamanhoRecipiente, string saborRefrigerante, int quantidadeRefrigerante ,int valorRefrigerante) //construtor
        {
            this._tamanhoRecipiente = tamanhoRecipiente;
            this._saborRefrigerante = saborRefrigerante;
            this._quantidadeRefrigerante = quantidadeRefrigerante;
            this._valorRefrigerante = valorRefrigerante;
        }

        public override Refrigerante SolicitarRefrigerante()
        {
            return new Lata(_tamanhoRecipiente, _saborRefrigerante, _quantidadeRefrigerante, _valorRefrigerante);
        }
    }
}
