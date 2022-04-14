Console.Write("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());
ReverseNumber(a);

void ReverseNumber(int number)
{
    if (number == 0) return;
    Console.Write(number % 10);
    ReverseNumber(number / 10);
}
