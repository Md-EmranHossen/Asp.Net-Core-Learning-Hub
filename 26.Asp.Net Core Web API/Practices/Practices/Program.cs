string str = Console.ReadLine();
string[] num = str.Split(',');

for(int i = 0; i < num.Length; i++)
{
    num[i] = num[i].Trim();
}

int[] number = new int[num.Length];

for(int i = 0; i < num.Length; i++)
{
    number[i] = int.Parse(num[i]);
}