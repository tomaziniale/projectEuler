private void E3()
{
	var d1 = GetDivisors(13195);
	Console.Write("Prime factor from 13195: ");
	d1.ToList().ForEach(e => Console.Write(e + ", "));
	Console.WriteLine();

	Console.Write("Prime factor from 600851475143: ");
	var d2 = GetDivisors(600851475143);
	d2.ToList().ForEach(e => Console.Write(e + ", "));
}

private bool isPrime(int x)
{
	var divisors = 0;

	for (var i = 1; i <= x; i++)
	{
		if (x % i == 0) divisors++;
		if (divisors > 2) return false;
	}

	return true;
}

private IEnumerable<int> GetDivisors(long x)
{
	var lista = new List<int>();

	for (var i = 1; x > 1; i++)
	{
		if (!isPrime(i) || (x % i != 0)) continue;
		x = x / i;
		lista.Add(i);
	}

	return lista;
}