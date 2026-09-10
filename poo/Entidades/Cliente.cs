namespace PooPedidos.Entidades;
using PooPedidos;

public class Cliente
{
  
    public int Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Telefone { get; private set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;

    public Cliente(int id, string nome, string email, string telefone, string endereco)
    {
        Id = id;
        // use the domain methods to validate
        AlterarNome(nome);
        AlterarEmail(email ?? string.Empty);
        AlterarTelefone(telefone);
        Endereco = endereco ?? string.Empty;
    }

    public void AlterarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || nome.Trim().Length < 3)
            throw new ArgumentException(Mensagens.NomeMuitoCurto, nameof(nome));
        Nome = nome;
    }

    public void AlterarEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            throw new ArgumentException(Mensagens.EmailInvalido, nameof(email));
        Email = email;
    }

    public void AlterarTelefone(string telefone)
    {
        if (string.IsNullOrWhiteSpace(telefone))
            throw new ArgumentException(Mensagens.TelefoneVazio, nameof(telefone));
        var digitos = telefone.Count(char.IsDigit);
        if (digitos < 8) throw new ArgumentException(Mensagens.TelefonePoucosDigitos, nameof(telefone));
        Telefone = telefone;
    }
    public override string ToString() => 
        $"Cliente #{Id}: {Nome}\n" +
        $"  Email: {Email}\n" +
        $"  Telefone: {Telefone}\n" +
        $"  Endereço: {Endereco}";
}
