using Microsoft.AspNetCore.SignalR;
using ModelApp;
using ModelApp.Repository;

namespace BlazorApp.Hubs
{
    public class ChatHub : Hub
    {
        ModelApp.Repository.Repository Repository { get; set; }

        public async Task SendMessage(string user, string message)
        {
            Repository = new Repository();
            Discussion discussion = new Discussion() { createdOn = DateTime.UtcNow, message = message, user = user };
            Repository.insertDiscussion(discussion);

            await Clients.All.SendAsync("ReceiveMessageTest", discussion.createdOn.ToString("dddd, dd MMMM yyyy HH:mm"), user, message);
        }
    }
}
