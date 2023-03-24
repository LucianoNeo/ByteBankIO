partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine(); // traz a primeira linha

            var texto = leitor.ReadToEnd(); // traz o conteudo todo do arquivo

            var numero = leitor.Read(); // traz o primeiro byte do arquivo

            while (!leitor.EndOfStream) // le o arquivo parcialmente até o fim
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

        }
    }
}