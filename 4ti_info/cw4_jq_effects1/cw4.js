function delay(){
    setTimeout(function(){
        $(".info").hide(
            3000,
            function(){
            alert("koniec animacji");
            
        })
    },3000)
}
delay();