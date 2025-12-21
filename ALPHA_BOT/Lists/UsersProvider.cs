using System;
using DSharpPlus.Commands.Processors.SlashCommands.ArgumentModifiers;
using DSharpPlus.Entities;

namespace ALPHA_BOT.Lists;

public class UsersProvider : SimpleAutoCompleteProvider
{
    static DiscordAutoCompleteChoice[] UserList = [ .. File.ReadAllLines("~/Lists/test.txt").Select(l => l.Split(' ')).Select(p => new DiscordAutoCompleteChoice(p[1], p[0]))];
    protected override IEnumerable<DiscordAutoCompleteChoice> Choices => UserList;
}
