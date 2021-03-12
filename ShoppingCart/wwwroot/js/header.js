var myDefaultWhiteList = $.fn.tooltip.Constructor.Default.whiteList

$(".mobile-toggle-nav").click(
function(){
    $(this).toggleClass("is-active"),
    $(".app-container").toggleClass("header-mobile-open"),
    $(".app-header-right").hasClass("header-mobile-open")&&$(".app-header-right").removeClass("header-mobile-open")
}),
$(".mobile-toggle-header-nav").click(function(){
    $(this).toggleClass("active"),
    $(".app-header-right").toggleClass("header-mobile-open"),
    $(".app-container").hasClass("header-mobile-open")&&$(".app-container").removeClass("header-mobile-open")
}),
$(".show-menu-btn").on("click",function(){
    $(".app-inner-layout-page").addClass("app-layout-menu-open")
}),
$(".close-menu-btn").on("click",function(){
    $(".app-inner-layout-page").removeClass("app-layout-menu-open")
}),
$(".mobile-app-menu-btn").click(function(){
    $(".hamburger",this).toggleClass("is-active"),
    $(".app-inner-layout").toggleClass("open-mobile-menu")
}),
$(window).scroll(function(){
    var t=$(".app-header").height();
    $(this).scrollTop()>=t?$(".app-container").addClass("fixed-header"):$(".app-container").removeClass("fixed-header"),
    $(this).scrollTop()>=t+50?$(".app-container").addClass("scrolled-header"):$(".app-container").removeClass("scrolled-header"),
    $(this).scrollTop()>=t+80?$(".app-container").addClass("smaller-header"):$(".app-container").removeClass("smaller-header")
}),
$(window).on("resize",function(){
    $(this).width()>991&&(
        $(".app-container").removeClass("header-mobile-open"),
        $(".mobile-toggle-nav").removeClass("is-active")
    )
})
// var myDefaultWhiteList = $.fn.tooltip.Constructor.Default.whiteList;
