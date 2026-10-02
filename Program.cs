//Console.WriteLine("Hello, .NET World!");
//Console.WriteLine("我的名字是：小明");
//Console.WriteLine("今天是 .NET 第 1 天");
//Console.WriteLine("我要坚持 180 天");
// Console.Write("请输入你的名字：");
// string name = Console.ReadLine();
// Console.WriteLine("你好，" + name);


//Console.WriteLine("请输入你的名字： ");
//string name = Console.ReadLine();

//Console.WriteLine("请输入你的年龄： ");
//string ageInput = Console.ReadLine();
//int age = int.Parse(ageInput);

//Console.WriteLine("请输入你的城市： ");
//string city = Console.ReadLine();

//Console.WriteLine();
//Console.WriteLine("你好，" + name + "! ");
//Console.WriteLine("你今年 " + age + " 岁， 来自 " +  city);
//Console.WriteLine("明年你就 " + (age + 1) + "岁啦。");


Random random = new Random();
int answer = random.Next(1, 101);

int guess = 0;  
int count = 0;

Console.WriteLine("我想了一个 1 到 100 的数字， 你来猜： ");

while(guess != answer)
{
    Console.WriteLine("请输入你的猜测： ");
    string input = Console.ReadLine();
    guess = int.Parse(input);
    count++;

    if(guess > answer)
    {
        Console.WriteLine("太大了！再试试");
    }else if (guess < answer)
    {
        Console.WriteLine("太小了！再试试");
    }
    else
    {
        Console.WriteLine("恭喜你， 猜对了！ 用了 " + count + " 次");
    }
}