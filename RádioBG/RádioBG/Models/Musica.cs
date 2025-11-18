namespace RádioBG.Models // <--- SUBSTITUA pelo namespace do seu projeto, ex: RadioBG.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cantor { get; set; } = string.Empty;
    }
}
