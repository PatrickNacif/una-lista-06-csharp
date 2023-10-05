int[] vetor = new int[5]; // Cria um vetor de 5 elementos


vetor[0] = 10;
vetor[1] = 20;
vetor[2] = 30;
vetor[3] = 40;
vetor[4] = 50;


Console.WriteLine("Elemento 0: " + vetor[0]);
Console.WriteLine("Elemento 1: " + vetor[1]);
Console.WriteLine("Elemento 2: " + vetor[2]);
Console.WriteLine("Elemento 3: " + vetor[3]);
Console.WriteLine("Elemento 4: " + vetor[4]);


int soma = 0;
foreach (int elemento in vetor)
{
  soma += elemento;
}
Console.WriteLine("Soma dos elementos: " + soma);


int tamanho = vetor.Length;
Console.WriteLine("Tamanho do vetor: " + tamanho);


for (int i = 0; i < vetor.Length; i++)
{
  Console.WriteLine("Elemento " + i + ": " + vetor[i]);
}


foreach (int elemento in vetor)
{
  Console.WriteLine("Elemento: " + elemento);
}


try
{
  int valorInvalido = vetor[10];
}
catch (IndexOutOfRangeException e)
{
  Console.WriteLine("Erro ao acessar elemento: " + e.Message);
}

Console.ReadLine();
