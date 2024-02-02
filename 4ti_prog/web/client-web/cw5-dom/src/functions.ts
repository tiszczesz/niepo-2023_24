export const GenerList = (dane:string[]) =>{
    const ul = document.createElement("ul");
    ul.className = "list-group";
    dane.forEach((elem)=>{
        const li = document.createElement("li");
        const div = document.createElement("div");
        div.className = "d-flex justify-content-between";  
        const span = document.createElement("span");
         
        const text = document.createTextNode(elem);
        span.append(text);         
        const button = document.createElement("button");
        div.append(span);
        div.append(button);   
        li.appendChild(div);
        button.innerHTML = "<img src='delete.png'>";       
        li.className = "list-group-item";
        ul.appendChild(li);
    });
    return ul;
}