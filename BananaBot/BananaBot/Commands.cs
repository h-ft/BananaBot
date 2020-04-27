using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Collections.Generic;
using System.Text;

namespace BananaBot
{
    public enum CommandList //a collection of the bot's commands. It may expand
    {
        hello,
        help
    }
    public class Commands
    {
        [Command("hello")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 {Response.RandomEnum<Responses>().ToString()}, {ctx.User.Mention}!");
        }
        [Command("help")]
        public async Task Help(CommandContext ctx)
        {
            await ctx.RespondAsync($" Hi {ctx.User.Mention}! Here are the list of available commands you can try. Remember to use + before every command!");
            foreach(CommandList val in Enum.GetValues(typeof(CommandList)))
            {
                await ctx.RespondAsync(val.ToString());
            }
        }
    }
}
