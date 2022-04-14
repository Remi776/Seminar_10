int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Fibonacci(a, b);

void Fibonacci()
{
    if (count == 0) return;
    
    else
    {
        Console.Write(a + " ");
        (a, b) = (b, a + 1);
    }
}