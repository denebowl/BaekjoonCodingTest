class Baekjoon4344
{
    static void Main(string[] args)
    {
        int totalCase;
        int[][] records;
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            totalCase = int.Parse(sr.ReadLine());
            records = new int[totalCase][];

            for (int i = 0; i < totalCase; i++)
            {
                records[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                double sum = 0d;
                for (int j = 1; j < records[i].Length; j++)
                {
                    sum += records[i][j];
                }
                double average = sum / records[i][0];

                int above = 0;
                for (int j = 1; j < records[i].Length; j++)
                {
                    if(records[i][j] > average)
                        above++;
                }

                double aboveRate = (double)above / records[i][0] * 100;

                //print
                using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                {
                    sw.WriteLine(String.Format("{0:0.000}%", aboveRate));
                }
            }
        }
    }
}