/// <reference path="jquery-1.8.3.min.js" />

$(function () {
    //创建自动播放的事件并调用a事件
    time = setInterval("a()", 1000);
    //鼠标放进去图片时图片停止自动播放事件
    $("#lubo .lubo img").hover(function () {
        //清除自动播放
        clearInterval(time);
    }, function () {
        //鼠标移出图片时图片开始自动播放事件
        //对自动播放重新赋值
        time = setInterval("a()", 1000);
    });
});
//创建自动播放的时间公共变量
var time;
//创建图片的数组
var array = ['images/shouye/1.png', 'images/shouye/3.gif', 'images/shouye/4.jpg'];
//创建图片数组的下标
var index = 1;
//控制自动播放的事件
function a() {
    if (index < 0) {
        //下标是从0开始，而我们声明的变量是从1开始，所以要减1
        index = array.length - 1;
    }
    //判断如果下标大于图片数组返回第一张从新开始
    if (index >= array.length) {
        index = 0;
    }
    //指定图片的src内容，通过数组来赋值
    $("#lubo .lubo ul li img").attr('src', array[index]);
    index++;
}
function b() {
    //返回上一张 假设当前图片为2是 下一张就为0;s
    index = index - 2;
    a();
    clearInterval(time);
    time = setInterval("a()", 1000);
}
function c() {
    //index++;
    a();
    clearInterval(time);
    time = setInterval("a()", 1000);
}
//$(function () {
//    var stop = false;
//    //自动播放
//      setInterval(function () {
//          if (stop) {
//              return;
//          }
//          $(".lubo>ul>li:eq(0)").animate({
//              "opacity": "0",
//              "margin-left": "-970px",
//            },function () {
//                $(this).appendTo(".lubo>ul").css({ "margin-left": "0px","opacity":"1"});
//            });
//      }, 3000);
//    //鼠标移入移出事件
//    //移入停止播放
//    $(".lubo>ul>li>img").mouseover(function () {
//        stop = true;
//        $(".lubo>ul>li:eq(0)").stop().animate({
//            "margin-left": "0px",
//        }) 
//    }).mouseout(function () {
//    $(".lubo>ul>li:eq(0)").stop().animate({
//        "margin-left": "-970px",
//    });
//    stop = false;
//    })
//    //左边箭头
//    $("#zuo>img").mouseover(function () {
//        {
//            stop = true;
//            $(".lubo>ul>li:eq(0)").stop().animate({
//                "margin-left": "0px",
//            });
//            $("#zuo>img").click(function () {
//                $(".lubo>ul>li:eq(0)").animate({
//                    "margin-left": "-970px",
//                },
//                function () {
//                    $(this).appendTo(".lubo>ul").css({ "margin-left": "0px" });
//                });
//            })

//        }
//        }).mouseout(function () {
//            stop = false;
//        })
//    //右边箭头
//    $("#you>img").mouseover(function () {
//        {
//            stop = true;
//            $(".lubo>ul>li:eq(0)").stop().animate({
//                "margin-left": "0px",
//            });
//            $("#you>img").click(function () {
//                $(".lubo>ul>li:eq(0)").animate({
//                    "margin-left": "970px",
//                },
//                function () {
//                    $(this).appendTo(".lubo>ul").css({ "margin-right": "-970px" });
//                });
//            })
//        }
//    }).mouseout(function () {
//        stop = false;
//    })


//$("#you").click(function () {
//    $(this).stop();
//    $(this).find("li").next();
//    $(".lubo>ul>li:eq(0)").animate({
//        "margin-top": "400px",
//    }, 1000, function () {
//        $(this).appendTo(".lubo>ul").css({ "margin-top": "0px" });
//    }, 2000);
//    $(".lubo>ul>li:eq(0)").play();
//})
//},2000).mouseout(function () {
//    stop = false;


//})


