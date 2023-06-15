using GerenciadorDeFestas.Dominio.Compartilhado;

namespace GerenciadorDeFestas.Dominio.ModuloItem
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Item(string nome, decimal valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
        public Item()
        {
        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.Valor = registroAtualizado.Valor;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("É necessário incluir o nome do Item.");

            else if (Valor <= 0)
                erros.Add("O valor precisa ser número positivo.");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
