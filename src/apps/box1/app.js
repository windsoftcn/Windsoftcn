//app.js
App({
  onLaunch: function() {
    // 展示本地存储能力
    var logs = wx.getStorageSync('logs') || []
    logs.unshift(Date.now())
    wx.setStorageSync('logs', logs)

    // 登录
    wx.login({
      success: res => {
        // 发送 res.code 到后台换取 openId, sessionKey, unionId
      }
    })
    // 获取用户信息
    wx.getSetting({
      success: res => {
        if (res.authSetting['scope.userInfo']) {
          // 已经授权，可以直接调用 getUserInfo 获取头像昵称，不会弹框
          wx.getUserInfo({
            success: res => {
              // 可以将 res 发送给后台解码出 unionId
              this.globalData.userInfo = res.userInfo

              // 由于 getUserInfo 是网络请求，可能会在 Page.onLoad 之后才返回
              // 所以此处加入 callback 以防止这种情况
              if (this.userInfoReadyCallback) {
                this.userInfoReadyCallback(res)
              }
            }
          })
        }
      }
    })
    wx.getSystemInfo({
      success: res => {
        this.globalData.systemInfo = res
        console.log(this.globalData.systemInfo)
      }
    })
  },

  globalData: {
    userInfo: null,
    systemInfo: null,
    appList: [{
      "appId": "wxb935bc1925fb7b47",
        "appIcon": "https://files.windsoft.cn/boxes/icon_funnybox.png",
        "appBanner": "",
        "appName": "小伶玩趣盒",
        "aliasName": "小伶玩趣盒",
        "playedNumber": "32万人在玩",
        "path": ""
      },
      {
        "appId": "wxd7273fe471076d97",
        "appIcon": "https://files.windsoft.cn/christmas/icon_christmas.jpg",
        "appBanner": "",
        "appName": "送不出的圣诞礼物",
        "aliasName": "送不出的礼物",
        "playedNumber": "1万人在玩",
        "path": ""
      },
      {
        "appId": "wx9ffa84a729e985f4",
        "appIcon": "https://files.windsoft.cn/ceyice/heavyfog/icon.png",
        "appBanner": "",
        "appName": "测一测真实的自己",
        "aliasName": "测真实的自己",
        "playedNumber": "19万人在玩",
        "path": ""
      },
      {
        "appId": "wx8a5f4bd354abc0cb",
        "appIcon": "https://files.windsoft.cn/christmas/icon_star.png",
        "appBanner": "",
        "appName": "星星乐消除",
        "aliasName": "星星乐消除",
        "playedNumber": "24万人在玩",
        "path": ""
      },
      {
        "appId": "wx341ae795fca23c0a",
        "appIcon": "https://files.windsoft.cn/boxes/icon_baby_animal.png",
        "appBanner": "",
        "appName": "宝贝识动物",
        "aliasName": "宝贝识动物",
        "playedNumber": "5万人在玩",
        "path": ""
      },
      {
        "appId": "wx8c286e1ec93c855c",
        "appIcon": "https://files.windsoft.cn/boxes/icon_baby_cars.png",
        "appBanner": "",
        "appName": "宝贝识汽车",
        "aliasName": "宝贝识汽车",
        "playedNumber": "32万人在玩",
        "path": ""
      },
      {
        "appId": "wx29293da60bb18815",
        "appIcon": "https://files.windsoft.cn/boxes/icon_baby_chinese.png",
        "appBanner": "",
        "appName": "宝贝学汉语",
        "aliasName": "宝贝学汉语",
        "playedNumber": "3万人在玩",
        "path": ""
      },
      {
        "appId": "wx2f9bcbed34f8a12e",
        "appIcon": "https://files.windsoft.cn/boxes/icon_baby_fruit.png",
        "appBanner": "",
        "appName": "宝贝识果蔬",
        "aliasName": "宝贝识果蔬",
        "playedNumber": "1万人在玩",
        "path": ""
      },
      {
        "appId": "wxd34ed6a0e76f9486",
        "appIcon": "https://files.windsoft.cn/boxes/icon_baby_career.png",
        "appBanner": "",
        "appName": "宝贝识职业",
        "aliasName": "宝贝识职业",
        "playedNumber": "7万人在玩",
        "path": ""
      },
      {
        "appId": "wx4588a99cc0a9ec73",
        "appIcon": "https://files.windsoft.cn/boxes/icon_baby_daily.png",
        "appBanner": "",
        "appName": "宝贝识日用品",
        "aliasName": "宝贝识日用品",
        "playedNumber": "14万人在玩",
        "path": ""
      }
    ]
  }
})