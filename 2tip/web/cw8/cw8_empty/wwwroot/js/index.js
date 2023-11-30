function createDiv(){
    const div = document.createElement("div");
    div.innerText = "To jest z JS";
    document.body.appendChild(div);
}
setTimeout(()=>{
    createDiv();
},3000)