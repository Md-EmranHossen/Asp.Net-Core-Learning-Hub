

using static Delegate.Test;

Calculate AddTwoNumber = sum;


int sum(int a, int b)
{
    return a + b;
}


int result = AddTwoNumber(3, 4);


void print(int a, int b, Calculate logic)
{
    Console.WriteLine(logic(a,b));
}

print(4, 5, sum);