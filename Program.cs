
//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));


Console.WriteLine($"Digite seu nome:");

string nome = Console.ReadLine();

while( nome == "" )
{
    Console.WriteLine($"A sessão nome não foi preenchida corretamente.Digite novamente:");
    nome = Console.ReadLine();
    
    
}

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

while( idade == 0 || idade > 100 )
{

 Console.WriteLine($"O campo idade não está preenchido corretamente.Digite novamente:");
 idade = int.Parse(Console.ReadLine());
 
 
}

Console.WriteLine($"Digite seu salário");

float salario = float.Parse(Console.ReadLine());

while( salario == 0)
{
    Console.WriteLine($"O campo salário não está preenchido corretamente");
    salario = float.Parse(Console.ReadLine());
    
    
}

Console.WriteLine($"Digite seu estado civil");

char estadoCivil = char.Parse(Console.ReadLine());

while( estadoCivil != 's' && estadoCivil !='c' && estadoCivil != 'v' && estadoCivil != 'd' )
{
 Console.WriteLine($"O campo estado cívil não está preenchido corretamente");
 estadoCivil = char.Parse(Console.ReadLine());
 
 
}







