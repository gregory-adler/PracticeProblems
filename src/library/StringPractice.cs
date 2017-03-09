namespace Library {
    using System;
    using System.Collections.Generic;
    public class StringPractice{
        public bool uniqueCharacter(string s){
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i =0; i< s.Length; i++){
               if (dictionary.ContainsKey(s[i])){
                   return false;
               }
               dictionary.Add(s[i], 1);
            }
            return true;
        }
        public bool uniqueCharacterNoData(string s){
            char[] foo = s.ToCharArray();
            Array.Sort(foo);
            for (int i = 0; i< foo.Length-1; i++){
                if (foo[i] == foo[i+1]){
                    return false;
                }
            }
            return true;
        }
        public string reverseString(string s){
            string answer ="";

            for (int i=s.Length-1; i>= 0; i--){
                answer = answer + s[i];
            }
            return answer;
        }
        public bool permutation (string s, string t){
            if (s.Length != t.Length){
                return false;
            }
            char[] a = s.ToCharArray();
            char[] b = t.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);
            
            s = String.Join("", a);
            t = String.Join("", b);
            if (s.Equals(t)){
                return true;
            }

            return false;
        }
        public bool permutationbyCount(string s, string t){
            if (s.Length != t.Length){
                return false;
            }
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i=0; i<s.Length; i++ ){
                if (dictionary.ContainsKey(s[i])){
                    dictionary[s[i]]+=1;
                }
                else{
                    dictionary[s[i]] =1;
                }
            }
            for (int i=0; i<t.Length; i++){
                if (dictionary.ContainsKey(t[i])){
                    dictionary[t[i]]-=1;
                }
                else {
                    return false;
                }
            }
            foreach(KeyValuePair<char, int> entry in dictionary){
                if (entry.Value!=0){
                    return false;
                }
            }
            return true;
        }
    }
}