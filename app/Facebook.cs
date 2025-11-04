public class Facebook
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de texto para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de vídeo para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de foto para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Facebook] Enviando mensagem de arquivo para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }
}
