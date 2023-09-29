using cw3;

Person p1 = new Person("Adam","Nowak",new DateTime(2005,6,12));
Person p2 = new Person("Renata","Nowak",new DateTime(2007,12,24));
Person p3 = new Person();
p1.Show();
p2.Show();
p3.Show();

Console.WriteLine(p1);
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());
p1.Firstname = "fffff"; //hermetyzacja
Console.WriteLine(p1);
Console.WriteLine($" wiek osoby: {p2.GetAge()}");

