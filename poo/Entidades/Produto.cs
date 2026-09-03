namespace PooPedidos.Entidades;

public class Produto
{
    public Produto(int id, string nome, decimal preco, string descricao, int quantidade)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Quantidade = quantidade;
    }
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    private decimal Preco { get; set; }
    public string Descricao { get; set; } = string.Empty;
    private int Quantidade { get; set; }
    public override string ToString() =>
        $"Produto #{Id}: {Nome}\n" +
        $"  Preço: R$ {Preco:F2}\n" +
        $"  Quantidade: {Quantidade}\n" +
        $"  Descrição: {Descricao}";


    public decimal ObterPreco()
    {
        return Preco;
    }

    public void AlterarPreco(decimal preco)
    {
        Preco = preco;
    }

    public int ObterEstoque()
    {
        return Quantidade;
    }
    public void AdicionarEstoque(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        Quantidade -= quantidade;
    }
}