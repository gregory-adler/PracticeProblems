class Node:
	def __init__(self, key, value):
		self.key = key
		self.value = value
		self.left = None
		self.right = None

def insertNode(currentNode, ordinance):

	if (chr(ordinance) == 'n'):
		print "true"
	if (ordinance < currentNode.key):
		if (currentNode.left != None):
			print "going left"
			insertNode(currentNode.left, ordinance)
		else:
			print "adding left"
			currentNode.left = Node(ordinance, 1)
	elif (ordinance > currentNode. key):
		if (currentNode.right != None):
			print "goign right"
			insertNode(currentNode.right, ordinance)
		else:
			print "adding right"
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
	if (currentNode.right != None):
		iterateTree(currentNode.right)


	print "key: " + chr(currentNode.key)
	print "value: " + str(currentNode.value)


def createHeapFromTree(currentNode, heap):
	if (currentNode.left != None):
		createHeapFromTree(currentNode.left, heap)
	if (currentNode.right != None):
		createHeapFromTree(currentNode.right, heap)


	heap.add(currentNode)

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

	def __init__(self, capacity):
		self.array = [0] * capacity
		self.count = 0

	def add(self, item):
		if (self.count > len(self.array)):
			return
		elif (self.count == len(self.array)):
			doubleHeapSize()

		self.array[self.count] = item
		self.arrangeHeap(self.count)
		self.count+=1


	def doubleHeapSize(self):
		newHeap = [0] * len(self.array)*2
		for i in range (0, self.array.count):
			newHeap[i] = self.array[i]

		self.array = newHeap

	def arrangeHeap(self, i):
		while (i >0):
			parentIndex = (i-1) / 2
			if (self.array[i].value > self.array[parentIndex].value):
				self.swap(i, parentIndex)
				i = parentIndex
			else:
				break

	def swap(self, original, new):
		temp = self.array[new]
		self.array[new] = self.array[original]
		self.array[original] = temp

	def removeMax(self):
		toReturn = self.array[0]
		self.array[0] = self.array[self.count]
		self.count-=1
		if (self.count >0):
			sinkFirstElement(self)
		return toReturn

	def sinkFirstElement(self):
		i = 0
		while((2*i) +1 <count):
			j = 2 * i + 1
			if (j+1 < self.count and self.array[j+1].value > self.array[j].value):
				j+=1
			if (self.array[i].value >= self.array[j].value):
				break

			swap(i, j)
			i = j

def frequencySort(s):
	root = Node(ord(s[0]), 1)
	for i in range (1, len(s)):
		ordinance = ord(s[i])
		insertNode(root, ordinance)

	iterateTree(root)

	#print "\n"	
	#print "first tree"
	#iterateTree(root)
	#print "\n"

	heap = Heap(25)
	createHeapFromTree(root, heap)

	string = ""
	for i in range (0, len(heap.array)):
		if (heap.array[i]!= 0):
			print chr(heap.array[i].key)
			print heap.array[i].value
			for j in range (0, heap.array[i].value):
				print chr(heap.array[i].key)
				string += chr(heap.array[i].key)

	print string

	# secondTreeRoot = Node(root.value, root.key)
	# createSecondTree(root, secondTreeRoot)

	# answer = iterateTreeforAnswer(secondTreeRoot, "")
	# print answer

s = "raaeaedere"
frequencySort(s)