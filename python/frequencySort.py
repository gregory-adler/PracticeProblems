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
			insertNode(currentNode.right)
		else:
			currentNode.right = Node(ordinance, 1)
	# key = vvalue
	else:
		print "same condition"
		currentNode.value += 1

def createSecondTree(currentNode, secondTreeRoot):
	if (currentNode.left != None):
		createSecondTree(currentNode.left, secondTreeRoot)
	elif (currentNode.right != None):
		createSecondTree(currentNode.right, secondTreeRoot)
	secondTree(secondTreeRoot, currentNode, currentNode.value)

def secondTree(secondTreeRoot, currentNode, value):

	# if value == root

	if (secondTreeRoot == currentNode):
		return
	
	if (value < currentNode.value):
		if (currentNode.left != None):
			currentNode = currentNode.left
		else:
			currentNode.left = Node(ordinance, 1)
	elif (value > currentNode.value):
		if (currentNode.right != None):
			currentNode = currentNode.right
		else:
			currentNode.right = Node(ordinance, 1)


def frequencySort(s):
	root = Node(ord(s[0]), 1)
	for i in range (1, len(s)):
		ordinance = ord(s[i])
		insertNode(root, ordinance)

	secondTreeRoot = Node(root.value, root.key)

	createSecondTree(root, secondTreeRoot)

s = "eeees"
frequencySort(s)