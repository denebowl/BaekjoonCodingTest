class Baekjoon_1065
{
    static void Main(string[] args)
    {
        int max;
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            max = int.Parse(sr.ReadLine());
        }

        int count = 0;
        for (int i = 1; i <= max; i++)
        {
            bool result = Check(i);
            if (result)
                count++;
        }

        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            sw.WriteLine(count.ToString());
        }
    }
    private static bool Check(int num)
    {
        int numOfDigits = (int)(Math.Log10(num)) + 1; //자릿수

        if (numOfDigits <= 2) //1~99 (2자리수 미만은 항상 True)
            return true;

        //각 자리 숫자를 분리하여 digits에 넣음.
        int[] digits = new int[numOfDigits];
        for (int i = 0; i < numOfDigits; i++)
        {
            int dec1 = (int)Math.Pow(10, i + 1);
            int dec2 = (int)Math.Pow(10, i);
            int digit = (num % dec1) / dec2;
            digits[i] = digit;
        }

        //첫번째, 두번째 숫자 간 차이를 interval에 넣고,
        //이후 세번째 자리부터 마지막 자리까지 모두 일치하는지 체크.
        int interval = digits[1] - digits[0];
        for (int i = 1; i < digits.Length - 1; i++)
        {
            //i+1번째 자리 <-> i+2번째 자리 간 차이가 interval과 일치하는지 확인.
            //다른 경우 false
            if (interval != digits[i + 1] - digits[i])
                return false;
        }

        //모든 확인이 끝난 경우 true
        return true;
    }
}