using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// *VEJA MINHA SOLUÇÃO*


Console.WriteLine("Telefone nokia");
Smartphone nokia = new Nokia(numero: "92442433", modelo: "modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
/*CASO A PROPRIEDADE protected SEJA MUDADA PARA public NA CLASSE SMARTPHONE
AS LINHAS ABAIXO RETORNARÃO SEUS VALORES
APENAS REMOVA OS MARCADORES DE ANOTAÇÃO (*//*) */

/*Console.WriteLine($"Seu número é: {nokia.Numero}.");
Console.WriteLine($"Seu modelo é: {nokia.Modelo}.");
Console.WriteLine($"Seu IMEI é: {nokia.Imei}.");
Console.WriteLine($"Sua memória é: {nokia.Memoria} gigabyte.");*/

Console.WriteLine("\n");

Console.WriteLine("Telefone iphone");
Smartphone iphone = new Iphone(numero: "84178586", modelo: "modelo 2", imei: "2222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
/*CASO A PROPRIEDADE protected SEJA MUDADA PARA public NA CLASSE SMARTPHONE
AS LINHAS ABAIXO RETORNARÃO SEUS VALORES
APENAS REMOVA OS MARCADORES DE ANOTAÇÃO (*//*) */

/*Console.WriteLine($"Seu número é: {iphone.Numero}.");
Console.WriteLine($"Seu modelo é: {iphone.Modelo}.");
Console.WriteLine($"Seu IMEI é: {iphone.Imei}.");
Console.WriteLine($"Sua memória é: {iphone.Memoria} gigabyte.");*/

