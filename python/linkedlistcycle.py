# If a linked list repeats itself will return the starting value - if not will return none
class ListNode:
	def __init__(self, x):
		self.val = x
		self.next = None

def setup():

	nodeOne = ListNode(1)
	nodeTwo = ListNode(2)
	nodeThree = ListNode(2)
	nodeFour = ListNode(2)

	nodeOne.next = nodeTwo
	nodeTwo.next = nodeThree
	nodeThree.next = nodeFour
	return nodeOne


def doesLoop(node):
	dictionary = dict()
	currentItem = node

	while (currentItem.next != None):
		if currentItem in dictionary:
			return currentItem.val
		dictionary[currentItem] = 1
		currentItem = currentItem.next

	if currentItem in dictionary:
		return currentItem.val
	return "None"

def deleteDuplicates(node):
	dictionary = dict()
	currentItem = node
	previous = None

	while (currentItem.next != None):
		if currentItem.val in dictionary:
			previous.next = currentItem.next
			print "Duplicate"
		dictionary[currentItem.val] = 1
		previous = currentItem
		currentItem = currentItem.next

	if currentItem.val in dictionary:
		previous.next = currentItem.next
		print "Duplicate"
	dictionary[currentItem.val] = 1
	previous = currentItem


nodeOne = setup()
print(deleteDuplicates(nodeOne))