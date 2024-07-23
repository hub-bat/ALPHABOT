using DSharpPlus.SlashCommands;
using DSharpPlus;
using DSharpPlus.Interactivity;
using DSharpPlus.Entities;

namespace ALPHA_BOT
{
    public class Commands : ApplicationCommandModule
    {
        /// <summary>
        /// Login slash command. Prints a string to ease logging into the chatroom.
        /// </summary>
        [SlashCommand("login", "Log into the chatroom.")]
        public async Task LoginCommand(InteractionContext ctx, [Option("username", "Username to login with")] String user)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent($"**{user} is ONLINE!**"));
        }
        /// <summary>
        /// Logout slash command. Prints a string to logout of the chatroom.
        /// </summary>
        [SlashCommand("logout", "Log out of the chatroom.")]
        public async Task LogoutCommand(InteractionContext ctx, [Option("username", "Username to logout")] String user)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent($"**{user} is OFFLINE!**"));
        }
        /// <summary>
        /// Setting status command. Prints a string to set a chatroom status. 
        /// </summary>
        [SlashCommand("set-status", "Set your status to a custom string.")]
        public async Task StatusCommand(InteractionContext ctx,
        [Option("user", "Username")] String user,
        [Option("status", "Status to set.")] String status)
        {
            var statusString = $"**{user} has set their status to {status.ToUpper()}!**";
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent(statusString));
        }
        /// <summary>
        /// Trading items command. Prints a string to trade items with another chatroom user.
        /// </summary>
        [SlashCommand("trade", "Trade items with another user.")]
        public async Task TradeCommand(InteractionContext ctx, 
        [Option("trader", "User who is trading an item.")] String trader, 
        [Option("reciever", "Recipient of item.")] String recipient, 
        [Option("trade-item", "Item to trade.")] String tradeItem, 
        [Option("recieving-item", "Requested item")] String recievedItem)
        {
            var tradeString = $"**{trader} has initiated a TRADE to {recipient} | [{tradeItem} -> {recievedItem}]**";
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent(tradeString));
        }
        /// <summary>
        /// Accept command. Prints a string to accept an incomming trade. 
        /// </summary>
        [SlashCommand("accept", "Accept an incomming trade.")]
        public async Task AcceptCommand(InteractionContext ctx,
        [Option("reciever", "Recipient (your username)")] String recipient,
        [Option("trader", "User trading the item (other username)")] String trader)
        {
            var acceptString = $"**{recipient} has ACCEPTED {trader}'s TRADE!**";
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent(acceptString));
        }
        /// <summary>
        /// Guardian's kick command. Prints a string to ease kicking another user. 
        /// </summary>
        [SlashCommand("guardian-kick", "Guardian kicks another user. (Please don't use if you don't have permission!)")]
        public async Task GuardianKickCommand(InteractionContext ctx,
        [Option("user", "User to kick.")] String user,
        [Option("time", "How long they're kicked for.")] String time,
        [Option("reason", "Reason for kick.")] String reason)
        {
            var kickString = $"**GUARDIAN has KICKED {user} for {time} | REASON: {reason}**";
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent(kickString));

        }

    }
}

