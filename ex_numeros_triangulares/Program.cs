int nt = 0;
int contador = 0;
int nd = 0;
int tk = 0;
string teste = "Ola";
string ola = "hello";

Console.WriteLine("Digite um número");
nd = Convert.ToInt32(Console.ReadLine());

//contador++;


while (nt < nd)
{
    contador++;
    nt = (contador + nt / tk);
}

if (nd == nt)
{
    Console.WriteLine("Esse número é triângular");
}
else
{
    Console.WriteLine("Esse número não é triângular");
}

