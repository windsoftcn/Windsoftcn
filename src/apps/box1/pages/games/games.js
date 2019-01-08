// pages/games/games.js

const app = getApp()

Page({
  /**
   * 页面的初始数据
   */
  data: {
    appList: null
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    appList = app.globalData.appList
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {
    this.loadAppList()
  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  },
  // 加载产品信息
  loadAppList: function () {
    var appCount = appList.length
    if (appCount && appCount > 0) {
      Math.floor(Math.random() * (max - min)) + min
    }
  },

})