namespace PooPedidos.Entidades;

public class ItemPedido
{
    
    public Produto Produto { get; set; } = null!;
    public int Qtd { get; set; }
    public decimal Valor { get; set; }

    public ItemPedido(Produto produto, int qtd, decimal valor) {
        if (produto is null) throw new ArgumentNullException(nameof(produto));
        if (qtd <= 0) throw new ArgumentException(PooPedidos.Mensagens.QuantidadeMaiorQueZero, nameof(qtd));
        if (valor < 0) throw new ArgumentException(PooPedidos.Mensagens.ValorNaoPodeSerNegativo, nameof(valor));

        Produto = produto;
        Qtd = qtd;
        Valor = valor;
    }
    public decimal ValorTotal => Qtd * Valor;

    public override string ToString() =>
        $"{Produto.Nome} | Qtd: {Qtd} | Unitário: {Valor:C} | Total: {ValorTotal:C}";
}
