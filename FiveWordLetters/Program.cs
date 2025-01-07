using System.Runtime.InteropServices;

int currentword = -1;


// Reads our txt file
string[] Readtext = File.ReadAllLines(@"C:\Users\HFGF\Documents\words_beta_new.txt");

foreach (string line in Readtext)
{
    int count = 0;

    // We will be storing the used letters here
    char[] templetters = new char[26];
    int templettercount = 0;

    // Here We will be storing the 5 Words 
    string[] checkingtext = new string[5];

    for (int i = 0; 5 > i++;)
    {
        checkingtext[count++] = Readtext[currentword++];
    }
    foreach (string word in checkingtext)
    {
        Console.WriteLine(word);
        foreach (char letters in word)
        {
            if (templetters.Contains(letters) == false)
            {
                templetters[templettercount++] = letters;
            }
            else
            {
//                Console.WriteLine($"We Already have {letters}");
            }
        }

    }
}