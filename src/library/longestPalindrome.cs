namespace Library {

    public abstract class PalindromeNumber {

        public virtual string testMethod() {
            return "wowwwwwwww";
        }
        
    }
    public class NewClass : PalindromeNumber{
         /*public override string testMethod(){
            return "notwow";
        }*/

        public int whatIsSixtyNine { get; set; }
        public string model { get; set; } = "Honda";
        
        public NewClass() {
            this.whatIsSixtyNine = 68;
            //model = "HOnda";
        }
    }

public class thisIsGettingWeird {
    public NewClass instanceOfNewClass { get; set; }

    public thisIsGettingWeird() {
        myService service = new myService();
        instanceOfNewClass = service.makeClass();
        //instanceOfNewClass.whatIsSixtyNine = 69;
    }
}
    public interface ImyService {
        string wowMethod();

        int gimmeSixtyNine();

        NewClass makeClass();
    }

    public class myService : ImyService {
        public string wowMethod(){
            return "method1";
        }
        public int gimmeSixtyNine(){
            return 69;
        }
        public NewClass makeClass(){
            return new NewClass();
        }
    }

    
}