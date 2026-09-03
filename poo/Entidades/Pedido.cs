namespace PooPedidos.Entidades;

public class Pedido
{
    public Pedido(int id, DateTime data, Cliente cliente)
    {
        Id = id;
        Data = data;
        Cliente = cliente;
    }
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public List<ItemPedido> Itens { get; set; } = [];
    public decimal ValorTotal => Itens.Sum(item => item.ValorTotal);
    public string Observacao { get; set; } = string.Empty;
    public override string ToString() =>
        $"{Id} - {Data:dd/MM/yyyy} - {Cliente.Nome} - {ValorTotal:C} - {Observacao}";
}
