Console.Write("Número de horas trabalhadas: ");
int horasTrabalhadas = int.Parse(Console.ReadLine());
Console.Write("Salário mínimo R$ ");
double salarioMinimo = double.Parse(Console.ReadLine());
Console.WriteLine();

double valorHoraTrabalhada = salarioMinimo / 2.0;
double salarioBruto = horasTrabalhadas * valorHoraTrabalhada;
double imposto = salarioBruto * 0.03;
double salarioAReceber = salarioBruto - imposto;

Console.WriteLine("Valor da hora trabalhada R$ " + valorHoraTrabalhada.ToString("F2"));
Console.WriteLine("Salário bruto R$ " + salarioBruto.ToString("F2"));
Console.WriteLine("Imposto R$ " + imposto.ToString("F2"));
Console.WriteLine("Salário a receber R$ " + salarioAReceber.ToString("F2"));

