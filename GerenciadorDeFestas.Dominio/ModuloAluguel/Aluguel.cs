using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {

        public  Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public DateTime DataFechamento { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public PorcentagemPagaEnum PorcentagemPaga { get; set; }
        public decimal ValorPagar { get; set; }
        public decimal ValorTotal { get; set; }

        public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, string cep, string numero, string rua)
        {
            Cliente = cliente;
            Tema = tema;
            Data = data;
            HoraInicio = horaInicio;
            HoraFinal = horaFinal;
            Cep = cep;
            Numero = numero;
            Rua = rua;            
        }

        public Aluguel()
        {
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            this.Cliente = registroAtualizado.Cliente;
            this.Tema = registroAtualizado.Tema;
            this.Data = registroAtualizado.Data;
            this.HoraInicio = registroAtualizado.HoraInicio;
            this.HoraFinal = registroAtualizado.HoraFinal;
            this.DataFechamento = registroAtualizado.DataFechamento;
            this.Cep = registroAtualizado.Cep;
            this.Numero = registroAtualizado.Numero;
            this.Rua = registroAtualizado.Rua;
            this.PorcentagemPaga = registroAtualizado.PorcentagemPaga;
            this.ValorPagar = registroAtualizado.ValorPagar;            
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (Cliente == null)
                erros.Add("O campo 'Cliente' é obrigatório");

            if (Tema == null)
                erros.Add("O campo 'Tema' é obrigatório");

            string apenasDigitos = Regex.Replace(Cep, "[^0-9]", "");

            if (string.IsNullOrEmpty(apenasDigitos))
                erros.Add("O campo 'Cep' é obrigatório");

            if (apenasDigitos.Length < 8)
                erros.Add("'Cep' incompleto.");

            if (string.IsNullOrEmpty(Rua))
                erros.Add("O campo 'Rua' é obrigatório");

            if (string.IsNullOrEmpty(Numero))
                erros.Add("O campo 'Número' é obrigatório");

            return erros.ToArray();
        }

        public decimal CalcularDesconto()
        {
            int quantidadePedidos = Cliente.listaAlugueisDoCliente.Count();

            switch (quantidadePedidos)
            {
                case 1: return ValorTotal * (decimal)0.975; break;
                case 2: return ValorTotal * (decimal)0.96; break;
                case 3: return ValorTotal * (decimal)0.945; break;
                case 4: return ValorTotal * (decimal)0.93; break;
                case 5: return ValorTotal * (decimal)0.915; break;
                case 6: return ValorTotal * (decimal)0.90; break;
                case 7: return ValorTotal * (decimal)0.885; break;
                case 8: return ValorTotal * (decimal)0.87; break;
            }

            if (quantidadePedidos >= 9)
            {
                return ValorTotal * (decimal)0.855;
            }

            return ValorTotal * (decimal)0.99;
        }

        public decimal CalcularValorPagar()
        {
            decimal valorRestante = CalcularDesconto();
            valorRestante = valorRestante - (valorRestante * (decimal)PorcentagemPaga / 100);

            return valorRestante;
        }

        public void AtualizarPagamento(Aluguel aluguelAtualizado)
        {
            this.PorcentagemPaga = aluguelAtualizado.PorcentagemPaga;
        }

        public void FinalizarPagamento()
        {
            if (PorcentagemPaga == PorcentagemPagaEnum.Cem)
            {
                DataFechamento = DateTime.Now.Date;
            }
        }
    }
}
