public class Twitter {

    private int _count = 0;
    private readonly Dictionary<int, List<(int CreatedAt, int TweetId)>> _twitterMap = new();
    private readonly Dictionary<int, HashSet<int>> _followeeMap = new();

    public void PostTweet(int userId, int tweetId)
    {
        if (!_twitterMap.TryGetValue(userId, out var list))
        {
            list = new List<(int CreatedAt, int TweetId)>();
            _twitterMap.Add(userId, list);
        }

        list.Add((++_count, tweetId));
    }

    public List<int> GetNewsFeed(int userId)
    {
        var result = new List<(int CreatedAt, int TweetId)>();

        if (_followeeMap.TryGetValue(userId, out var followees))
            foreach (var id in followees)
                if (_twitterMap.TryGetValue(id, out var list))
                    result.AddRange(list);

        if (_twitterMap.TryGetValue(userId, out var tweet))
            result.AddRange(_twitterMap[userId]);


        return result
            .OrderByDescending(x => x.CreatedAt)
            .Take(10)
            .Select(x => x.TweetId)
            .ToList();
    }

    public void Follow(int followerId, int followeeId)
    {
        if(followerId == followeeId)
            return;
        
        if (!_followeeMap.TryGetValue(followerId, out var list))
        {
            list = new HashSet<int>();
            _followeeMap.Add(followerId, list);
        }

        list.Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (_followeeMap.TryGetValue(followerId, out var set))
        {
            set.Remove(followeeId);
        }
    }
}
