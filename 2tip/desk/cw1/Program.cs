// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string firstname;
Console.Write("Podaj swoje imie: ");
firstname = Console.ReadLine();
Console.WriteLine($"Witaj {firstname}");

int age = 0;
Console.Write("Podaj swoj wiek: ");
age = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Witaj "+firstname+ " twoj wiek: "+age);
Console.WriteLine($"Witaj {firstname} twoj wiek: {age}");