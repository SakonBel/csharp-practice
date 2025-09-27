// Console.WriteLine("Hello, World!");

// int n1 = 10;
// string name = "Bel";
// char letter = 'Z';
// double n2 = 2.2;
// Console.WriteLine(name, n1 + n2);
// Console.WriteLine(letter);

// ------------- String Challenges ------------------
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));

// ------------- Number Challenges ------------------
double PI = Math.PI;
double radius = 2.50;
double circleArea = PI * (Math.Pow(radius, 2));
Console.WriteLine(circleArea);

// ------------- Lists Challenges ------------------
List<int> fibonacciNumbers = [1, 1];
int previous = fibonacciNumbers[^1];
int previous2 = fibonacciNumbers[^2];

int length = fibonacciNumbers.Count;
while (length < 21)
{
  fibonacciNumbers.Add(previous + previous2);
  previous = fibonacciNumbers[^1];
  previous2 = fibonacciNumbers[^2];
  length++;
}

foreach (int num in fibonacciNumbers)
{
  Console.WriteLine(num);
}