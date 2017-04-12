class Node:
	def __init__(self, key, value):
		self.key = key
		self.value = value
		self.left = None
		self.right = None

def insertNode(root, ordinance):
	currentNode = root

	if (ordinance < root.value):
		if (currentNode.left != None):
			currentNode = currentNode.left
		else:
			currentNode.left = Node(ordinance, 1)
	elif (ordinance > root. value):
		if (currentNode.right != None):
			currentNode = currentNode.right
		else:
			currentNode.right = Node(ordinance, 1)
	# key = vvalue
	else:
		currentNode.value += 1


def frequencySort(s):
	root = Node(ord(s[0]), 1)
	for i in range (1, len(s)):
		ordinance = ord(s[i])
		insertNode(root, ordinance)


s = "example"
frequencySort(s)