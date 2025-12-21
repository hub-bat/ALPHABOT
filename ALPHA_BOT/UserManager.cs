using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;
using DSharpPlus.Entities;
using DSharpPlus.Commands;
using DSharpPlus.Commands.Processors.SlashCommands.ArgumentModifiers;
using ALPHA_BOT.Lists;
using System.ComponentModel;
using DSharpPlus.Commands.ContextChecks;

namespace ALPHA_BOT
{
    [Command("usermanager")]
    public class UserManager
    {
        [Command("login")]
        [Description("Login to the chatroom.")]
        public static async ValueTask LoginAsync(CommandContext context, [SlashAutoCompleteProvider<UsersProvider>][Description("Username to login.")] string user) =>
            await context.RespondAsync($"**{user} has LOGGED IN!**");
        
        [Command("logout")]
        [Description("Logout of the chatroom.")]
        public static async ValueTask LogoutAsync(CommandContext context, [SlashAutoCompleteProvider<UsersProvider>][Description("Username to logout.")] string user) =>
            await context.RespondAsync($"**{user} has LOGGED OUT!**");
        
        [Command("kick")]
        [Description("Guardian's Kick - Administrator only")]
        [RequirePermissions(DiscordPermission.Administrator)]
        public static async ValueTask KickAsync(CommandContext context, [SlashAutoCompleteProvider<UsersProvider>][Description("Username to kick.")] string user, [Description("Amount of time.")] string time, [Description("Reason for kick.")] string reason)
        {
            await context.RespondAsync($"**GUARDIAN has KICKED {user} for {time} | REASON: {reason}**");
        }
    }
}
