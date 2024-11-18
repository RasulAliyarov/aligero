

using System.Globalization;


/* Task 1 */
string ChangeStringOrder(string word)
{
    // Return if word is empty
    if (string.IsNullOrEmpty(word)) 
        return word;

    word = word.ToLower();

    string newWord = "";

    // Iteraate from last
    for (int i = word.Length - 1; i >= 0; i--)
    {
        // If it is the last letter, we capitalize it. Otherwise just connect.
        newWord += (i == word.Length - 1) ? char.ToUpper(word[i]) : word[i];
    }

    return newWord;
}

//Console.WriteLine(ChangeStringOrder("Agilero"));
//Console.WriteLine(ChangeStringOrder("ADAM"));


/* Task 2 */
int[,] MatrixCalculate(int[,] matrix)
{
    int n = matrix.GetLength(0);
    if (n <= 2)
    {
        throw new ArgumentException("Matrix size must be greater than 2");
    }

    int[,] result = new int[2, 2];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // Pass diagonal
            if (i == j || i + j == n - 1)
                continue;

            // Green
            if (i < j && i + j < n - 1)
            {
                result[0, 0] += matrix[i, j];
            }
            // Orange
            else if (i < j && i + j > n - 1)
            {
                result[1, 0] += matrix[i, j];
            }
            // Yellow
            else if (i > j && i + j < n - 1)
            {
                result[1, 1] += matrix[i, j];
            }
            // Blue
            else if (i > j && i + j > n - 1)
            {
                result[0, 1] += matrix[i, j];
            }
        }
    }

    return result;
}

int[,] matrix = {
    {0, 1, 2, 3, 4},
    {1, 1, 2, 3, 4},
    {2, 2, 2, 3, 4},
    {3, 3, 3, 3, 4},
    {4, 4, 4, 4, 4}
};

//int[,] result = MatrixCalculate(matrix);

//Console.WriteLine($"{result[0, 0]} {result[0, 1]}");
//Console.WriteLine($"{result[1, 0]} {result[1, 1]}");

