void GenerateOrderIDs()
{
    /*
    This code is designed to assist in the fraud detection process by randomly generating a list of order
    IDs equal to the number of IDs the user wants to generate for testing (defaulted to 5).

    The format of the order ID is a capital letter A-Z,followed by 6 random numbers (e.g. "A123456").
*/

    Random random = new Random();
    string[] orderIDs = new string[5000]; // adjust the value in [] as needed

    for (int i = 0; i < orderIDs.Length; i++)
    {
        int prefixValue = random.Next(65, 92);
        string prefix = Convert.ToChar(prefixValue).ToString();
        string suffix = random.Next(1, 1000000).ToString("000000");
        orderIDs[i] = prefix + suffix;
    }

    foreach (var orderID in orderIDs)
    {
        Console.Write($"{orderID}\t");
    }
}

/*

The Original Badly-Written Code
 
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

*/

// vvv The New, Better-Written Code vvv
void SentenceReverserCharacterCounter()
{
/*

    This code takes a user-generated sentence and reverses it, counts the number of times a certain
    letter appears in the sentence, then displays to the user the reversed sentence as well as the number
    of times the letter appears.

*/

    string originalSentence = "The quick brown fox jumps over the lazy dog.";

    char[] allLettersInOriginalSentence = originalSentence.ToCharArray();
    Array.Reverse(allLettersInOriginalSentence);

    int numberOfTimesLetterAppears = 0;

    foreach (char letter in allLettersInOriginalSentence)
    {
        if (letter == 'o')
        {
            numberOfTimesLetterAppears++;
        }
    }

    string reversedSentence = new string(allLettersInOriginalSentence);

    Console.WriteLine(reversedSentence);
    Console.WriteLine($"The letter 'o' appears {numberOfTimesLetterAppears} times.");
}