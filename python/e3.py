# Largest prime factor

def isPrime(x):
    divided = 1;
    for i in range(1,x):
        if x % i == 0: divided += 1;
        if divided > 2: return False;
    return True;

def getDivisors(x):
    i = 1;
    divisors = [];
    while i <= x:        
        if isPrime(i):
            if x % i == 0:
                divisors.append(i);                
                x = x / i;
        i += 1;
    
    return divisors;

print(getDivisors(13195));
print(getDivisors(600851475143));
