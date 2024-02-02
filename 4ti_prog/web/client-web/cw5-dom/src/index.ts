import { Products } from "./dane.js";
import { GenerList } from "./functions.js";

const root = document.querySelector<HTMLDivElement>("#root");
console.log(Products);
function RefreshList(root:HTMLDivElement|null){
    root!.innerHTML = "";
    root?.appendChild(GenerList(Products));
    const imgs = document.querySelectorAll<HTMLButtonElement>("img.delete");
    imgs.forEach((e,i)=>{
        e.addEventListener("click",(event:Event)=>{
            console.log((event.target ));
            
        });
    });
}
RefreshList(root);
document.
    querySelector<HTMLFormElement>("#form")
    ?.addEventListener("submit",(event:Event)=>{
        const input = document.querySelector<HTMLInputElement>("#product");
        event.preventDefault();
        console.log(input?.value);
        if(input?.value!==undefined && root!==null){
             Products.push(input?.value);            
            RefreshList(root);
            input!.value = "";
        }
       
    });



