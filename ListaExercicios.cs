// Professor, estou adicionando aqui no repositório a versão em Csharp para salvar junto, estou utilizando a sua lista para praticar para a matéria e também para o meu profissional

// Ex 1 - Hello, World!
Console.WriteLine("hello, world! altas expectativas para sua aula, professor Fabiano!");

// Ex 2 - Soma de dois números
Console.WriteLine("por favor, digite dois números para realizarmos uma soma");

Console.Write("primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("a soma de " + num1 + " mais " + num2 + " é igual a: " + (num1 + num2));
Console.WriteLine($"a soma de {num1} mais {num2} é igual a: {num1 + num2}");

// Ex 3 - Cálculo da Área do Círculo
Console.WriteLine("por favor, digite a seguir o raio de um círculo para calcularmos a área");

double raio = double.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine("a área do círculo é: " + area);
Console.WriteLine($"a área do círculo é: {area:F2}");

// Ex 4 - Cálculo da Área do Círculo
Console.WriteLine("por favor, digite uma temperatura em celsius para convertermos para fahrenheit:");

double celsius = double.Parse(Console.ReadLine());

double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine($"a temperatura em fahrenheit é: {fahrenheit:F2}");

// Ex 5 - Tabuada
Console.WriteLine("por favor, digite um número para vermos a tabuada dele");

int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}

// Ex 6 - Números pares

Console.WriteLine("a seguir, todos os números pares de 1 a 20");
for (int numero = 1; numero <= 20; numero++)
{
    if (numero % 2 == 0)
        Console.WriteLine(numero);
}

// Ex 7 - Números Ímpar ou Par
Console.WriteLine("por favor, digite um número para descobrirmos se é ímpar ou par");

int num7 = int.Parse(Console.ReadLine());

if (num7 % 2 == 0)
    Console.WriteLine("é par!");
else
    Console.WriteLine("é impar!");

// Ex 8 - Verificação de Palíndromo
Console.WriteLine("por favor, digite uma palavra para descobrirmos se essa palavra é um palíndromo");

string palavra = Console.ReadLine();
char[] palavraArr = palavra.ToCharArray();
Array.Reverse(palavraArr);
string palavraInvertida = new string(palavraArr);

if (palavra == palavraInvertida)
    Console.WriteLine("opa, sua palavra é um palíndromo!");
else
    Console.WriteLine("não é um palíndromo!");

// Ex 9 - Fatorial de um número
Console.WriteLine("por favor, digite um número");

int num9 = int.Parse(Console.ReadLine());

long fatorial = 1;

for (int i = 1; i <= num9; i++)
{
    fatorial = fatorial * i;
}

Console.WriteLine($"o fatorial é: {fatorial}");

// Ex 10 - Sequência de Fibonacci
int a = 0;
int b = 1;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(a);

    int c = a + b;
    a = b;
    b = c;
}

// Ex 11 - Lista de Números
List<int> lista = new List<int> { 5, 12, 3, 67, 7, 127 };
Console.WriteLine($"o maior número é: {lista.Max()}");
Console.WriteLine($"o menor número é: {lista.Min()}");

// Ex 12 - Contagem de caracteres
Console.WriteLine("por favor, digite uma palavra: ");

string palavra12 = Console.ReadLine();

Dictionary<char, int> count = new Dictionary<char, int>();

foreach (char carac in palavra12)
{
    if (count.ContainsKey(carac))
        count[carac] = count[carac] + 1;
    else
        count[carac] = 1;
}

Console.WriteLine($"essa foi a quantidade de caracteres únicos {string.Join(", ", count)}");

// Ex 13 - Ordenação de lista
List<int> listinha13 = new List<int> { 3, 21, 17, 67, 2, 9 };
listinha13.Sort();
Console.WriteLine($"lista ordenada: {string.Join(", ", listinha13)}");

// Ex 14 - Soma dos elementos de uma pista
List<int> listinha14 = new List<int> { 34, 21, 3, 8, 73, 127 };
int soma14 = listinha14.Sum();
Console.WriteLine($"lista somada: {soma14}");

// Ex 15 - Média de uma Lista
List<int> listinha15 = new List<int> { 12, 31, 78, 23, 1, 54, 9 };
int soma15 = listinha15.Sum();
int quant = listinha15.Count;
double media = (double)soma15 / quant;
Console.WriteLine($"a média é: {media}");

// Ex 16 - Manipulação de Strings
Console.WriteLine("por favor, digite uma palavra: ");

string palavra16 = Console.ReadLine();
char[] invertArr = palavra16.ToCharArray();
Array.Reverse(invertArr);
string invert = new string(invertArr);

Console.WriteLine($"veja a sua palavra invertida {invert}");

// Ex 17 - Dicionário de Contagem de Palavras
Console.WriteLine("por favor, digite uma frase do tamanho que quiser:");

string frase = Console.ReadLine();

string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> contagem = new Dictionary<string, int>();

foreach (string palavraAtual in palavras)
{
    if (contagem.ContainsKey(palavraAtual))
        contagem[palavraAtual] = contagem[palavraAtual] + 1;
    else
        contagem[palavraAtual] = 1;
}

Console.WriteLine($"sua frase possui essa quantidade de palavras: {string.Join(", ", contagem)}");

// Ex 18 - Número Primo
Console.Write("por favor, digite um número: ");
int num18 = int.Parse(Console.ReadLine());

bool primo = true;

if (num18 < 2)
{
    primo = false;
}
else
{
    for (int i = 2; i < num18; i++)
    {
        if (num18 % i == 0)
        {
            primo = false;
            break;
        }
    }
}

if (primo)
    Console.WriteLine("é primo!");
else
    Console.WriteLine("não é primo!");

// Ex 19 - Jogo de Adivinhação
Random rand19 = new Random();
int secreto = rand19.Next(1, 101);

int tentativa = 0;

while (tentativa != secreto)
{
    Console.WriteLine("tente adivinhar o número entre 1 e 100, boa sorte! ");
    tentativa = int.Parse(Console.ReadLine());

    if (tentativa < secreto)
        Console.WriteLine("mais alto!");
    else if (tentativa > secreto)
        Console.WriteLine("mais baixo!");
}

Console.WriteLine("você acertou (finalmente)!");

// Ex 20 - Matriz Transposta
int[,] matriz = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int[,] transposta = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        transposta[i, j] = matriz[j, i];
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
        Console.Write(transposta[i, j] + " ");
    Console.WriteLine();
}

// Ex 21 - Busca Binária
static int BuscaBinaria(int[] lista, int alvo)
{
    int inicio = 0;
    int fim = lista.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] == alvo)
            return meio;
        else if (lista[meio] < alvo)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }

    return -1;
}

int[] listaOrdenada = { 1, 3, 5, 7, 9, 11, 13 };

int resultado21 = BuscaBinaria(listaOrdenada, 7);

Console.WriteLine(resultado21);

// Ex 22 - Criptografia de Cifra de César
static string CriptografarCesar(string texto, int deslocamento)
{
    string resultado = "";

    foreach (char letra in texto)
    {
        if (char.IsLetter(letra))
        {
            int codigo = letra;
            int novoCodigo = codigo + deslocamento;
            resultado = resultado + (char)novoCodigo;
        }
        else
        {
            resultado = resultado + letra;
        }
    }

    return resultado;
}

string texto22 = "Aluno Pedro Marcondes!";

string resultado22 = CriptografarCesar(texto22, 3);

Console.WriteLine(resultado22);

// Ex 23 - Descriptografar Cifra de César
static string DescriptografarCesar(string texto, int deslocamento)
{
    string resultado = "";

    foreach (char letra in texto)
    {
        if (char.IsLetter(letra))
        {
            int codigo = letra;
            int novoCodigo = codigo - deslocamento;
            resultado = resultado + (char)novoCodigo;
        }
        else
        {
            resultado = resultado + letra;
        }
    }

    return resultado;
}

string texto23 = "Doxqr S hg urpdqghv!";

string resultado23 = DescriptografarCesar(texto23, 3);

Console.WriteLine("textoo criptografado: " + texto23);
Console.WriteLine("texto original: " + resultado23);
