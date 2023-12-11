using Microsoft.AspNetCore.SignalR;
using RealTimeData.DataAccessLayer.Concrete;

namespace RealTimeData.Api.Hubs
{
    public class SignalRHub : Hub
    {
        RealTimeDataContext context = new RealTimeDataContext();
        
        public async Task SendCategoryCount()

        {
            var value=context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
