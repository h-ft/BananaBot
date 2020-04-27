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
        random,
        list
    }
    public class Commands
    {
        [Command("hello")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 {Response.RandomEnum<Responses>().ToString()}, {ctx.User.Mention}!");
        }
        [Command("random")]
        public async Task Random(CommandContext ctx, int min, int max)
        {
            var rnd = new Random();
            await ctx.RespondAsync($"🎲 Your random number is: {rnd.Next(min, max)}");
        }

        [Command("list")]
        public async Task Helping(CommandContext ctx)
        {
            await ctx.RespondAsync($" Hi {ctx.User.Mention}! Here are the list of available commands you can try. Remember to use + before every command!");
            foreach (CommandList val in Enum.GetValues(typeof(CommandList)))
            {
                await ctx.RespondAsync($"{val.ToString()}");
            }
        }
    }
}
