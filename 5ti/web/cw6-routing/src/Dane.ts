export interface Product{
    name:string;
    price:number;
    category:string;
}
export const Products:Product[] = [
    {name:"Bułki",price:1.99,category:"pieczywo"},
    {name:"Chleb",price:3.99,category:"pieczywo"},
    {name:"Weka",price:2.99,category:"pieczywo"},
    {name:"Fanta 0.33l",price:1.99,category:"napoje"},
    {name:"Orange 0.5l",price:4.99,category:"napoje"},
    {name:"Mortadela",price:1.99,category:"wędliny"},
]
export const Categories = [
    "nabiał","pieczywo","napoje","wędliny","mięso"
]