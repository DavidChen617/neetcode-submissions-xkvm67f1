public class Twitter {

   private readonly Dictionary<int, List<int>> _followedTable = new();
    private readonly Dictionary<int, List<(int createdAt, int id)>>  _tweetTable = new();
    private int _time = 0;
    public Twitter() {
        
    }

    private void InitUser(int userId)
    {
        if (!_followedTable.ContainsKey(userId))
            _followedTable[userId] = new List<int>();

        if (!_tweetTable.ContainsKey(userId))
            _tweetTable[userId] = new List<(int createdAt, int id)>();
    }

    public void PostTweet(int userId, int tweetId) {
        InitUser(userId);
        _tweetTable[userId].Add((++_time, tweetId));
    }
    
    public List<int> GetNewsFeed(int userId)
    {
        InitUser(userId);
        var result = new List<(int createdAt, int id)>();
        result.AddRange(_tweetTable[userId]);
        foreach (var follow in _followedTable[userId])
        {
            if (_tweetTable.TryGetValue(follow, out var tweet))
            {
                result.AddRange(tweet);
            }
        }
        
        return result.OrderByDescending(x => x.createdAt)
            .Select(x => x.id)
            .Take(10)
            .ToList();
        
    }
    
    public void Follow(int followerId, int followeeId) {
         InitUser(followerId);
            InitUser(followeeId);

            if (followeeId == followerId)
                return;
            
            if(!_followedTable[followerId].Contains(followeeId))
                _followedTable[followerId].Add(followeeId);

    }
    
    public void Unfollow(int followerId, int followeeId)
    {
        if (!_followedTable.ContainsKey(followerId) || followeeId == followerId)
            return;
        _followedTable[followerId].Remove(followeeId);
    }
}
