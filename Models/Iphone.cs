namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //*VEJA MINHA SOLUÇÃO*
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //*VEJA MINHA SOLUÇÃO*
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iphone.");
        }
    }
}