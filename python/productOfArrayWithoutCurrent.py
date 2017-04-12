def productExceptSelf(nums):
	newArray = [0] * len(nums);
	answers = [0] * len(nums);
	product = 1;

	for j in range (len(nums)-1, -1, -1):
		product = product * nums[j]
		newArray[j] = product

	product = 1

	for i in range (0, len(nums)):
		print "i: " + str(i)
		print "product " + str(product)

		if (i+1 < len(nums)):
			print "newArray: " + str(newArray[i+1])
			answers[i] = product * newArray[i+1]
			product *= nums[i]
		else: 
			answers[i] = product

nums = [1,2,3,4]
productExceptSelf(nums);