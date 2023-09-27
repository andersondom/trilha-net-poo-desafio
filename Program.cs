using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia:");
Nokia nokia = new Nokia(numero: "1010-1010", modelo: "Modelo 1", imei: "101010101010", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone iPhone:");
Iphone iphone = new Iphone(numero: "2020-2020", modelo: "Modelo 2", imei: "202020202020", memoria: "256");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");