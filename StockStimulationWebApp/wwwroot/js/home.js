$(document).ready(function () { function s(s) { document.cookie = s + "=;expires=" + d } $(this).width() <= 768 ? ($(".change").css("padding-right", "0px"), $(".change").css("padding-left", "30px")) : ($(".change").css("padding-right", "30px"), $(".change").css("padding-left", "0px")); var d = new Date; console.log(d), $(document).width() <= 1100 && (console.log($(document).width()), $(".change").css("padding-right", "0px"), $(".change").css("padding-left", "10px"), $(" #table").show(), $(" #table").css("padding", "-5px"), $("#products .image").removeClass("col-sm-4 col-md-4 col-xs-4").addClass("col-xs-2 col-sm-2 col-md-1"), $(".item").css("padding", "0px"), $(".item").addClass("list-group-item"), $(".item").addClass("table-hover"), $(".moreinfo").css("padding-left", "25px"), s(grid), document.cookie = "list"), "grid" === document.cookie ? ($("#products .item").removeClass("list-group-item"), $("#products .item").addClass("grid-group-item"), $(".item").css("padding", "20px"), $("#products .image").removeClass("col-xs-2 col-sm-2 col-md-1").addClass("col-sm-4 col-md-4 col-xs-4"), $(" #table").hide(), $(".moreinfo").css("padding-left", "70px")) : "list"=== document.cookie && ($(" #table").show(), $(" #table").css("padding", "-5px"), $("#products .image").removeClass("col-sm-4 col-md-4 col-xs-4").addClass("col-xs-2 col-sm-2 col-md-1"), $(".item").css("padding", "0px"), $(".item").addClass("list-group-item"), $(".item").addClass("table-hover"), $(".moreinfo").css("padding-left", "25px")), $("#list").click(function (d) { d.preventDefault(), $(" #table").show(), $(" #table").css("padding", "-5px"), $("#products .image").removeClass("col-sm-4 col-md-4 col-xs-4").addClass("col-xs-2 col-sm-2 col-md-1"), $(".item").css("padding", "0px"), $(".item").addClass("list-group-item"), $(".item").addClass("table-hover"), $(".moreinfo").css("padding-left", "25px"), s(grid), document.cookie = "list" }), $("#grid").click(function (d) { d.preventDefault(), $("#products .item").removeClass("list-group-item"), $("#products .item").addClass("grid-group-item"), $(".item").css("padding", "20px"), $("#products .image").removeClass("col-xs-2 col-sm-2 col-md-1").addClass("col-sm-4 col-md-4 col-xs-4"), $(" #table").hide(), $(".moreinfo").css("padding-left", "70px"), $(window).width() <= 1100 && ($(".change").css("padding-right", "0px"), $(".change").css("padding-left", "10px"), $(" #table").show(), $(" #table").css("padding", "-5px"), $("#products .image").removeClass("col-sm-4 col-md-4 col-xs-4").addClass("col-xs-2 col-sm-2 col-md-1"), $(".item").css("padding", "0px"), $(".item").addClass("list-group-item"), $(".item").addClass("table-hover"), $(".moreinfo").css("padding-left", "25px")), s(list), document.cookie = "grid" }), $(window).on("resize", function () { var s = $(this); s.width() <= 1100 && s.width() >= 767 ? ($(".change").css("padding-right", "0px"), $(".change").css("padding-left", "10px"), $(" #table").show(), $(" #table").css("padding", "-5px"), $("#products .image").removeClass("col-sm-4 col-md-4 col-xs-4").addClass("col-xs-2 col-sm-2 col-md-1"), $(".item").css("padding", "0px"), $(".item").addClass("list-group-item"), $(".item").addClass("table-hover"), $(".moreinfo").css("padding-left", "25px")) : s.width() <= 766 ? ($(".change").css("padding-left", "40px"), $(".change").css("padding-right", "0px"), $(" #table").show(), $(" #table").css("padding", "-5px"), $("#products .image").removeClass("col-sm-4 col-md-4 col-xs-4").addClass("col-xs-2 col-sm-2 col-md-1"), $(".item").css("padding", "0px"), $(".item").addClass("list-group-item"), $(".item").addClass("table-hover"), $(".moreinfo").css("padding-left", "25px")) : ($(".change").css("padding-right", "30px"), $(".change").css("padding-left", "0px")) }) });