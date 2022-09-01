class Baekjoon4673
{
    static void Main(string[] args)
    {
        int max = 10000;
        HashSet<int> result = new HashSet<int>();
        for (int i = 1; i < max; i++)
        {
            result.Add(i);
        }

        for (int i = 1; i < max; i++)
        {
            int n = D(i);
            result.Remove(n);
        }

        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            foreach (int n in result)
            {
                sw.WriteLine(n);
            }
        }
    }
    private static int D(int num)
    {
        int result = num;
        int digits = (int)(Math.Log10(num)) + 1; //자릿수
        for (int i = 0; i < digits; i++)
        {
            int dec1 = (int)Math.Pow(10, i + 1);
            int dec2 = (int)Math.Pow(10, i);

            int digit = (num % dec1) / dec2;
            result += digit;
        }
        return result;
    }
}