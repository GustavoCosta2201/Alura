namespace ScreenSound.API.Requests
{
    public record MusicaRequest(string nome, ICollection<GeneroRequest> Generos = null);
    
}
