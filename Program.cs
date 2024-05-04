decimal gasolina, etanol;
const decimal percentualRecomendado = (73);
decimal percentualConta;

Console.Clear();

Console.WriteLine("--- Etanol ou Gasolina? ---\n");

Console.Write("Digite o preço do etanol (R$): ");
etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$): ");
gasolina = Convert.ToDecimal(Console.ReadLine());

percentualConta = ((etanol / gasolina) * 100);

Console.WriteLine($"O preço do etanol corresponde a {percentualConta:N1} do preço da gasolina");

if(percentualConta <= percentualRecomendado)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Recomendação: Abasteça com ETANOL.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Recomendação: Abasteça com GASOLINA.");
    Console.ResetColor();
}
