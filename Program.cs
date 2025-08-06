using DesafioPOO.Models;

Smartphone nokia = new Nokia("2188888888", "Nokia N10", "49340539405", 1024u * 1024u * 1023u * 4u);
Smartphone iphone = new Iphone("2188888888", "Iphone 14", "3924093859", 1024u * 1024u * 1023u * 4u);

nokia.Ligar();
nokia.InstalarAplicativo("iFood");

iphone.Ligar();
iphone.InstalarAplicativo("Camera");
