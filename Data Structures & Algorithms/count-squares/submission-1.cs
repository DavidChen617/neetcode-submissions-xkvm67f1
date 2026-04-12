public class CountSquares {
    private readonly Dictionary<(int X, int Y), int> _ptCount = new ();
    private readonly List<(int X, int Y)> _pts = new ();

    public CountSquares() {
        
    }
    
    public void Add(int[] point) {
        var touplePoint = (point[0], point[1]);
         _ptCount.TryAdd(touplePoint, 0);
        
        _ptCount[touplePoint]++;
        _pts.Add(touplePoint);
    }
    
    public int Count(int[] point)
    {
        int res = 0;
        int px = point[0],
            py = point[1];

        for (int i = 0; i < _pts.Count; i++)
        {
            var pt = _pts[i];
            if(Math.Abs(py - pt.Y) != Math.Abs(px - pt.X) || pt.X == px || py == pt.Y)
                continue;
            
            res += _ptCount.GetValueOrDefault((pt.X, py)) *
                   _ptCount.GetValueOrDefault((px, pt.Y));
        }
        
        return res;
    }
}
