var stats = require('/utils/stats.js')
App({
  onLaunch: function(options) {
    console.log(options)
    wx.login({
      success(res) {
        if (res.code) {

          // wx.request({
          //   url: 'https://mp.windsoft.cn/api/wechatauth/mplogin',
          //   method: 'GET',
          //   data: {
          //     code: res.code
          //   },
          //   success(resp){
          //     console.log(resp.data)
          //   }
          // })
          console.log(res.code)
        } else {
          console.log('登陆失败: ' + res.errMsg);
        }
      }
    })
  },
  globalData: {
    backgroundColor: "#87CEFA",
    appId: "wxf8a4a9929d345c6b",
    openId: null
  }
});