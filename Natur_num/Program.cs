// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, 
//которые
// делятся на k, но на l
// делятся хотябы на k или на l
// не делятся на (k + l)

//Делятся на оба значения

/*uint n = 256;
uint k = 12;
uint l = 2;

int count = 0;

while (count < n)
{
    if (count % k == 0 && count % l == 0)
    {
        Console.WriteLine(count);
    }
    count ++;
}*/

// Делятся хотя бы на одно значение

/*uint n = 256;
uint k = 13;
uint l = 9;

int count = 0;

while (count < n)
{
    if (count % k == 0 || count % l == 0)
    {
        Console.WriteLine(count);
    }
    count ++;
}*/

// не делятся на сумму k + l

/*uint n = 256;
uint k = 1;
uint l = 1;

int count = 0;

while (count < n)
{
    if (count % (k+l) != 0 )
    {
        Console.WriteLine(count);
    }
    count ++;
}*/