/// <summary>
/// By considering the terms in the Fibonacci sequence whose values do not exceed four million,
/// find the sum of the even-valued terms.
/// </summary>
public void e2()
{
    var sum = 0;
    var fib = 1;
    var fib1 = 1;

    for (var i = 1; i < 4000000; i++)
    {
        var fib2 = fib1;
        fib1 = fib;
        fib = fib1 + fib2;
        i = fib;
        if (fib % 2 == 0) sum += fib;
    }

    Console.WriteLine("sum of the even-valued terms: " + sum);
}
