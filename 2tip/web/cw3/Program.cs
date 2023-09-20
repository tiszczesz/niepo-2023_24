Console.Write("Ile imion?: ");
int times = Convert.ToInt32(Console.ReadLine());
string[] names = new string[times];
FillArray(names);
ShowArray(names);

//////////////////////////////////////////
void FillArray(string[] data){
    int size = data.Length;    
    for(int i=0; i<size;i++){
        Console.Write($"Podaj tekst do tablicy {i+1}/{size}: ");
        data[i] = Console.ReadLine()!;
    }
}
void ShowArray(string[] data){
    foreach(string elem in data){
        Console.WriteLine(elem);
    }
}
