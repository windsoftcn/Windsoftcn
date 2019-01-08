var e = ["dataset", "type", "data", "setData", "draw", "value", "isShowCom", "selectSwitch", "navigateTo", "../help/index", "changeRandom", "people", "clearValue", "floor", "random", "changePeople", "index", "context", "split", "forEach", "length", "min", "concat", "fill", "max", "system", "windowWidth", "setStrokeStyle", "#000000", "setLineWidth", "sort", "save", "drawImage", ".png", "test", "translate", "setFontSize", "fillText", "restore", "contextTemp", "globalCompositeOperation", " source-over", "setFillStyle", "colorPicker", "color", "fillRect", "canvas", "tempFilePath", "canvasToTempFilePath", "canvasTemp", "png", "previewImage", "currentTarget", "map", "bgColor", "rgb(", "toString", "setNavigationBarColor", "#ffffff", "globalData", "backgroundColor", "key", "setBackground", "detail", "mode", "createCanvasContext", "getSystemInfoSync", "bottomSelect", "isSelect", "/pages/help/index", "haveBorder", "/pages/index/index", "../../data/list.js", "default", "#87CEFA", "../../image/text.png", "../../image/text_select.png", "../../image/style.png", "../../image/style_select.png", "../../image/help.png", "../../image/circle.png", "../../image/circle_select.png", "../../image/default.png", "upup", "../../image/upup.png", "love", "../../image/love.png", "haizei", "christmas", "../../image/christmas.png", "sports", "../../image/sports.png"];

! function(e, t) {
  ! function(t) {
    for (; --t;) e.push(e.shift());
  }(++t);
}(e, 164);

var t = function(t, a) {
    return e[t -= 0];
  },
  a = require(t("0x0")),
  x = [],
  i = 2;

Page({
  data: {
    value: "",
    random: "",
    type: t("0x1"),
    system: {},
    loading: !1,
    colorPicker: {
      index: 0,
      key: "",
      color: t("0x2"),
      r: 135,
      g: 206,
      b: 250
    },
    map: {
      bgColor: {
        r: 135,
        g: 206,
        b: 250
      }
    },
    people: {},
    item: {},
    bottomSelect: [{
      id: 0,
      image: t("0x3"),
      selectImage: t("0x4"),
      text: "标语",
      haveBorder: !0,
      isSelect: !1
    }, {
      id: 1,
      image: "../../image/color.png",
      selectImage: "../../image/color_select.png",
      text: "背景",
      haveBorder: !0,
      isSelect: !1
    }, {
      id: 2,
      image: t("0x5"),
      selectImage: t("0x6"),
      text: "风格",
      haveBorder: !0,
      isSelect: !0
    }, {
      id: 3,
      image: t("0x7"),
      selectImage: "../../image/help_select.png",
      text: "帮助",
      haveBorder: !0,
      isSelect: !1
    }],
    isShowCom: !0,
    showPj: 2,
    tplist_2: [{
      type: t("0x1"),
      image: t("0xa")
    }, {
      type: t("0xb"),
      image: t("0xc")
    }, {
      type: t("0xd"),
      image: t("0xe")
    }, {
      type: t("0xf"),
      image: "../../image/haizei.png"
    }, {
      type: t("0x10"),
      image: t("0x11")
    }, {
      type: t("0x12"),
      image: t("0x13")
    }],
    tplg1: 0,
    tplg2: 0,
    canvasWidth: 79,
    ifShow: !1,
    showHand: !0
  },
  changeType: function(e) {
    var a = e.currentTarget[t("0x14")][t("0x15")];
    a != this[t("0x16")][t("0x15")] && (this[t("0x17")]({
      type: a
    }), this[t("0x18")]());
  },
  bindInput: function(e) {
    var a = e.detail[t("0x19")];
    this[t("0x17")]({
      value: a
    }), this[t("0x18")]();
  },
  bindFocus: function() {
    this[t("0x16")][t("0x1a")] || this[t("0x1b")]();
  },
  bindHelp: function(e) {
    wx[t("0x1c")]({
      url: t("0x1d")
    });
  },
  clearValue: function() {
    this[t("0x17")]({
      value: "",
      output: ""
    }), this[t("0x1e")]();
  },
  changePeople: function() {
    var e = this[t("0x16")][t("0x15")];
    this.data[t("0x1f")][e] = null, this[t("0x18")]();
  },
  changeRandom: function() {
    "" !== this[t("0x16")].output && this[t("0x20")]();
    var e = Math[t("0x21")](Math[t("0x22")]() * a.length);
    this.data[t("0x22")] = a[e], this[t("0x23")](), this.setData({
      textIndex: e
    });
  },
  changeText: function(e) {
    this[t("0x20")]();
    var x = e.currentTarget.dataset[t("0x24")];
    this.data.random = a[x], this.changePeople(), this.setData({
      textIndex: x,
      output: a[x]
    });
  },
  draw: function() {
    var e = this[t("0x16")][t("0x19")] || this.data[t("0x22")],
      a = this[t("0x25")],
      x = this.data[t("0x15")],
      i = /^[\u4e00-\u9fa5]+$/,
      o = [],
      s = 0;
    e[t("0x26")]("\n")[t("0x27")](function(e) {
      var a = e[t("0x28")],
        x = 8 * Math.ceil(a / 8) - a;
      a > s && (s = Math[t("0x29")](a - 1, 7)), o = o[t("0x2a")](e[t("0x26")](""), new Array(x)[t("0x2b")](null));
    });
    var r = o[t("0x28")],
      n = Math[t("0x21")](r / 8);
    r % 8 == 0 && n--;
    var c, h, l, g, f, p, u, d, m, v, b, w;
    switch (x) {
      case t("0xb"):
        c = 24, h = 54, l = 90, g = 64, f = 20, p = 99, u = 190, d = 58, m = 25, v = 52,
          b = 29, w = 28;
        break;

      case "love":
        c = 12, h = 54, l = 78, g = 64, f = 36, p = 90, u = 116, d = 42, m = 20, v = 44,
          b = 20, w = 28;
        break;

      case t("0x10"):
        c = 1, h = 54, l = 72, g = 64, f = 32, p = 149, u = 190, d = 78, m = 25, v = 75,
          b = 23, w = 28;
        break;

      case t("0x12"):
        c = 5, h = 0, l = 80, g = 56, f = 10, p = 68, u = 132, d = 37, m = 19, v = 35, b = 18,
          w = 22;
        break;

      case t("0xf"):
        c = 10, h = 54, l = 120, g = 64, f = 32, p = 149, u = 190, d = 78, m = 130, v = 73,
          b = 130, w = 30;
        break;

      default:
        c = 34, h = 54, l = 72, g = 64, f = 32, p = 149, u = 190, d = 78, m = 25, v = 73,
          b = 23, w = 28;
    }
    var y = 0,
      S = 0;
    o.forEach(function(e, a) {
      if (e && " " != e) {
        var x = a % 8,
          i = Math.floor(a / 8),
          o = p + x * g + (n - i) * h,
          s = u + i * l + x * f;
        y = Math.max(y, o), S = Math[t("0x2c")](S, s);
      }
    });
    var k = this[t("0x2d")][t("0x2e")],
      P = Math.min((k - 16) / y, (k - 16) / S, 1),
      C = Math.max((k - y * P) / 2, 0) / P,
      T = Math[t("0x2c")]((k - S * P) / 2, 0) / P;
    a.scale(P, P), a[t("0x2f")](t("0x30")), a[t("0x31")](2), Math.floor(100 * Math[t("0x22")]());
    var M = [];
    if (this[t("0x16")][t("0x1f")][x]) M = this[t("0x16")][t("0x1f")][x];
    else {
      for (var I = 1; I <= c; I++) M.push(I);
      M[t("0x32")](function() {
        return Math.random() - .5;
      }), this[t("0x16")].people[x] = M;
    }
    o[t("0x27")](function(e, o) {
      if (e && " " != e) {
        var s = o % 8,
          r = Math[t("0x21")](o / 8),
          y = C + s * g + (n - r) * h,
          S = T + r * l + s * f,
          k = M[o % c];
        a[t("0x33")](), a[t("0x34")]("../../image/" + x + "/" + k + t("0x35"), y, S, p, u),
          i[t("0x36")](e) ? a[t("0x37")](y + v, S + b) : a[t("0x37")](y + d, S + m), a.rotate(37 * Math.PI / 180),
          a[t("0x38")](w), a[t("0x39")](e, -w / 2, w / 2), a[t("0x3a")]();
      }
    }), a.draw();
  },
  saveImage: function() {
    var e = this,
      a = (this[t("0x25")], this[t("0x3b")]),
      x = this.system[t("0x2e")];
    a[t("0x3c")] = t("0x3d"), a[t("0x33")](), a[t("0x3e")](this[t("0x16")][t("0x3f")][t("0x40")]),
      a[t("0x41")](0, 0, x, x), a[t("0x3a")](), e[t("0x17")]({
        loading: !0
      }), wx.canvasToTempFilePath({
        canvasId: t("0x42"),
        fileType: "png",
        success: function(i) {
          a[t("0x34")](i[t("0x43")], 0, 0, x, x), a.draw(), setTimeout(function() {
            wx[t("0x44")]({
              canvasId: t("0x45"),
              fileType: t("0x46"),
              success: function(a) {
                e[t("0x17")]({
                  loading: !1
                }), wx[t("0x47")]({
                  urls: [a[t("0x43")]]
                });
              }
            });
          }, 120);
        }
      });
  },
  setIndex: function(e) {
    var a = this.data[t("0x3f")];
    a[t("0x24")] = +e[t("0x48")][t("0x14")][t("0x24")], this[t("0x17")]({
      colorPicker: a
    });
  },
  setColor: function(e) {
    var a = this[t("0x16")][t("0x49")],
      x = t("0x4a"),
      i = +a[t("0x4a")].r,
      o = +a[t("0x4a")].g,
      s = +a[t("0x4a")].b;
    this[t("0x17")]({
      colorPicker: {
        key: x,
        color: t("0x4b") + i + "," + o + "," + s + ")",
        r: i,
        g: o,
        b: s
      }
    });
  },
  setBackground: function(e) {
    this[t("0x17")](e);
    var a = e[t("0x3f")].r[t("0x4c")](16),
      x = e[t("0x3f")].g[t("0x4c")](16),
      i = e[t("0x3f")].b[t("0x4c")](16);
    a.length < 2 && (a = "0" + a), x[t("0x28")] < 2 && (x = "0" + x), i[t("0x28")] < 2 && (i = "0" + i);
    var o = "#" + a + x + i;
    wx[t("0x4d")]({
      frontColor: t("0x4e") != o ? "#ffffff" : t("0x30"),
      backgroundColor: o
    }), getApp()[t("0x4f")][t("0x50")] = o, this[t("0x18")]();
  },
  getColor: function(e) {
    var a = this[t("0x16")][t("0x3f")][t("0x51")];
    if (a) {
      var x = this[t("0x16")][t("0x49")],
        i = +e[t("0x48")][t("0x14")].r,
        o = +e.currentTarget[t("0x14")].g,
        s = +e[t("0x48")][t("0x14")].b;
      x[a].r = i, x[a].g = o, x[a].b = s;
      var r = {
        colorPicker: {
          index: 0,
          key: a,
          color: t("0x4b") + i + "," + o + "," + s + ")",
          r: i,
          g: o,
          b: s
        },
        map: x
      };
      r[a] = t("0x4b") + i + "," + o + "," + s + ")", this[t("0x52")](r);
    }
  },
  sliderChange: function(e) {
    var a = this[t("0x16")][t("0x3f")][t("0x51")];
    if (a) {
      var x = e[t("0x53")][t("0x19")],
        i = e.currentTarget[t("0x14")][t("0x54")],
        o = this[t("0x16")][t("0x49")],
        s = this[t("0x16")][t("0x3f")];
      s[i] = x, s[t("0x40")] = t("0x4b") + s.r + "," + s.g + "," + s.b + ")", o[a] || (o[a] = {}),
        o[a] = {
          r: s.r,
          g: s.g,
          b: s.b
        };
      var r = {
        colorPicker: s,
        map: o
      };
      r[a] = t("0x4b") + o[a].r + "," + o[a].g + "," + o[a].b + ")", this.setBackground(r);
    }
  },
  closePicker: function() {
    var e = this[t("0x16")][t("0x3f")];
    e[t("0x51")] = "", this[t("0x17")]({
      colorPicker: e
    }), this[t("0x1b")]();
  },
  onLoad: function() {
    this.setData({
        textList: a
      }), this[t("0x3b")] = wx.createCanvasContext(t("0x45")), this[t("0x25")] = wx[t("0x55")](t("0x42")),
      this[t("0x2d")] = wx[t("0x56")](), this[t("0x1e")](), x = this[t("0x16")][t("0x57")];
  },
  selectSwitch: function() {
    this[t("0x17")]({
        isShowCom: !this[t("0x16")][t("0x1a")]
      }), 0 == this[t("0x16")][t("0x1a")] ? (console.log(i), x[i][t("0x58")] = !1) : x[i][t("0x58")] = !0,
      this.setData({
        bottomSelect: x
      });
  },
  bottomSelect: function(e) {
    var a = this;
    if (3 == (i = e.currentTarget[t("0x14")].id) && wx[t("0x1c")]({
        url: t("0x59")
      }), 0 == i || 1 == i || 2 == i) {
      for (var o = 0; o < x.length; o++) i == x[o].id ? x[o][t("0x58")] = !0 : x[o][t("0x58")] = !1;
      0 == i && (x[1][t("0x5a")] = !0, a[t("0x17")]({
        showPj: 0
      })), 1 == i && (x[0].haveBorder = !1, a[t("0x17")]({
        showPj: 1
      }), a.setColor()), 2 == i && (x[0][t("0x5a")] = !0, x[1][t("0x5a")] = !1, a[t("0x17")]({
        showPj: 2
      })), a[t("0x17")]({
        isShowCom: !0,
        bottomSelect: x
      });
    }
    4 == i && wx[t("0x1c")]({
      url: "/pages/more/index"
    });
  },
  tiaozhuan: function() {
    wx.navigateToMiniProgram({
      appId: "wxd5d2426e479213cd",
      path: "pages/index/index",
      extraData: {
        foo: "bar"
      },
      envVersion: "develop",
      success: function(e) {}
    });
  },
  onShareAppMessage: function() {
    return {
      title: "你敢把我举起来吗？"
    };
  }
});