
namespace ExercicioHerancaPolimorfismo.Models
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }
        
        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Etiqueta() 
            => $"{Nome} (usado) {Preco:c} (Data de fabricação: {DataFabricacao.ToString("dd/MM/yyyy")})";
    }
}