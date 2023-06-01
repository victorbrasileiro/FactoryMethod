// criando o produto 
// vai definir a interface dos objetos que o metodo de fabrica cria 


namespace FactoryMethodTest.Product
{
    public abstract class Refrigerante
    {
        public abstract string TipoRecipiente { get; }

        public abstract string TamanhoRecipiente { get; set; }

        public abstract string SaborRefrigerante { get; set; }

        public abstract int QuantidadeRefrigerante { get; set; }

        public abstract int ValorRefrigerante { get; }

        public abstract int ValorTotal { get; set;}

    }
}
