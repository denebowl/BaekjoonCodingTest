class Baekjoon_11720
{
    static void Main(string[] args)
    {
        string num;
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            sr.ReadLine(); //첫째 줄 무시
            num = sr.ReadLine();
        }

        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += int.Parse(num[i].ToString());
        }

        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            sw.WriteLine(sum.ToString());
        }
    }
}