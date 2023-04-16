int number = 7665284;

string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
List<char> numbers = new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

foreach (var digiti in numbers)
{
    int count = 0;
    foreach (var sign in letters)
    {
        if (digiti == sign)
        { count++;
        }
    }
    Console.WriteLine(digiti + "-lość poszczególnego znaku w zadanej liczbie:" + count);
}
