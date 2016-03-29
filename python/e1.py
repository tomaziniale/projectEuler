def divide(x,y,z): 
	if x % y == 0: 
		return i; 
	elif x % z == 0: 
		return i; 
	return 0; 
 
soma = 0; 
 
for i in range(1,1000): 
	soma = soma + divide(i,3,5); 
 
print(soma); 