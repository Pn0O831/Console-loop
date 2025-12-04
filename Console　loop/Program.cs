// See https://aka.ms/new-console-template for more information

//①
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//②
string[] fruits = { "りんご", "みかん", "ぶどう" };
foreach (var item in fruits)
{
    Console.WriteLine(item);
}

//③
int num1 = 0;
while (num1 <= 100)
{
    Console.Write("数値を入力してください:");
    int Enter = Convert .ToInt32(Console.ReadLine());
    num1 = num1 + Enter;
    continue;
}
Console.WriteLine($"合計値は{num1}です");