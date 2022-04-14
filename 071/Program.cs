string alph = "аивс";
int number = 2;

Combination(alph, number);

void Combination(string alphabet, int number, string result = "")
{
    if (number == 0)
    {
        Console.WriteLine(result);
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        int current_num = number;
        Combination(alphabet, --current_num, result + alphabet[i].ToString());
    }
}
