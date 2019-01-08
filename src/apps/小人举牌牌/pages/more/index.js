var n = [ "dataset", "appid", "log", "navigateToMiniProgram", "release", "navigateBack", "globalData", "backgroundColor", "setNavigationBarColor", "#ffffff", "#000000", "setData", "wxbc2b171d389d0afa", "刘海壁纸", "超萌手机刘海壁纸制作生成器", "pages/index/index", "currentTarget" ];

!function(n, o) {
    !function(o) {
        for (;--o; ) n.push(n.shift());
    }(++o);
}(n, 114);

var o = function(o, a) {
    return n[o -= 0];
};

Page({
    data: {
        linkList: [ {
            appid: o("0x0"),
            title: o("0x1"),
            desc: o("0x2"),
            image: "../../image/wallpaper.jpeg",
            linkurl: o("0x3")
        } ]
    },
    onLoad: function(n) {},
    linkTap: function(n) {
        var a = n[o("0x4")][o("0x5")][o("0x6")], e = n[o("0x4")][o("0x5")].url;
        console[o("0x7")](e), wx[o("0x8")]({
            appId: "" + a,
            path: "" + e,
            envVersion: o("0x9"),
            success: function(n) {
                console[o("0x7")]("ok");
            },
            fail: function(n) {
                console[o("0x7")](n);
            }
        });
    },
    backHomeTap: function(n) {
        wx[o("0xa")]({
            changed: !0
        });
    },
    onReady: function() {},
    onShow: function() {
        var n = getApp()[o("0xb")][o("0xc")];
        wx[o("0xd")]({
            frontColor: o("#ffffff" != n ? "0xe" : "0xf"),
            backgroundColor: n
        }), this[o("0x10")]({
            styleColor: n
        });
    },
    onHide: function() {},
    onUnload: function() {},
    onPullDownRefresh: function() {},
    onReachBottom: function() {},
    onShareAppMessage: function() {}
});