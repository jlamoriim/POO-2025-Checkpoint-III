public class Telegram
{
    public void EnviarMensagem(string numeroOuUsuario, TextMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando mensagem de texto para {numeroOuUsuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string numeroOuUsuario, VideoMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando mensagem de vídeo para {numeroOuUsuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string numeroOuUsuario, PhotoMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando mensagem de foto para {numeroOuUsuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string numeroOuUsuario, FileMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando mensagem de arquivo para {numeroOuUsuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }
}