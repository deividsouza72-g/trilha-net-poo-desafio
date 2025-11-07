using DesafioPOO.Models;

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("789", "708090", "456789", 2000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("123", "102030,", "123456", 1000);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");