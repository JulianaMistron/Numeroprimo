int numero;
int divisor = 0;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (numero % i == 0)
        divisor++;
}

if (divisor == 2)
    Console.WriteLine("É um número primo.");

else
    Console.WriteLine("Não é um número primo.");


Console.ReadKey();