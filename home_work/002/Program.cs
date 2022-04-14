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
    //Console.Write(number + " "); // выводит в обратном порядке... долго не мог разобраться именно с выводом
    MonotonicSequence(--limit);
    Console.Write(number + " ");
}