using System.Text;

internal partial class Program
{
    private static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 5578.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            Console.WriteLine("Arquivo criado com sucesso!");
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("455, 654, 10578.40, Luciano Santos");
            Console.WriteLine("Arquivo criado com sucesso!");
        }
    }
}