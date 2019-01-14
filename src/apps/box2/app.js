const ald = require('./utils/ald-stat.js')
//app.js
App({
  onLaunch: function(options) {
    // 展示本地存储能力
    var logs = wx.getStorageSync('logs') || []
    logs.unshift(Date.now())
    wx.setStorageSync('logs', logs) 
  },
  globalData: {
    userInfo: null,     
  }
})