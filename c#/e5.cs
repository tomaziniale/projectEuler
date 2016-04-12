/// <summary>                
/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
/// </summary>
public void E5()
{
    var divs = 0;
    var target = 20;
    int n = target; // the minimun divisible by the max

    while (divs < target)
    {
        divs = 0;
        for (int i = 1; i <= target; i++)
        {
            if (n % i == 0) divs++;
            else {
                n++;
                break;
            }
        }
    }

    for (var k = 1; k <= target; k++)
    {
        Console.WriteLine("i:" + k + " div:" + n % k);
    }

    Console.WriteLine("fim E5: " + n);
    Console.Read();
}