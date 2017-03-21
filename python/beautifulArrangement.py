def beautifulArrangement(n):
	allowed = []
	for i in range (0, n):
		allowed.append([])

	for i in range (1, n+1):
		for j in range (1,n+1):
			if ((i%j == 0 ) or j%i ==0):
				print "true: " + str(i) + " "  + str(j)
				allowed[i-1].append(j)
			else:
				print "false: " + str(i) + " "  + str(j)

	


	print allowed

def somewhatAestheticallyPleasingArrangement(n):
	counter = 0
	queue = []
	x = []

	queue.append(x)

	while(len(queue) > 0):
		x = queue.pop()
		if len(x) == n:
			counter +=1
		else:
			for i in range(1, n+1):
				y = x[:] #note: this copies array values rather than refernece
				if i not in y:

					#since we're filling from beginning to end, this functionally checks the current
					#index (len(y)) vs a potential value (i)
					if (i % (len(y)+1) ==0) or ((1+len(y)) % i ==0):
						y.append(i) #adds a value to our growing candidate beautiful arrangement
						queue.append(y) #adds our candidate to the queue for later loop
	return counter


print(somewhatAestheticallyPleasingArrangement(2))
#beautifulArrangement(4)