using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDiscord
{
    public class Discord
    {
		private DiscordSocketClient _client;
		public string BotToken { get; set; }
		public ulong TextChannelId { get; set; }
		public ulong GuildServerId { get; set; }

		public Discord(string _BotToken, ulong _GuildServerId, ulong _TextChannelId)
		{
			BotToken = _BotToken;
			GuildServerId = _GuildServerId;
			TextChannelId = _TextChannelId;
			MainAsync().GetAwaiter();
		}

		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();

			// Use this line if you have a log handler for the app
			//_client.Log += Log();

			await _client.LoginAsync(TokenType.Bot,
				BotToken);
			await _client.StartAsync();

			// register events
			//_client.MessageReceived += MessageReceived;

			_client.Ready += () =>
			{
				Console.WriteLine("Bot is connected!");
				return Task.CompletedTask;
			};

			// Block this task until the program is closed.
			await Task.Delay(-1);
		}

		//private async Task MessageReceived(SocketMessage message)
		//{
		//	if (message.Content == "!ping")
		//	{
		//		await message.Channel.SendMessageAsync("Pong!");
		//	}
		//}

		//public string GetChannelTopic(ulong id)
		//{
		//	var channel = _client.GetChannel(ChannelId) as SocketTextChannel;
		//	return channel?.Topic;
		//}

		public SocketGuildUser GetGuildOwner(SocketChannel channel)
		{
			var guild = (channel as SocketGuildChannel)?.Guild;
			return guild?.Owner;
		}

		public async Task SendMessage(string message, bool taghere = false, bool tageveryone = false)
		{
			if (taghere)
				message = "@here " + message;
			if (tageveryone)
				message = "@everyone " + message;
			await _client.GetGuild(GuildServerId).GetTextChannel(TextChannelId).SendMessageAsync(message);
		}

		public async Task SendFile(string filepath, string caption, bool taghere = false, bool tageveryone = false)
		{
			if (taghere)
				caption = "@here " + caption;
			if (tageveryone)
				caption = "@everyone " + caption;
			await _client.GetGuild(GuildServerId).GetTextChannel(TextChannelId).SendFileAsync(filepath, caption);
		}

	}

}

