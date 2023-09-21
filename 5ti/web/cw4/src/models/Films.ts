export class Film{
    constructor(
        public title:string,
        public director:string,
        public length:number=100,
        public editDate:Date=new Date()
    ){}
}
export const films:Film[] = [
    new Film("Zabłąkane owce","Damian Wałek"),
    new Film("Szczęki 20","Alex Mith",120,new Date('2020-04-12')),
    new Film("Morskie oko nocą","Rafał Nowy"),
    new Film("Krwawe jedzenie","Anna Gruń",130),
    new Film("Goo","Hellen With",89,new Date('2018-04-12')),
]
export const emptyFilms:Film[]=[];