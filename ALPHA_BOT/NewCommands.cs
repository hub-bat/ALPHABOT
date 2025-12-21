using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;
using DSharpPlus.Entities;
using DSharpPlus.Commands;
using DSharpPlus.Commands.Processors.SlashCommands.ArgumentModifiers;
using ALPHA_BOT.Lists;

namespace ALPHA_BOT
{
    public class NewCommands
    {
        [Command("login")]
        public static async ValueTask ExecuteAsync(CommandContext context, [SlashAutoCompleteProvider<UsersProvider>] string user) =>
            await context.RespondAsync($"**{user} has LOGGED IN!**");
    }
}
