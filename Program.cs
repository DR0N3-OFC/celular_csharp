using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("1234567", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("22222222", "Modelo 1", "2222222222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
