using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using GeradorChavePix;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;
using System.Windows.Markup;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChaves = GeradorPix.GetChavesPix(10);

foreach (var chave in listaDeChaves)
{
    Console.WriteLine(chave);
}