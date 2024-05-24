//console.log(document.forms);


document.forms[0].onsubmit = function (e) {
    const value = document.querySelector("input[name=pozycja]").value;
    if(value.length===0) {
        e.preventDefault();
        return;
    }  
}