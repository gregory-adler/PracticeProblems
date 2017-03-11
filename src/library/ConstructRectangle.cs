namespace Library {
    public class ConstructRectangle{
        public int[] constructRectangle(int area){
            int difference = area;
            int[] answer = new int[2];
            int quotient;
            int l;
            int w;
            for (int i =1; i<= area; i++){
                if (area % i == 0){
                    quotient = area/i;
                    if (i >= quotient){
                        l = i;
                        w = quotient;
                    }
                    else {
                        l = quotient;
                        w = i;
                    }
                    if ((l-w) < difference){
                        answer[0] = l;
                        answer[1] = w;
                        difference = l-w;
                    }
                }
            }
            return answer;
        }

    }
}