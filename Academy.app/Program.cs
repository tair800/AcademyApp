using Academy.Core.Metods;
student shagird = new student("Tahir","Aslanli","P237","Coding");
Console.WriteLine("add name");
string name = Console.ReadLine();
Console.WriteLine("add surname");
string surname=Console.ReadLine();
Console.WriteLine("add group");
string group = Console.ReadLine();
Console.WriteLine("add education");
string education=Console.ReadLine();

Console.WriteLine(shagird.getfullinfo());

