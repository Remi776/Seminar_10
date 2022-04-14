Console.Write("Enter the limit: ");
int m = Convert.ToInt32(Console.ReadLine());
MonotonicSequence(m);

void MonotonicSequence(int limit, int number = 0, int summ = 0)
{
    if (limit == 0) return;
    for (int i = 1; summ < limit; i++)
    {
        summ += i;
        number = i;
    }
    MonotonicSequence(--limit);
    Console.Write(number + " ");
}