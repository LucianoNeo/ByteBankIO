using ByteBankIO;

internal partial class Program
{
    private static void UsandoStreamDaConsole()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024];
            var numeroLinha = 1;
            Console.WriteLine("############################################################");
            Console.WriteLine("## SEJA BEM VINDO AO EDITOR DE TEXTO PRÉ HISTÓRICO DO NEO!##");
            Console.WriteLine("############################################################");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine($"Digite o conteudo da {numeroLinha}ª linha e pressione ENTER para confirmar");
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, byteslidos);
                fs.Flush();
                numeroLinha++;

            }

            
        }
        Console.ReadLine();
    }

  
}