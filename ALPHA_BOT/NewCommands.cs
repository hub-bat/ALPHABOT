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
    [Command("usermanager")]
    public class NewCommands
    {
        [Command("login")]
        public static async ValueTask LoginAsync(CommandContext context, [SlashAutoCompleteProvider<UsersProvider>] string user) =>
            await context.RespondAsync($"**{user}has LOGGED IN!**");
        
        [Command("logout")]
        public static async ValueTask LogoutAsync(CommandContext context, [SlashAutoCompleteProvider<UsersProvider>] string user) =>
            await context.RespondAsync($"**{user}has LOGGED OUT!**");
    }
}
