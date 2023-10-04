using Telegram;
using Telegram.Bot;


//Console.WriteLine("Hello, World!");


TelegramBotClient botClient = new TelegramBotClient("6565715841:AAEImiPVEnQ9fy7lE7ZDCkLvl2gi1zutmvg");

Telegram.Bot.Types.User me = await botClient.GetMeAsync();



Console.WriteLine($"I am user {me.Id} and my name is {me.FirstName}.");

Console.ReadKey(false);
//________
