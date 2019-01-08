using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MP.Services.WeChatAuth
{
    public class WeChatAuthHttpClient
    {
        private const string BaseUrl = "https://api.weixin.qq.com/sns/jscode2session";
        private readonly HttpClient httpClient;

        public WeChatAuthHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

         
        public async Task<string> GetOpenIdAsync(string appId, string secret,  string code, string grantType = "authorization_code")
        {
            string url = $"{BaseUrl}?appid={appId}&secret={secret}&js_code={code}&grant_type={grantType}";
            return await httpClient.GetStringAsync(url);
        }
    }
}
