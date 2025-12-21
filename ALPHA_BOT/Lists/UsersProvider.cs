using System;
using DSharpPlus.Commands.Processors.SlashCommands.ArgumentModifiers;
using DSharpPlus.Entities;

namespace ALPHA_BOT.Lists;

public class UsersProvider : SimpleAutoCompleteProvider
{
    static DiscordAutoCompleteChoice[] UserList = [ .. File.ReadAllLines("user_list.txt").Select(l => l.Split('\n')).Select(p => new DiscordAutoCompleteChoice(p[0], p[0]))];
    protected override IEnumerable<DiscordAutoCompleteChoice> Choices => UserList;
}
