# 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
# What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

divs = 0
target = 20
n = target

while divs < target:
    divs=0
    for i in range(1, target+1):        
        if n % i == 0:
            divs += 1
        else:
            n += 1
            break
    
print("the number is: " + str(n))
