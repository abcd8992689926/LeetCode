/*
 * @lc app=leetcode id=355 lang=csharp
 *
 * [355] Design Twitter
 */

// @lc code=start
public class Twitter {
    private Dictionary<int,List<int>> follow;
    private Dictionary<int,List<newsModel>> news;
    private class newsModel{
        public int tweetId {get; set;}
        public DateTime dateTime {get; set;}
    }
    public Twitter() {
        follow=new Dictionary<int, List<int>>();
        news=new Dictionary<int, List<newsModel>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        var newsModel=new newsModel{
            tweetId=tweetId,
            dateTime=DateTime.Now
        };
        if(news.ContainsKey(userId)){
            news[userId].Add(newsModel);
        }else{
            news.Add(userId, new List<newsModel>{newsModel});
        }
    }
    
    public IList<int> GetNewsFeed(int userId) {
        var follows = follow.TryGetValue(userId, out List<int> listFollows)?listFollows:new List<int>();
        if(!follows.Contains(userId)){
            follows.Add(userId);
        }
        var rs=new List<newsModel>();
        for(var x=0; x<follows.Count;++x){
            var listNews=GetOwnerNews(follows[x]);
            rs.AddRange(listNews);
        }
        return rs.OrderByDescending(x=>x.dateTime)
                 .Select(x=>x.tweetId)
                 .Take(10)
                 .ToList();
    }

    private List<newsModel> GetOwnerNews(int userId){
        return news.TryGetValue(userId, out List<newsModel> listNews)?listNews:new List<newsModel>();
    }
    
    public void Follow(int followerId, int followeeId) {
        if(follow.ContainsKey(followerId)){
            if(!follow[followerId].Contains(followeeId)){
                follow[followerId].Add(followeeId);
            } 
        }else{
            follow.Add(followerId, new List<int>{followeeId});
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(follow.ContainsKey(followerId)){
            follow[followerId].Remove(followeeId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */
// @lc code=end

