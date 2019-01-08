"use strict"
var baseAddress = "https://mp.windsoft.cn";

function userLogin(appId, authCode, success) {
  wx.request({
    url: '',
    data: {
      appId: appId,
      code: authCode
    },
    success(resp) {
      callback(resp);
    }
  })
}