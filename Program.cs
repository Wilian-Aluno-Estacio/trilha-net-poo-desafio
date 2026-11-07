using DesafioPOO.Models;

Smartphone nokia = new Nokia("11999999999", "Nokia Tijolão", "111111111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("11988888888", "iPhone 15", "222222222222222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");