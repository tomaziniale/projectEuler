/// <summary>
/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
/// Find the largest palindrome made from the product of two 3-digit numbers.
/// </summary>
private void E4()
{
    var r = 0;
    var v1 = 0;
    var v2 = 0;

    for (var i = 999; i >= 100; i--)
    {
        for (var j = 999; j >= i; j--)
        {
            var t = i * j;
            if (!IsPalindrome(t)) continue;

            if (t > r)
            {
                r = t;
                v1 = i;
                v2 = j;
            }
            break;
        }
    }

    Console.WriteLine("v1: " + v1);
    Console.WriteLine("v2: " + v2);
    Console.WriteLine("v1 * v2 " + v1 * v2);
}

private bool IsPalindrome(int t)
{
    //return string.Join("", t.ToString().Reverse()) == t.ToString();
    return reverse(t) == t;
}

private int reverse(int n)
{
    var r = 0;
    while (n > 0)
    {
        r = 10 * r + n % 10;
        n = n / 10;
    }
    return r;
}