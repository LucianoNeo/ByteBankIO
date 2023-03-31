internal partial class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Digite seu nome:");
        //var nome = Console.ReadLine();

        var linhas = File.ReadAllLines("contas.csv");
        Console.WriteLine(linhas.Length);

        /*
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }
        */

        var bytesArquivo = File.ReadAllBytes("contas.csv");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
    }
}