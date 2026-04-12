public class TimeMap {
    private readonly Dictionary<string, List<Pair>> _map = new Dictionary<string, List<Pair>>();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!_map.ContainsKey(key))
            _map.Add(key, new List<Pair>());

        _map[key].Add(new Pair(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        var res = string.Empty;
        if(!_map.TryGetValue(key, out var value))
            return res;
        
        int l = 0, r = value.Count-1;
       
        while(l <= r){
            int m = l + (r - l) / 2;
            if(value[m].Timestamp <= timestamp){
                res = value[m].Value;
                l = m + 1;
            }else
                r = m - 1;
        }

        return res;
    }

    private class Pair{
        public string Value {get; set;}
        public int Timestamp {get; set;}

        public Pair(string value, int timestamp){
            Value = value;
            Timestamp = timestamp;
        }
    }
}
