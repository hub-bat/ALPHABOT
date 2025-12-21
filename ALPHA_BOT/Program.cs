using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;
using DSharpPlus.Entities;
using DSharpPlus.Commands;

namespace ALPHA_BOT
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //read token
            var jsonReader = new JSONReader();
            await jsonReader.ReadJSON();

            //set up discord config
            //12/20/25 - Updating to use the new DSharpPlus building with new intents
            DiscordClientBuilder builder = DiscordClientBuilder.CreateDefault(jsonReader.token, DiscordIntents.AllUnprivileged);
            //setup commands extensions
            builder.UseCommands((IServiceProvider serviceProvider, CommandsExtension extension) =>
            {
                extension.AddCommand(typeof(UserManager));
                
            }, new CommandsConfiguration()
            {
            });
            DiscordClient client = builder.Build();

            //specify a status
            DiscordActivity status = new("TESTING!", DiscordActivityType.ListeningTo);
            //connect to discord
            await client.ConnectAsync(status, DiscordUserStatus.Online);
            //run forever
            await Task.Delay(-1);


        }
    }
}