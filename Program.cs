Console.WriteLine("Skriv in vad du vill ha översatt till rövarspråket: ");
string Mening = Console.ReadLine().ToLower();

while (Mening.Length == 0)
{
    Console.WriteLine("Se till att du skriver något och inte bara trycker ENTER");
    Mening = Console.ReadLine().ToLower();
}

string NyMening = string.Empty;
char[] vocals = { 'a', 'e', 'i', 'u', 'y', 'å', 'ö', ' ', 'o', 'ä' };


foreach (char letter in Mening)
{

    NyMening += letter;

    if (!Exists(vocals, letter))
    {
        NyMening += "o" + letter;
    }

}
Console.WriteLine(NyMening);


bool Exists(char[] characters, char c)
{
    foreach (var item in characters)
    {
        if (item == c)
        {
            return true;
        }
    }
    return false;
}
Console.ReadLine();