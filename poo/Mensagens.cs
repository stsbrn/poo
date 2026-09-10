namespace PooPedidos;

public static class Mensagens
{
    public const string OpcaoInvalida = "Opção inválida.";

    public const string ClienteCadastrado = "Cliente cadastrado.";
    public const string ClienteNaoEncontrado = "Cliente não encontrado.";
    public const string ClientePossuiPedidos = "O cliente possui pedidos e não pode ser excluído.";
    public const string ClienteAlterado = "Cliente alterado.";
    public const string ClienteExcluido = "Cliente excluído.";

    public const string ProdutoCadastrado = "Produto cadastrado.";
    public const string ProdutoNaoEncontrado = "Produto não encontrado.";
    public const string ProdutoAlterado = "Produto alterado.";
    public const string ProdutoPertencePedido = "O produto pertence a um pedido e não pode ser excluído.";
    public const string ProdutoExcluido = "Produto excluído.";

    public const string CadastreClienteProduto = "Cadastre pelo menos um cliente e um produto primeiro.";

    public const string PedidoCanceladoSemItens = "O pedido foi cancelado porque não possui itens.";
    public const string PedidoNaoEncontrado = "Pedido não encontrado.";
    public const string PedidoAlterado = "Pedido alterado.";
    public const string PedidoExcluido = "Pedido excluído.";

    public const string EstoqueIndisponivel = "Estoque indisponível";
    public const string PedidoSemItens = "O pedido não possui itens.";
    public const string ItemInvalido = "Item inválido.";

    // Domain validation messages
    public const string NomeVazio = "Nome não pode ficar vazio.";
    public const string NomeMuitoCurto = "O nome deve possuir ao menos 3 caracteres.";
    public const string EmailInvalido = "E-mail inválido. Deve conter '@'.";
    public const string TelefoneVazio = "Telefone não pode ficar vazio.";
    public const string TelefonePoucosDigitos = "O telefone deve possuir ao menos 8 dígitos.";

    public const string QuantidadeMaiorQueZero = "Quantidade deve ser maior que zero.";
    public const string ValorNaoPodeSerNegativo = "Valor não pode ser negativo.";

    public const string ProdutoNomeVazio = "Nome não pode ficar vazio.";
    public const string PrecoNegativo = "Preço não pode ser negativo.";
    public const string EstoqueNegativo = "Estoque (quantidade) não pode ser negativo.";
    public const string PrecoNaoPodeSerNegativo = "O preço não pode ser negativo.";
    public const string QuantidadeAdicionarPositiva = "A quantidade a adicionar deve ser positiva.";
    public const string QuantidadeRemoverPositiva = "A quantidade a remover deve ser positiva.";
    public const string RemoverMaisQueEstoque = "Não é possível remover mais unidades do que existem no estoque.";
}
