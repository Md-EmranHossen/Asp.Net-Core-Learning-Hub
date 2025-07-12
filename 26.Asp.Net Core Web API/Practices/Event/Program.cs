using Event;

SwitchFinct switch1 = new SwitchFinct();
Fan fan = new Fan();

switch1.OnPress += fan.Rotate;

while (true)
{
    string line = Console.ReadLine();
    if(line == "o")
    {
        break;
    }
    switch1.Press();
}