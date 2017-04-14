class Node:
	def __init__(self, key, value):
		self.key = key
		self.value = value
		self.left = None
		self.right = None

def insertNode(currentNode, ordinance):

	if (ordinance < currentNode.key):
		if (currentNode.left != None):
			insertNode(currentNode.left, ordinance)
		else:
			currentNode.left = Node(ordinance, 1)
	elif (ordinance > currentNode. key):
		if (currentNode.right != None):
			insertNode(currentNode.right, ordinance)
		else:
			currentNode.right = Node(ordinance, 1)
	# key = vvalue
	else:
		currentNode.value += 1

def createSecondTree(currentNode, secondTreeRoot):

	if (currentNode.left != None):
		createSecondTree(currentNode.left, secondTreeRoot)
	elif (currentNode.right != None):
		createSecondTree(currentNode.right, secondTreeRoot)

	addSecondTree(secondTreeRoot, currentNode.value, currentNode.key)

def addSecondTree(currentNode, key, letter):

	
	if (key < currentNode.key):
		if (currentNode.left != None):
			addSecondTree(currentNode.left, key, letter)
		else:
			currentNode.left = Node(key, letter)
	elif (key >= currentNode.key):
		if (currentNode.right != None):
			addSecondTree(currentNode.right, key, letter)
		else:
			currentNode.right = Node(key, letter)


def iterateTree(currentNode):
	if (currentNode.left != None):
		iterateTree(currentNode.left)
	elif (currentNode.right != None):
		iterateTree(currentNode.right)


	print "key: " + str(currentNode.key)
	print "value: " + str(currentNode.value)

def iterateTreeforAnswer(currentNode, answer):
	print "starting"
	print chr(currentNode.value)
	if (currentNode.right != None):
		print "going right"
		answer= iterateTreeforAnswer(currentNode.right, answer)
	
	for i in range (0, currentNode.key):
		print i
		answer += chr(currentNode.value)
		print answer

	
	if (currentNode.left != None):
		print "going left"
		answer= iterateTreeforAnswer(currentNode.left, answer)

	print "returning"
	print answer
	return answer

class Heap:
	count = 0
	def __init__(self, capacity):
		self.array = [0] * capacity

	def addHeap(item):
		return



def frequencySort(s):
	root = Node(ord(s[0]), 1)
	for i in range (1, len(s)):
		ordinance = ord(s[i])
		insertNode(root, ordinance)

	#print "\n"	
	#print "first tree"
	#iterateTree(root)
	#print "\n"

	heap = Heap(25)
	print heap.count

	# secondTreeRoot = Node(root.value, root.key)
	# createSecondTree(root, secondTreeRoot)

	# answer = iterateTreeforAnswer(secondTreeRoot, "")
	# print answer

s = "test123444455466499"
frequencySort(s)