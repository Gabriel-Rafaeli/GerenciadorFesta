using GerenciadorDeFestas.Dominio.Compartilhado;

namespace GerenciadorDeFestas.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool ClienteAntigo { get; set; }

        public bool ClienteNovo { get; set; }

        public Cliente(string nome, string telefone, bool clienteAntigo, bool clienteNovo)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.ClienteAntigo = clienteAntigo;
            this.ClienteNovo = clienteNovo;
        }

        public Cliente()
        {
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.Telefone = registroAtualizado.Telefone;
            this.ClienteAntigo = registroAtualizado.ClienteAntigo;
            this.ClienteNovo = registroAtualizado.ClienteNovo;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(Telefone))
                erros.Add("O campo 'telefone' é obrigatório");

            if (ClienteAntigo == false && ClienteNovo == false)
                erros.Add("O campo cliente é obrigatório");

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
