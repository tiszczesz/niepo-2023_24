function delay(){
    setTimeout(function(){
        $(".info").hide(
            2000,
            function(){
           $(".button")[0].disabled = false;            
        })
    },1000)
}
$('.button')[0].disabled = true;
delay();
$(".button").click(function(){
    $(".info").show(1000);
});