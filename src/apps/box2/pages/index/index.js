//index.js
//获取应用实例
const app = getApp()

const myUrls = {
  app_list: "https://mp.windsoft.cn/api/wxBox/settings",
  appDefaultUrl: "pages/index/index"
}

Page({
  data: {
    userInfo: {},
    bannerApps: {},
    bestApps: {},
    otherApps: {}
  },

  onLoad: function() {
    let that = this
    wx.request({
      url: myUrls.app_list,
      data: {
        boxId: 1
      },
      success(res) {

        that.setData({
          bannerApps: res.data.bannerApps,
          bestApps: res.data.bestApps,
          otherApps: res.data.otherApps,
        })
        console.log(res.data)
      }
    })
  },
  onShareAppMessage: function() {
    return {
      title: "今天是最美好的一天",
      path: "/pages/index/index",
      imageUrl: ''       
    };
  },
  bindTapClick: function(target) {
    let that = this;
    let index = target.currentTarget.dataset.index;
    console.log(index);
    console.log(this.data.bannerApps[index].appId);
    console.log(myUrls.appDefaultUrl);
    wx.navigateToMiniProgram({
      appId: that.data.bannerApps[index].appId,
      path: myUrls.appDefaultUrl,
      success: function(result) {
        console.log('成功跳转');
      },
      fail: function(result) {
        if (that.bannerApps[index].shareUrl) {
          wx.previewImage({
            urls: [that.bannerApps[index].shareUrl]
          });
        }
      }
    })
  }
})