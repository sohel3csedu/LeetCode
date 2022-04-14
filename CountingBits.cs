public static class CountingBits{

public static int[] CountBits(int n) {
        int[] result = new int[n+1];
        int offset = 1;
        for(int i = 1;i<=n;i++){
            if(i == offset*2){
                offset = i;
            }
            result[i] = 1 + result[i-offset];
        }
        return result;
    }

}