class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024];


        while (numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var bytes in buffer)
            {
                Console.Write(bytes);
                Console.Write(" ");
            }
        }
    }
}