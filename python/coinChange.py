def coinChange(coins, amount):
	x = [1000 for i in range (0, amount + 1)]

	for coin in coins:
		x[coin] = 1

	print "problem \n"

	for i in range (1, amount+1):
		validcoins = [a for a in coins if a<=i]
		for j in validcoins:
			if (x[i-j] != 1000):
				#print "i: " + str(i)
				#print "i-j: " + str((i-j))
				if (x[i-j]+1 < x[i]):
					x[i] = x[i-j]+1

	print "answer \n"

	for y in range (1, len(x)):
		print "y: " + str(y)
		print "value: " + str(x[y])



coins = [1,2,5]
amount = 11

coinChange(coins, amount)