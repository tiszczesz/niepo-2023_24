function delay(){
    setTimeout(function(){
        $(".info").hide(
            2000,
            function(){
           $("#btn1")[0].disabled = false;            
        })
    },1000)
}
$('#btn1')[0].disabled = true;
delay();
$("#btn1").click(function(){
    
    $(".info").show(1000);
});
$("#fadeIn").click(
    function(){  
        
        $("#fadeInElem").fadeIn(1000,function(){
            $("#fadeInElem").css(
                {"display":"flex",
                "justify-content":"center",
                "align-items":"center"
              }
            )
        });
    }
)
