double[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
double[] array = new double[info.Length];
int l = 0;

for (int i = 0; i < info.Length; i++)
{
    int pow = info[i] - 1;
    for (int j = 0; j < info[i]; j++)
    {
        array[i] += data[l] * Math.Pow(2, pow);
        pow--;
        l++;
    }
    Console.Write($"{array[i],-5}");
}
