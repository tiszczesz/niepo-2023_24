export const GenerList = (dane:string[]) =>{
    const ul = document.createElement("ul");
    ul.className = "list-group";
    dane.forEach((elem,i)=>{
        const li = document.createElement("li");
        const div = document.createElement("div");
        div.className = "d-flex justify-content-between";  
        const span = document.createElement("span");
         
        const text = document.createTextNode(elem);
        span.append(text); 
        const img = document.createElement("img");
        img.className = "delete";
        img.src = "delete.png";
        img.id = i.toString();
        div.append(span);
        div.append(img);
       
        li.appendChild(div);
             
        li.className = "list-group-item";
        ul.appendChild(li);
    });
    return ul;
}