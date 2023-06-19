using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace GerenciadorDeFestas.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public List<Aluguel> listaAlugueisDoCliente;
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.listaAlugueisDoCliente = new List<Aluguel>();
        }

        public Cliente()
        {
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.Telefone = registroAtualizado.Telefone;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'nome' é obrigatório");

            string digitos = Regex.Replace(Telefone, "[^0-9]", "");

            if (string.IsNullOrEmpty(digitos))
                erros.Add("O campo 'telefone' é obrigatório");

            if (Telefone.Length <= 14)
                erros.Add("O campo 'telefone' é obrigatório");

            if (Nome.Length < 5)
                erros.Add("O campo 'nome' deve ter no mínimo 5 caracteres");

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   id == cliente.id &&
                   Nome == cliente.Nome &&
                   Telefone == cliente.Telefone;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
