using FactoryMethodTest.ConcreteProduct;
using FactoryMethodTest.Creator;
using FactoryMethodTest.Product;

namespace FactoryMethodTest.ConcreteCreator
{
    //classe concreta então vai ser pública
    //
    public class GarrafaFactory : RefriFactory //vai herdar de refrifactory
    {
        private string _tamanhoRecipiente;
        private string _saborRefrigerante;
        private int _quantidadeRefrigerante;
        private int _valorRefrigerante;

        public GarrafaFactory(string tamanhoRecipiente, string saborRefrigerante, int quantidadeRefrigerante, int valorRefrigerante) //construtor
        {
            this._tamanhoRecipiente = tamanhoRecipiente;
            this._saborRefrigerante = saborRefrigerante;
            this._quantidadeRefrigerante = quantidadeRefrigerante;
            this._valorRefrigerante = valorRefrigerante;

        }
        public override Refrigerante SolicitarRefrigerante()
        {
            return new Garrafa(_tamanhoRecipiente, _saborRefrigerante, _quantidadeRefrigerante, _valorRefrigerante);
        }
    }
}
