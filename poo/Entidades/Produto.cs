namespace PooPedidos.Entidades;

public class Produto
{
   
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    private decimal _preco;
    public string Descricao { get; set; } = string.Empty;
    private int _quantidade;

    public Produto(int id, string nome, decimal preco, string descricao, int quantidade)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException(Mensagens.ProdutoNomeVazio, nameof(nome));
        if (preco < 0)
            throw new ArgumentException(Mensagens.PrecoNegativo, nameof(preco));
        if (quantidade < 0)
            throw new ArgumentException(Mensagens.EstoqueNegativo, nameof(quantidade));

        Id = id;
        Nome = nome;
        _preco = preco;
        Descricao = descricao ?? string.Empty;
        _quantidade = quantidade;
    }
    public override string ToString() =>
        $"Produto #{Id}: {Nome}\n" +
        $"  Preço: R$ {_preco:F2}\n" +
        $"  Quantidade: {_quantidade}\n" +
        $"  Descrição: {Descricao}";


    public decimal ObterPreco()
    {
        return _preco;
    }

    public void AlterarPreco(decimal preco)
    {
        if (preco < 0) throw new ArgumentException(Mensagens.PrecoNaoPodeSerNegativo, nameof(preco));
        _preco = preco;
    }

    public int ObterEstoque()
    {
        return _quantidade;
    }
    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0) throw new ArgumentException(Mensagens.QuantidadeAdicionarPositiva, nameof(quantidade));
        _quantidade += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0) throw new ArgumentException(Mensagens.QuantidadeRemoverPositiva, nameof(quantidade));
        if (quantidade > _quantidade) throw new ArgumentException(Mensagens.RemoverMaisQueEstoque, nameof(quantidade));
        _quantidade -= quantidade;
    }
}