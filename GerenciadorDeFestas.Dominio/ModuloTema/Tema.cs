using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {

        public string Nome { get; set; }
        public decimal ValorTotal { get; set; }

        public List<Item> listaItens;
        public List<Aluguel> listaAlugueis;

        public Tema(string nome)
        {
            this.Nome = nome;
            this.listaItens = new List<Item>();
            this.listaAlugueis = new List<Aluguel>();
        }

        public Tema()
        {
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.listaItens = registroAtualizado.listaItens;
            this.ValorTotal = registroAtualizado.ValorTotal;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("É necessário incluir o nome do Tema.");

            if (listaItens.Count == 0)
                erros.Add("É necessário incluir um Item.");

            return erros.ToArray();
        }

        public decimal CalcularValor()
        {
            foreach (Item item in listaItens)
            {
                ValorTotal += item.Valor;
            }

            return ValorTotal;
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}

