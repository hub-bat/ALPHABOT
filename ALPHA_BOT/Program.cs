using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.SlashCommands;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;

namespace ALPHA_BOT
{
    class Program
    {
        private static DiscordClient client {get; set;}
        static async Task Main(string[] args)
        {
            //read token
            var jsonReader = new JSONReader();
            await jsonReader.ReadJSON();

            //set up discord config
            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = LogLevel.Debug
            };

            //set up client
            client = new DiscordClient(discordConfig);
            //register slash command
            var slash = client.UseSlashCommands();
            slash.RegisterCommands<Commands>(853718869910880258);
            //this is what runs when the client has connected
            //client.Ready += Client_Ready;
            //connect to discord
            await client.ConnectAsync();
            //run forever
            await Task.Delay(-1);


        }

        private static async Task Client_Ready(DiscordClient sender, ReadyEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}