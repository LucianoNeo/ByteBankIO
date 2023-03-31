using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.csv";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"Conta número:{contaCorrente.Numero} Ag:{contaCorrente.Agencia} Saldo:R${contaCorrente.Saldo} Titular: {contaCorrente.Titular.Nome}";

                Console.WriteLine(msg);

            }
        }
        Console.ReadLine();
    }


    static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');
            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.',','));
            var titular = new Cliente();
            titular.Nome = campos[3];

            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = titular;

            return resultado;

        }
    
}