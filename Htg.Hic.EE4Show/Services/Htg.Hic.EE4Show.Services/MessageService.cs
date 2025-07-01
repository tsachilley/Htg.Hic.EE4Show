using Htg.Hic.EE4Show.Services.Interfaces;

namespace Htg.Hic.EE4Show.Services;

public class MessageService : IMessageService
{
	public string GetMessage()
	{
		return "Hello from the Message Service";
	}
}
