def laidoff(n, k):
	dictionary = {}
	dictionary[str(1)] = 1
	for i in range (2, n+1):
		key = str(i -1)
		remainder = (dictionary[(key)] + k) % i
		if remainder == 0:
			dictionary[str(i)] = n
		else:
			dictionary[str(i)] = remainder

	print dictionary[str(n)]

laidoff(6,3);