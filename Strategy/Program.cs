using Strategy;

Imposto iss = new ISS();
Imposto icms = new ICMS();
Console.WriteLine("Digite o valor do orçamento para calcular os impostos:");
var input = Console.ReadLine();
double valor = double.Parse(input);
var orcamento = new Orcamento(valor);
CalculadorDeImposto calculador = new CalculadorDeImposto();

// Calculando o ISS
Console.WriteLine($"O valor calculado do ISS para o valor R${orcamento.Valor} é de: R$");
calculador.RealizaCalculo(orcamento, iss);


// Calculando o ICMS        
Console.WriteLine($"O valor calculado do ICMS para o valor R${orcamento.Valor} é de: R$");
calculador.RealizaCalculo(orcamento, icms);
Console.ReadKey();
