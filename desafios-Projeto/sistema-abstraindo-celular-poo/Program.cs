using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("(11) 95694-1041", "C01 Plus", "352287015527283", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("(11) 96962-9961", "14 Pro Max", "356728110605330", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");