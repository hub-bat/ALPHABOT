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
        //private static DiscordClient client {get; set;}
        static async Task Main(string[] args)
        {
            //read token
            var jsonReader = new JSONReader();
            await jsonReader.ReadJSON();

            //set up discord config
            //12/20/25 - Updating to use the new DSharpPlus building with new intents
            DiscordClientBuilder builder = DiscordClientBuilder.CreateDefault(jsonReader.token, DiscordIntents.AllUnprivileged);
            DiscordClient client = builder.Build();

            //connect to discord
            await client.ConnectAsync();
            //run forever
            await Task.Delay(-1);


        }
    }
}