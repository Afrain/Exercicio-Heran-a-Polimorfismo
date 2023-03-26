namespace ExercicioHerancaPolimorfismo.Models
{
    public class ProdutoImportado : Produto
    {
        public double CustoAdicional { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double custoAdicional) : base(nome, preco)
        {
            CustoAdicional = custoAdicional;
        }

        public double PrecoTotal() => Preco + CustoAdicional;

        public override string Etiqueta()
        {
            return $"{Nome} {PrecoTotal()} (Custo de importação: {CustoAdicional})";
        }
    }
}