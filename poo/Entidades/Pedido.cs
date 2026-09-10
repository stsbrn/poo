namespace PooPedidos.Entidades;
using PooPedidos;

public class Pedido
{
    private readonly List<ItemPedido> _itens = new List<ItemPedido>();

    public Pedido(int id, DateTime data, Cliente cliente)
    {
        if (cliente is null) throw new ArgumentNullException(nameof(cliente));

        Id = id;
        Data = data;
        Cliente = cliente;
        Observacao = string.Empty;
    }

    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public IReadOnlyList<ItemPedido> Itens => _itens.AsReadOnly();
    public decimal ValorTotal => _itens.Sum(item => item.ValorTotal);
    public string Observacao { get; set; } = string.Empty;

    public override string ToString() =>
        $"{Id} - {Data:dd/MM/yyyy} - {Cliente.Nome} - {ValorTotal:C} - {Observacao}";

    public void AdicionarItem(Produto produto, int quantidade)
    {
        if (produto is null) throw new ArgumentNullException(nameof(produto));
        if (quantidade <= 0) throw new ArgumentException(Mensagens.QuantidadeMaiorQueZero, nameof(quantidade));

        var existente = _itens.FirstOrDefault(i => i.Produto.Id == produto.Id);
        if (existente is not null)
        {
            existente.Qtd += quantidade;
        }
        else
        {
            _itens.Add(new ItemPedido(produto, quantidade, produto.ObterPreco()));
        }
    }

    public void AlterarQuantidade(int produtoId, int quantidade)
    {
        if (quantidade <= 0) throw new ArgumentException(Mensagens.QuantidadeMaiorQueZero, nameof(quantidade));
        var item = _itens.FirstOrDefault(i => i.Produto.Id == produtoId);
        if (item is null) throw new ArgumentException(Mensagens.ItemInvalido, nameof(produtoId));
        item.Qtd = quantidade;
    }

    public void RemoverItem(int produtoId)
    {
        var item = _itens.FirstOrDefault(i => i.Produto.Id == produtoId);
        if (item is null) throw new ArgumentException(Mensagens.ItemInvalido, nameof(produtoId));
        _itens.Remove(item);
    }
}
