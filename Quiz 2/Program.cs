// See https://aka.ms/new-console-template for more information


bool checkPalindrome(String word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

int[] getLongestChain(int[] arr)
{
    int[] result = new int[2];
    int guess = arr[0];
    int bestGuess = guess;
    int maxLength = 1;
    int chainLength = 1;

    for (int i=1; i<arr.Length; i++)
    {
        if (guess == arr[i])
        {
            chainLength++;
        }
        else
        {
            if (maxLength < chainLength)
            {
                maxLength = chainLength;
                chainLength = 1;
                bestGuess = guess;
            }
            guess = arr[i];
        }
    }

    result[0] = maxLength;
    result[1] = bestGuess;

    return result;
}

//N.1

Console.WriteLine("Enter array size: ");

int n = Int16.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Write " + n + "numbers");

int odd = 0, even = 1;

for (int i= 0; i < n; i++)
{
    arr[i] = Int16.Parse(Console.ReadLine());
    if (arr[i] % 2 == 1) odd += arr[i];
    else even *= arr[i];
}


//N.2
Console.WriteLine("Enter a word: ");
String word = Console.ReadLine();

Console.WriteLine(word + "is palindrome: " + checkPalindrome(word));

//N.3
Console.WriteLine("size of biggest chain in array: " + getLongestChain(arr)[0]);
Console.WriteLine("most chained integer: " + getLongestChain(arr)[1]);

//N.4
Console.WriteLine("max integer: " + arr.Max());
