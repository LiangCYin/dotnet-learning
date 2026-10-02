//Console.WriteLine("Hello, .NET World!");
//Console.WriteLine("我的名字是：小明");
//Console.WriteLine("今天是 .NET 第 1 天");
//Console.WriteLine("我要坚持 180 天");
// Console.Write("请输入你的名字：");
// string name = Console.ReadLine();
// Console.WriteLine("你好，" + name);

Console.WriteLine("请输入你的名字： ");
string name = Console.ReadLine();

Console.WriteLine("请输入你的年龄： ");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

Console.WriteLine("请输入你的城市： ");
string city = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("你好，" + name + "! ");
Console.WriteLine("你今年 " + age + " 岁， 来自 " +  city);
Console.WriteLine("明年你就 " + (age + 1) + "岁啦。");