var o = [ "backgroundColor", "setNavigationBarColor", "#ffffff", "#000000" ];

!function(o, r) {
    !function(r) {
        for (;--r; ) o.push(o.shift());
    }(++r);
}(o, 368);

var r = function(r, n) {
    return o[r -= 0];
};

Page({
    onShow: function() {
        var o = getApp().globalData[r("0x0")];
        wx[r("0x1")]({
            frontColor: r(r("0x2") != o ? "0x2" : "0x3"),
            backgroundColor: o
        });
    }
});