// See https://aka.ms/new-console-template for more information
using Lightstone;

Console.WriteLine("Enter test cases?");
string numberOfCases = Console.ReadLine();

int value;
if (int.TryParse(numberOfCases, out value)) {
    string combinedSentences = "";
	for (int i = 1; i <= value; i++)
	{
        Console.WriteLine($"\nEnter sentence {i}");
        string sentence = Console.ReadLine();

        string results = Problem.ReverseSentence(sentence);

        combinedSentences += $"Case {i} {results}\n";
    }

    Console.WriteLine("\n\n" + combinedSentences);
}else
    Console.WriteLine("Invalid input");

