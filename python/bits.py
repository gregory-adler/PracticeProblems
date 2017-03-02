def bits (a):
	binary = bin(a)
	count = 0

	for i in range (2, len(binary)):
		if (binary[i] == '1'):
			count+=1

	return count
print(bits(7))