def convert(s, numRows):
	
	print "word: " + s

	zig = numRows

	zag = numRows -2
	if (zag <= 0 ):
		zag = 0

	string_pointer = 0
	row_pointer = 0

	print "zig: " + str(zig)
	print "zag: " + str(zag)

	data = [""] * numRows
	answer = ""

	while (string_pointer < len(s)):
		while (row_pointer < zig):
			print (row_pointer)
			print s[string_pointer]
			data[row_pointer] += s[string_pointer]
			string_pointer +=1
			if (string_pointer >= len(s)):
				break
			row_pointer += 1
		print "ENDING ZIG STARTING ZAG"
		row_pointer = zag
		if (string_pointer >= len(s)):
			break
		print "row_pointer: " + str(row_pointer)
		while (row_pointer >=1 and zag !=0):
			print (row_pointer)
			print s[string_pointer]
			data[row_pointer] += s[string_pointer]
			string_pointer +=1
			if (string_pointer >= len(s)):
				break
			row_pointer -= 1
		print "ENDING ZAG"
		row_pointer = 0


	for i in data:
		answer += i

	print answer

	return answer;






s = "ABCDEF";
n = 4

convert(s, n)