using ExercicioHerancaPolimorfismo.Models;
using System.Globalization;
using System.Collections.Generic;
using System;

List<Produto> listaProdutos = new List<Produto>();

System.Console.Write("Informe a quantidade de produtos: ");
int quantidadeProduto = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidadeProduto; i++)
{
    System.Console.WriteLine($"Informe o {i}° produto:");
    System.Console.Write("Comum, usado ou importado (c/u/i)? ");
    char tipoProduto = char.Parse(Console.ReadLine());

    System.Console.Write("Nome: ");
    string nome = Console.ReadLine();

    System.Console.Write("Preco: ");
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (tipoProduto == 'u')
    {
        System.Console.Write("Data Fabricação (DD/MM/AAAA): ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
        Produto produtoUsado = new ProdutoUsado(nome, preco, dataFabricacao);
        listaProdutos.Add(produtoUsado);
    }
    else if (tipoProduto == 'i')
    {
        System.Console.Write("Custo importação: ");
        double custoAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Produto produtoImportado = new ProdutoImportado(nome, preco, custoAdicional);
        listaProdutos.Add(produtoImportado);
    }
    else
    {
        Produto produtoComum = new Produto(nome, preco);
        listaProdutos.Add(produtoComum);
    }

}

System.Console.WriteLine("Produtos");
foreach(var produto in listaProdutos)
{
    System.Console.WriteLine(produto.Etiqueta());
}
