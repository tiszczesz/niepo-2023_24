void ex1(){
    List<int> numbers = new List<int>();
    numbers.Add(34);
    numbers.Add(56);
    Show(numbers);
    numbers.Add(55);
    numbers.Add(-5);
    numbers.Add(90);
    Show(numbers);
    try{
         InsertToList(numbers,0);
    }catch(FormatException ex){
        Console.WriteLine(ex.Message);
    }
   
    Show(numbers);
}
ex1();
void Show(List<int> elemnts){
    foreach(int elem in elemnts){
        Console.WriteLine(elem);
    }
}
void InsertToList(List<int> list, int finisher = 0){
    //dodaje kolejne liczby tak dlugo az podamy finishera
    int number;
    do
    {
        Console.Write($"Podaj liczbe ({finisher} konczy): ");
        number = Convert.ToInt32(Console.ReadLine());
        if(number!=finisher) list.Add(number);
    }while(number!=finisher);
}