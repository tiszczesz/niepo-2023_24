$(function () {
    const p1 = $("#p1");
    const p11 = document.querySelector("#p1");

    console.log(p1[0]);
    //p1.style.color = "red";
    p1[0].style.color = "green";
    //p11.style.color = "red";
    console.log(p11);
    Deley(2000);
    Deley2(3000);


    //obsluga przycisku 
    //document.querySelector("#Save").onclick = ...
    $("#Save").click(function(event){
        //alert(event.target);
        const firstname = $("#firstname").val();
        console.log($("#firstname"));
        if(firstname.trim().length===0){
            $("#result").html("Nie podałeś imienia");
            return;
        }
        $("#result")
         .html(`Witaj ${firstname} dzisiaj mamy: ${new Date().toLocaleDateString()}`);//witaj imie dzisiaj mamy: data
    });

});

function Deley(time){
    setTimeout(function(){
        $("#p1").html("To jest zmiana tekstu w jQuery");
        $("#p1").css({color:"red"});
    },time)
}
function Deley2(time){
    setTimeout(function(){        
        $("#h1").css({color:"red"});
    },time)
}
