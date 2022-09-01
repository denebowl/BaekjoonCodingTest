class Baekjoon_10809
{
    static void Main(string[] args)
    {
        string line;
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            line = sr.ReadLine();
        }

        int[] result = new int['z' - 'a' + 1]; //알파벳 배열 갯수만큼 할당.
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = -1; //-1로 초기화
        }

        //각 알파벳 확인
        for (int i = 0; i < 'z' - 'a' + 1; i++)
        {
            char alphabet = (char)('a' + i);
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] == alphabet)
                {
                    result[i] = j;
                    break;
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            string output = string.Empty;
            for (int i = 0; i < 'z' - 'a' + 1; i++)
            {
                output += result[i] + " ";
            }
            sw.WriteLine(output.Trim());
        }
    }
}