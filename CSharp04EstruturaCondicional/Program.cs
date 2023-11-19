double salario = 2571.30;
// Se o salário for maior que 8k ele recebe um bônus de 10%

if (salario > 8_000)
{
    double valorBonus = salario * 0.1; // salario * 10%
    salario = salario + valorBonus;
}

Console.WriteLine("Salário: " + salario);
double valorInss = 0;
double aliquota = 0;
if (salario <= 1302.00) // se
{
    aliquota = 0.075; // 7.5% de INSS
}
else if(salario <= 2571.29) // senão se
{
    aliquota = 0.09; // 9% de INSS
}
else if(salario <= 3856.94) // senão se
{
    aliquota = 0.12; // 12% de INSS
}
else // senão
{
    aliquota = 0.14; // 14% de INSS
}
valorInss = salario * aliquota;

Console.WriteLine("INSS: " + valorInss);

// Operadores Relacionais
// Igual            ==      exemplo if(numero == 10) => verificar que o número é o número 10
// Menor            <       exemplo if(numero < 10) => verificar se número é menor que 10
// Menor ou igual   <=      exemplo if(numero <= 10) => verificar se número é menor ou igual a 10
// Maior            >       exemplo if(numero > 10) => verificar se número é maior que 10
// Maior            >=      exemplo if(numero >= 10) => verificar se número é maior ou igual a 10
// Diferente        !=      exemplo if(numero != 10) => verificar que número não é o número 10

