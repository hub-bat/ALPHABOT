using Discord;
using Discord.WebSocket;

public class Program
{
    private static DiscordSocketClient _client;
    public static async Task Main(string[] args)
    {
        var program = new Program();
        await program.RunBotAsync();

    }
    public async Task RunBotAsync()
    {
        _client = new DiscordSocketClient();
        _client.Log += LogAsync;
        //TODO: Obfuscate Token
        var token = File.ReadAllText("C:\\Users\\oxxde\\Documents\\programming\\ALPHABOT\\ALPHABOT\\token.txt");

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();
        // Block this task until the program is closed.
        await Task.Delay(-1);
    }
    private Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log);
        return Task.CompletedTask;
    }
}
