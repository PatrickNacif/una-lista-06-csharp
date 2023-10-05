int[,] matriz = new int[3, 3]; // Cria uma matriz 3x3 de inteiros

// Preencher a matriz com valores
matriz[0, 0] = 1;
matriz[0, 1] = 2;
matriz[0, 2] = 3;
matriz[1, 0] = 4;
matriz[1, 1] = 5;
matriz[1, 2] = 6;
matriz[2, 0] = 7;
matriz[2, 1] = 8;
matriz[2, 2] = 9;

// Acessar e exibir os valores da matriz
for (int linha = 0; linha < 3; linha++)
{
  for (int coluna = 0; coluna < 3; coluna++)
  {
    Console.Write(matriz[linha, coluna] + " ");
  }
  Console.WriteLine(); // Quebra de linha para a próxima linha da matriz
}

// Tamanho da matriz
int linhas = matriz.GetLength(0); // Número de linhas
int colunas = matriz.GetLength(1); // Número de colunas
Console.WriteLine("Número de linhas: " + linhas);
Console.WriteLine("Número de colunas: " + colunas);

// Você também pode usar loops foreach para percorrer a matriz
foreach (int elemento in matriz)
{
  Console.Write(elemento + " ");
}

Console.ReadLine();