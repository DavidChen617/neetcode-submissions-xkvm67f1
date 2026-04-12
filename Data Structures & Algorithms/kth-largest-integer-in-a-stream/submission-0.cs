public class KthLargest {
    private List<int> arr;
    private int k = 0;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        arr = new List<int>(nums);
    }
    
    public int Add(int val) {
        arr.Add(val);
        arr.Sort();
        return arr[arr.Count - k];
    }
}
