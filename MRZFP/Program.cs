using SysFile = System.IO.File;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

const string botName = "MRZFINDPASS";
string token = SysFile.ReadAllText(@"C:\Users\moroz69off\Documents\fdtoken.txt"); // this is temporary solution

TelegramBotClient botClient = new TelegramBotClient(token);

Telegram.Bot.Types.User me = await botClient.GetMeAsync();

using CancellationTokenSource cts = new();

ReceiverOptions receiverOptions = new() { AllowedUpdates = Array.Empty<UpdateType>() };

botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    receiverOptions: receiverOptions,
    cancellationToken: cts.Token
);

Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };

    Console.WriteLine(ErrorMessage);
    return Task.CompletedTask;
}

async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{
    if (update.Message is not { } message)
        return;
    // Only process text messages
    if (message.Text is not { } messageText)
        return;

    var chatId = message.Chat.Id;
    var bn = BotName.Equals;
    Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "You said:\n" + messageText + " Bot name - " + botName,
        cancellationToken: cancellationToken);
}

Console.ReadKey(false);
//________








