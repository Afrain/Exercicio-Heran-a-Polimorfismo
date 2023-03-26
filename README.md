# Exercicio-Heranca-e-Polimorfismo

## Exercicio proposto

![ExercicioProposto](https://user-images.githubusercontent.com/9250787/227785374-5ecc3f2b-bc9a-4f27-83d9-fb1a5d316431.jpeg)

## Saída

![Saida](https://user-images.githubusercontent.com/9250787/227785431-435b090a-85ac-47ec-a619-a2511832b8bb.jpeg)

## Classe Produto.cs

![image](https://user-images.githubusercontent.com/9250787/227786619-01143378-fda5-4f21-9666-f9c00bb877fe.png)

## Classe ProdutoUsado.cs : Produto.cs

![image](https://user-images.githubusercontent.com/9250787/227786692-f716e2f8-2623-4db7-b225-0ca525d84e0a.png)

## Classe ProdutoImportato.cs : Produto.cs

![image](https://user-images.githubusercontent.com/9250787/227786730-b9b49865-00d7-48aa-9342-9553d1396408.png)

## Classe Program.cs

```using ExercicioHerancaPolimorfismo.Models;
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
```
