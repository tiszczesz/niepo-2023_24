import { Products } from "./dane.js";
import { GenerList } from "./functions.js";
let products = [...Products];
const root = document.querySelector<HTMLDivElement>("#root");
console.log(products);
function RefreshList(root: HTMLDivElement | null, products: string[]) {
    root!.innerHTML = "";
    root?.appendChild(GenerList(products));
    const imgs = document.querySelectorAll<HTMLButtonElement>("img.delete");
    imgs.forEach((e, i) => {
        e.addEventListener("click", (event: Event) => {
            console.log("przed usunięciem: ",products); 
           
            products.splice(parseInt((event.target as HTMLImageElement).id),1);
            console.log("po usunięciu: ",products);            
            RefreshList(root, products);
           // debugger;
        });
    });
}
RefreshList(root, products);
document.
    querySelector<HTMLFormElement>("#form")
    ?.addEventListener("submit", (event: Event) => {
        const input = document.querySelector<HTMLInputElement>("#product");
        event.preventDefault();
        console.log(input?.value);
        if (input?.value !== undefined && root !== null) {
           // debugger;
            products.push(input?.value);
            console.log("po dodaniu:" ,products);
            
            RefreshList(root, products);
            input!.value = "";
        }
    });



