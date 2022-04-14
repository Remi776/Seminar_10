Console.Write("Enter the number > 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Factorization(a);

void Factorization(int number)
{
    if (number == 0) return;
    for (int i = 2; i < 999; i++)
    {
        if (number % i == 0)
        {
            Console.Write(i + " ");
            Factorization(number / i);
            break;
        }
    }
}