import java.util.List;
import java.util.ArrayList;
import java.io.Console;
// NOTE: No other Java libraries allowed (automatic 0)


// if you want to know if root is smalelr, equal, or greater than the key 
// you do 
// root.kv.key.compareTo(key) 
// returns -1 if root key is less than given key, 0 if theyre equal, 1 if root key is greater than given key


// EMD<K, V> 
// EMD<String, String> 

// class EMD<K extends Comparable<, V> 

// List<Item>
// Item value = asdf


// List<String>

/* class EMD<K extends Comparable<K>, V> {
  K key;
  V value;  
}
*/



/* class stringEMD {
    public String key;
    public String value;
}

class KVPair<K, V> {
    K key;
    V value;
}

*/
class EMD<K extends Comparable<K>, V> implements RangeMap<K,V> {
    class Node {
        Node left;
        Node right;
        KVPair<K,V> kv; // property K key, propety V value 
    }

    private Node root;

    // Add the key and a value to your RangeMap. (For EMD, this would be the
    // name of the movie (key) and its description (value), respectively.) If
    // there is a duplicate key, the old entry should be overwritten with the
    // new value.
    public void add(K key, V value) {
        // TODO: Implement me(basic score)
        if (root == null){
            Node toAdd = new Node();
            toAdd.kv = new KVPair<K, V>(key, value);
            root = toAdd;
        }

        int compare = root.kv.key.compareTo(key);
        if (compare < 0){
            if (root.right == null){
                Node toAdd = new Node();
                toAdd.kv = new KVPair<K, V>(key, value);
                root.right= toAdd;
            }
            else {
                addRecur(key, value, root.right);
            }

        }
        else if (compare > 0){
            if (root.left == null){
                Node toAdd = new Node();
                toAdd.kv = new KVPair<K, V>(key, value);
                root.left= toAdd;
            }
            addRecur(key, value, root.left);
        }
        else {
            Node toAdd = new Node();
            toAdd.kv = new KVPair<K, V>(key, value);
            root= toAdd;
        }

        
    }
    public void addRecur(K key, V value, Node node){
        int compare = node.kv.key.compareTo(key);
        if (compare <0){
            if (node.right == null){
                Node toAdd = new Node();
                toAdd.kv = new KVPair<K, V>(key, value);
                node.right= toAdd;
            }
            else {
                addRecur(key, value, node.right);
            }

        }
        else if (compare > 0){
            if (node.left == null){
                Node toAdd = new Node();
                toAdd.kv = new KVPair<K, V>(key, value);
                node.left= toAdd;
            }
            addRecur(key, value, node.left);

        }
        else {
            node.kv = new KVPair<K, V>(key, value);
        }


    }

    // Retrieve the value corresponding to key, or return null if the key is
    // not in your RangeMap. The comparison between keys should be exact.
    // (For EMD, this would correspond to the lower-case name of the movie
    // (key).)
    public V get(K key) {
        // TODO: Implement me(basic score)
        if (root == null){
        	return null;
        }
        int compare = root.kv.key.compareTo(key);
        if (compare < 0){
        	if (root.right == null){
        		return null;
        	}
        	else {
        		return getRecur(key, root.right);
        	}
        }
        else if (compare > 0){
        	if (root.left == null){
        		return null;
        	}
        	else {
        		return getRecur(key, root.left);
        	}
        }
        else {
        	return root.kv.value;
        }
    }

    public V getRecur(K key, Node node){
    	int compare = node.kv.key.compareTo(key);
    	if (compare < 0 ){
    		if (node.right == null){
    			return null;
    		}
    		else {
    			return getRecur(key, node.right);
    		}
    	}
    	else if (compare > 0){
    		if (node.left == null){
    			return null;
    		}
    		else {
    			return getRecur(key, node.left);
    		}
    	}
    	else {
    		return node.kv.value;
    	}
    	
    }

    // Return the key in the RangeMap that's lexicographically next after
    // 'key', or return null otherwise. (For EMD, this would correspond to
    // the name of the movie that's next after the one specified. 
    // If key is exactly the name of a movie, next should still return
    // the following movie in the database.)
    // Note that key does not have to exist in the database.
    public K next(K key) {
        // TODO: Implement me(EC for intermediate score)
        Node candidate = new Node();
        if (root == null){
        	return null;
        }
        int compare = root.kv.key.compareTo(key);
        // if Node is larger than key, set as potential answer and go left
        // checking to to see if there is a smaller node that is also larger than key, else the candidate is the answer
        if (compare > 0 ){
        	if (root.left == null){
        		return root.kv.key;
        	}
        	else {
        		candidate = root;
        		return nextRecur(key, root.left, candidate);
        	}
        }

        // if current node is less than key, go right to see if there is a node that is greater than key
        // if there is no right and there is no candidate return null
        else {
        	if (root.right == null){
        		return null;
        	}
        	else {
        		return nextRecur(key, root.right, candidate);
        	}
        }
    }

    public K nextRecur (K key, Node node, Node candidate){
    	int compare = node.kv.key.compareTo(key);

    	if (compare > 0){
    		candidate = node;
    		if (node.left ==null){
    			return candidate.kv.key;
    		}
    		else {
    			return nextRecur(key, node.left, candidate);

    		}
    	}
    	else {
    		if (node.right == null){
    			if (candidate != null){
    				return candidate.kv.key;
    			}
    			else {
    				return null;
    			}
    		}
    		else {
    			return nextRecur(key, node.right, candidate);
    		}
    	}
    }

    // Return a list of key-value pairs in the RangeMap that are between the
    // strings start and end, both inclusive. The list should be in
    // lexicographic order. If no keys match, the method should return the empty list.
    // (For EMD, range would return an alphabetic list of movies titles that
    // are between the two parameter strings). Note that neither start nor
    // end have to exist in the database.
    public List<KVPair<K,V>> range(K start, K end) {
        // TODO: Implement me(EC for full score)
        return null;
    }

    // Removes the key-value pair with key specified by the parameter from
    // the RangeMap. Does nothing if the key does not exist. 
    // Extra Credit beyond 100%
    public void remove(K key) {
        // TODO: Implement me(EC beyond full score)
    }

    /////////////////////////////////////////////////
    // You shouldn't have to change anything below //
    /////////////////////////////////////////////////
    public static void main(String[] args) {
        EMD<String, String> emd = new EMD<String, String>();
        In in;
        In inputFile = null;

        // read from a given input file instead?
        if(args.length > 0) {
            inputFile = new In(args[0]);
        }

        while(true) {
            if(inputFile != null ? !inputFile.hasNextLine() : !StdIn.hasNextLine()) {
                break;
            }
            String input =(inputFile != null ? inputFile.readLine() : StdIn.readLine());

            // process commands from the user
            String[] line = input.split("/");
            switch(line[0].charAt(0)) {
                // Open and read a file with "Movie/Information..." lines
                case 'o':                // e.g. "open/movies.txt"
                    in = new In(line[1]);
                    // clean out the old movies
                    emd = new EMD<String, String>();
                    while(in.hasNextLine()) {
                        String[] arr = in.readLine().split("/");
                        // Test only lower case strings for simplicity
                        emd.add(arr[0].toLowerCase(), arr[1]);
                    }
                    break;

                    // Add a new movie
                case 'a':                // e.g. "add/Shredder/Foot Clan Ninja"
                    System.out.println("Adding '" + line[1] + "' ...");
                    emd.add(line[1].toLowerCase(), line[2]);
                    break;

                    // Look up a movie
                case 'g':                // e.g. "get/shredder"
                    System.out.println("Looking up '" + line[1] + "' ...");
                    System.out.println(emd.get(line[1].toLowerCase()));
                    break;

                    // Find next movie after a string(like auto-complete)
                case 'n':                // e.g. "next/shred" would return "shredder"
                    System.out.println("Looking up next movie after '" + line[1] + "' ...");
                    System.out.println(emd.next(line[1].toLowerCase()));
                    break;

                    // Remove a movie
                case 'r':                // e.g. "remove/Shredder"
                    System.out.println("Removing '" + line[1] + "' ...");
                    emd.remove(line[1].toLowerCase());
                    break;

                    // Find movies in a range
                case 'f':                // e.g. "find/shed/shre/"
                    // might print "sherlock" and "shrek",
                    // but not "shredder" since it's outside
                    // the range
                    List<KVPair<String, String>> list;
                    System.out.println("Searching range of '" + line[1] + "'-'" + line[2] + "' ...");
                    list = emd.range(line[1].toLowerCase(), line[2].toLowerCase());
                    if(list == null)
                    {
                        System.out.println("Not found.\n");
                    } else {
                        // print out all movies in this range
                        for(KVPair<String, String>kv : list)
                            System.out.println(kv);
                    }
                    break;
                default:
                    System.out.println("Unknown command. ");
                    break;
            }
        }
    }
};
