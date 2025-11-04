public class Instagram
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de texto para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de vídeo para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de foto para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem de arquivo para @{usuario}");
        Console.WriteLine($"Mensagem: {message.Message}");
    }
}
