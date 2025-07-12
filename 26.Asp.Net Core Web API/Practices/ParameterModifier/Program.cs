

(int v1,int v2) GetTwoRendomNumber()
{
    Random random = new Random(DateTime.Now.Microsecond);
    int n1 = random.Next(1, 500);
    int n2 = random.Next(1, 500);

    return (n1, n2);
}


var result = GetTwoRendomNumber();

int x = result.v2;