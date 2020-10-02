public class Solution {
    public IList<string> FizzBuzz(int n) {
        if (n <= 0) {
            return new List<string>();
        }
        return GetFizzBuzzStrings(n);
    }
    
    private IList<string> GetFizzBuzzStrings(int n){
        IList<string> fizzBuzzStrings = new List<string>();
        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                fizzBuzzStrings.Add("FizzBuzz");
                continue;
            } 
            if (i % 3 == 0) {
                fizzBuzzStrings.Add("Fizz");
                continue;
            }
            if (i % 5 == 0) {
                fizzBuzzStrings.Add("Buzz");
                continue;
            }
            fizzBuzzStrings.Add(i.ToString());
        }
        return fizzBuzzStrings;
    }
}