class LRUCache(object):
	class Node:
		def __init__(self, key, value):
			self.key = key
			self.value = value
			self.prev = None
			self.next = None

	def addNode(self, node):
		node.prev = self.head
		node.next = self.head.next
		self.head.next.prev = node
		self.head.next = node

	def deleteNode(self, node):
		previous = self.Node(None, None)
		previous = node.prev;

		nextNode = self.Node(None,None)
		nextNode = node.next

		previous.next = nextNode
		nextNode.previous = previous

	def headNode(self, node):
		self.deleteNode(node)
		self.addNode(node)

	def popTail(self):
		node = self.tail.prev
		self.deleteNode(node)
		return node

	def __init__(self, capacity):
		self.capacity = capacity
		self.count = 0

		self.head = self.Node(None, None)
		self.head.prev = None;
		self.tail = self.Node(None, None)
		self.tail.next = None

		self.head.next = self.tail
		self.tail.prev = self.head

		self.hashmap = dict()


        

	def get(self, key):
		print "getting key"
		if (key in self.hashmap.keys()):
			print "key exists"
			temp = self.hashmap[key]
			self.headNode(temp)
			return temp.value
		else:
			print "key doesn't exist"
			return -1

	def put(self, key, value):
		"""
		:type key: int
		:type value: int
		:rtype: void
		"""

		if (key in self.hashmap.keys()):
			print "key already exists"
			self.hashmap[key].value = value
			self.headNode(self.hashmap[key])
		else:
			print "adding key"
			Node = self.Node(key, value);
			self.hashmap[key] = Node
			self.addNode(Node)
			self.count +=1
			if self.count > self.capacity:
				print "capacity reached, deleting tail"
				node = self.popTail()
				del(self.hashmap[node.key])
				self.count -=1
        

capacity = 4
obj = LRUCache(capacity)
obj.put(4,3)
obj.put(5,3)
obj.put(2,3)
obj.put(1,3)
obj.put(6,3)
#obj.put(7,3)
# param_1 = obj.get(4)