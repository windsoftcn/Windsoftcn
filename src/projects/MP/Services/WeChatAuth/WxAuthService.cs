using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Services.WeChatAuth
{

    //namespace TaoLu.Services
    //{
    //    public class UserService
    //    {

    //        private const string AppId = "wxac983872284eab41";
    //        private const string Secret = "2d8002717d3a2bde25b5fea649a1a678";
    //        private const string GrantType = "authorization_code";

    //        private readonly IConnectionMultiplexer _connectionMultiplexer;

    //        private HttpClient httpClient;

    //        public UserService(IConnectionMultiplexer connectionMultiplexer)
    //        {
    //            _connectionMultiplexer = connectionMultiplexer ?? throw new ArgumentNullException(nameof(connectionMultiplexer));
    //            httpClient = new HttpClient();
    //        }

    //        public string OpenIdLog(string code)
    //        {
    //            string url = $"https://api.weixin.qq.com/sns/jscode2session?appid={AppId}&secret={Secret}&js_code={code}&grant_type={GrantType}";

    //            HttpResponseMessage httpResponse = httpClient.GetAsync(url).GetAwaiter().GetResult();
    //            if (httpResponse.IsSuccessStatusCode)
    //            {
    //                return httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    //            }
    //            return string.Empty;
    //        }

    //        public string GetOpenId(string code)
    //        {
    //            string url = $"https://api.weixin.qq.com/sns/jscode2session?appid={AppId}&secret={Secret}&js_code={code}&grant_type={GrantType}";

    //            HttpResponseMessage httpResponse = httpClient.GetAsync(url).GetAwaiter().GetResult();
    //            if (httpResponse.IsSuccessStatusCode)
    //            {
    //                JObject jObject = JObject.Parse(httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult());

    //                return jObject.Value<string>("openid");
    //            }
    //            return string.Empty;
    //        }

    //        private IDatabase database;
    //        private IDatabase Database
    //        {
    //            get
    //            {
    //                if (database == null)
    //                {
    //                    database = _connectionMultiplexer.GetDatabase(0);
    //                }
    //                return database;
    //            }
    //        }

    //        public bool UpdateUserData(User user)
    //        {
    //            Database.HashSet(RedisKeys.Users, user.UserId, JsonConvert.SerializeObject(user));
    //            return true;
    //        }

    //        public User GetUser(string userId)
    //        {
    //            string value = Database.HashGet(RedisKeys.Users, userId, CommandFlags.None);
    //            if (!String.IsNullOrEmpty(value))
    //            {
    //                return JsonConvert.DeserializeObject<User>(value);
    //            }
    //            return null;
    //        }


    //        public bool UpdateUserPlayData(UserScore userScore)
    //        {
    //            userScore.IsNewUser = false;
    //            Database.HashSet(RedisKeys.UserScore, userScore.UserId, JsonConvert.SerializeObject(userScore));
    //            return true;
    //        }

    //        public bool UpdateUserLevel(string userId, int level, int gold, int tools)
    //        {
    //            var userScore = new UserScore
    //            {
    //                UserId = userId,
    //                Level = level,
    //                Gold = gold,
    //                Tools = tools
    //            };
    //            return UpdateUserPlayData(userScore);
    //        }

    //        public UserScore GetUserScore(string userId)
    //        {
    //            var isExists = Database.HashExists(RedisKeys.UserScore, userId);
    //            if (isExists)
    //            {
    //                var level = database.HashGet(RedisKeys.UserScore, userId);
    //                return JsonConvert.DeserializeObject<UserScore>(level, new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Ignore });
    //            }
    //            return null;
    //        }

    //        public bool UpdateUserRank(string userId, double score)
    //        {
    //            double? lastScore = Database.SortedSetScore(RedisKeys.UserRank, userId, CommandFlags.None);

    //            if (!lastScore.HasValue || score > lastScore)
    //            {
    //                return Database.SortedSetAdd(RedisKeys.UserRank, userId, score, CommandFlags.None);
    //            }
    //            return true;
    //        }

    //        public async Task<List<UserRank>> GetTopAsync(int numbers)
    //        {
    //            IEnumerable<SortedSetEntry> entries = await Database.SortedSetRangeByScoreWithScoresAsync(key: RedisKeys.UserRank, order: Order.Descending, take: numbers);

    //            List<UserRank> userScoreList = new List<UserRank>();
    //            UserRank tempUserRank;
    //            User tempUser;
    //            int index = 1;
    //            foreach (var entry in entries)
    //            {
    //                tempUser = GetUser(entry.Element);
    //                if (!String.IsNullOrEmpty(tempUser?.UserId))
    //                {
    //                    tempUserRank = new UserRank
    //                    {
    //                        Id = index,
    //                        User = tempUser,
    //                        Score = entry.Score
    //                    };
    //                    userScoreList.Add(tempUserRank);
    //                    index++;
    //                }
    //            }
    //            return userScoreList;
    //        }
    //    }
    //}
}
