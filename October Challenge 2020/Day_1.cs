/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
 // PROBLEM NAME: RECENT COUNTER

public class RecentCounter {
    private int[] _pings;
    private KeyValuePair<int, int> _lastPing;
    private int _currIndex;
    
    public RecentCounter() {
       _pings = new int[10000];
       _currIndex = -1;
    }
    
    public int Ping(int t) {
        if (_currIndex == -1) {
            _lastPing = new KeyValuePair<int, int>(0, t);
            _pings[0] = t;
            _currIndex = 1;
            return 1; 
        }
        
         _pings[_currIndex] = t;
        
        if (t - _lastPing.Value > 3000) {
            for (int i = _lastPing.Key + 1; i <= _currIndex; i++) {
                if (t - _pings[i] <= 3000) {
                    _lastPing = new KeyValuePair<int, int>(i, _pings[i]);
                    break;
                }
            }
        }
        
       
        _currIndex += 1;
        return _currIndex - _lastPing.Key;
    }
}