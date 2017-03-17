def listPractice():
	test = ["one", "two", "three", "four", "five"]
	new_list = [[x.upper(), x.lower(), len(x)] for x in test]
	for x in new_list:
		print x

listPractice();