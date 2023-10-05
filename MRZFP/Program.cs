using Telegram;
using Telegram.Bot;


//Console.WriteLine("Hello, World!");


TelegramBotClient botClient = new TelegramBotClient("token");

Telegram.Bot.Types.User me = await botClient.GetMeAsync();



Console.WriteLine($"I am user {me.Id} and my name is {me.FirstName}.");

Console.ReadKey(false);
//________
