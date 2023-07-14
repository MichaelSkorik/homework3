Console.Clear();
Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <=num; i++);
{
    int ans = i * i * i;
    Console.WriteLine(ans);
}