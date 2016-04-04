# A palindromic number reads the same both ways. 
# The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
# Find the largest palindrome made from the product of two 3-digit numbers.

def reverse(x):
    r = 0;
    while x > 0:
        r = (10 * r) + (x % 10);
        x = x // 10;
    return r;

def isPalindrome(x):
    return x == reverse(x);

r = 0;
for i in range(999,99, -1):
    for j in range(999, i, -1):
        p = i*j;
        if isPalindrome(p) == True:
            if p > r:
                r = p;
                print(str(i*j) + ':' + str(isPalindrome(i*j)));
