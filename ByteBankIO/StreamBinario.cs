using System.Text;

internal partial class Program
{
    private static void EscritaBinaria()
    {
        
        using (var fs = new FileStream("contaCorrenteBINARIO.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);
            escritor.Write(54564);
            escritor.Write(4000.50);
            escritor.Write("Gustavo Lima");

            Console.WriteLine("Arquivo criado com sucesso!");
        }
    }

    private static void LeituraBinaria()
    {

        using (var fs = new FileStream("contaCorrenteBINARIO.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var numeroConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia} {numeroConta} {saldo} {titular}") ;
        }
    }


}