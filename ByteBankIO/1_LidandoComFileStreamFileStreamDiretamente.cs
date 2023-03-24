using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024];


            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();

            static void EscreverBuffer(byte[] buffer, int byteslidos)
            {

                var utf8 = new UTF8Encoding();

                var texto = utf8.GetString(buffer, 0, byteslidos);
                Console.Write(texto);
                /*
                foreach (var bytes in buffer)
                {
                    Console.Write(bytes);
                    Console.Write(" ");
                }*/


            }
        }

    }
}