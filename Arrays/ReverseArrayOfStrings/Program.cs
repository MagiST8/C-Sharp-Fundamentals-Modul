string n=Console.ReadLine();
string[] items=n.Split();
string[]arr=new string[items.Length];

for (int i = items.Length-1; i >=0; i--)
{
    Console.Write($"{items[i]} ");
}
