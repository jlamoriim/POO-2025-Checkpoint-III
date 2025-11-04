Console.WriteLine("Para qual canal você quer enviar mensagem?");
Console.WriteLine("1. WhatsApp");
Console.WriteLine("2. Telegram");
Console.WriteLine("3. Instagram");
Console.WriteLine("4. Facebook");

if (!int.TryParse(Console.ReadLine(), out int canal))
{
    Console.WriteLine("Opção inválida");
    return;
}

TextMessage texto = new TextMessage("Olá, tudo bem?");
VideoMessage video = new VideoMessage("Assista este vídeo!");
PhotoMessage foto = new PhotoMessage("Veja esta foto!");
FileMessage arquivo = new FileMessage("Segue o relatório...");

switch (canal)
{
    case 1:
        var whats = new WhatsApp();
        whats.EnviarMensagem("11999999999", texto);
        whats.EnviarMensagem("11999999999", video);
        break;

    case 2:
        var telegram = new Telegram();
        telegram.EnviarMensagem("@usuarioTelegram", texto);
        telegram.EnviarMensagem("@usuarioTelegram", foto);
        break;

    case 3:
        var insta = new Instagram();
        insta.EnviarMensagem("lojinhadigital", texto);
        insta.EnviarMensagem("lojinhadigital", arquivo);
        break;

    case 4:
        var fb = new Facebook();
        fb.EnviarMensagem("empresaXYZ", texto);
        fb.EnviarMensagem("empresaXYZ", video);
        break;

    default:
        Console.WriteLine("Canal inválido.");
        break;
}
