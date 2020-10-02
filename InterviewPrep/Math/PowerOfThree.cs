public class Solution {
    public bool IsPowerOfThree(int n) {
        if(n < 3 && n != 1) return false;
        return (3*3*3*3*3*3*3*3*3*3*3*3*3*3*3*3*3*3*3) % n == 0;
    }
}