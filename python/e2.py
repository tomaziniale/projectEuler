# By considering the terms in the Fibonacci sequence whose values do not exceed four million,
# find the sum of the even-valued terms.

loop = 1; 
sum = 0; 
fib = 1; 
fib1 = 1; 
fib2 = 1; 
 
while loop < 4000000: 
	print(fib); 
	fib2 = fib1; 
	fib1 = fib; 
	fib = fib1+fib2;  
	loop = fib; 
	
	if fib%2 == 0: 
		sum += fib; 
 
print('fim. ' + str(sum));
