
//for
//while
//do-while
//foreach

//break
//continue

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

int count = 0;
while (count < 10)
{
    Console.WriteLine(count);
    count++;
}

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

count = 0;
while (count != 0)
{
    Console.WriteLine(count);
}

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

count = 0;
do
{
    Console.WriteLine(count);
    count++;
} while (count != 0 && count < 5);

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

for (int i = 0; i < 10; i++)
{
    if (i > 5)
    {
        break;
    }

    Console.WriteLine(i);
}

Console.WriteLine("=====");
Console.WriteLine();
Console.WriteLine("=====");

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }

    Console.WriteLine(i);
}

// infinite loop
/*
for (int i = 1; i > 0; i++)
{

}

while (true)
{

}

do
{

} while (true);
*/