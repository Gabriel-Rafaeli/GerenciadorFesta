using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

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

        public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, DateTime dataFechamento, string cep, string numero, string rua)
        {
            Cliente = cliente;
            Tema = tema;
            Data = data;
            HoraInicio = horaInicio;
            HoraFinal = horaFinal;
            DataFechamento = dataFechamento;
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

            if (string.IsNullOrEmpty(Cep))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(Numero))
                erros.Add("O campo 'telefone' é obrigatório");

            return erros.ToArray();
        }

        public decimal CalcularDesconto()
        {
            if (Cliente.ClienteAntigo)
            {
                return Tema.ValorTotal * (decimal) 0.9;  
            }

            return Tema.ValorTotal;
        }

        public decimal CalcularSaldo()
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
