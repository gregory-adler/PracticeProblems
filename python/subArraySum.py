def checkSubArray(nums, k):
	currentValue = 0;
	target = k
	for i in range (0, len(nums)):
		currentValue = 0
		currentValue += nums[i]
		for j in range (i+1, len(nums)):
			print "i : " + str(i);
			print "currentValue + nums[j]: " + str(currentValue + nums[j])
			if ((currentValue) + nums[j])% target == 0:
				return True;
			else:
				currentValue += nums[j]

	return False;
 

testArray = [8, 23, 2, 6, 4, 7, 9, 5]
target =  42
print (checkSubArray(testArray, target));