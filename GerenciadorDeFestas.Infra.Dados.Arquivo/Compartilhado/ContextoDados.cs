using System.Text.Json.Serialization;
using System.Text.Json;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "Compartilhado\\GerenciadorFesta.json";

        public List<Item> listaItens;
        public List<Cliente> listaClientes;
        public List<Aluguel> listaAlugueis;
        public List<Tema> listaTemas;
        public ContextoDados()
        {
            listaItens = new List<Item>();
            listaClientes = new List<Cliente>();
            listaTemas = new List<Tema>();
            listaAlugueis = new List<Aluguel>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                   this.listaItens = ctx.listaItens;
                   this.listaClientes = ctx.listaClientes;
                   this.listaTemas = ctx.listaTemas;
                   this.listaAlugueis = ctx.listaAlugueis;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
