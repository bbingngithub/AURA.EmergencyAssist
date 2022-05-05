using AURA.EmergencyAssist.BLL.Interfaces;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.SignalR;
using AURA.EmergencyAssist.SignalRHub;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.BLL.Implementations
{
    public class NotificationHandler : INotificationHandler
    {

        private readonly IHubContext<NotificationHub> notificationHubContext;
        private readonly IHubContext<NotificationUserHub> notificationUserHubContext;
        private readonly IUserConnectionManager userConnectionManager;

        public NotificationHandler(IHubContext<NotificationHub> notificationHubContext, IHubContext<NotificationUserHub> notificationUserHubContext, IUserConnectionManager userConnectionManager)
        {
            this.notificationHubContext = notificationHubContext;
            this.notificationUserHubContext = notificationUserHubContext;
            this.userConnectionManager = userConnectionManager;
        }
        public async Task NotifyUsers(MessageModel messageModel)
        {
            await notificationHubContext.Clients.All.SendAsync("sendToUser", messageModel.AlertStatusData.AlertStatusName, messageModel.RespondentLocationData);
        }
        public async Task NotifyUsers(NotificationModel notificationModel)
        {
            await notificationHubContext.Clients.All.SendAsync("sendToUser", notificationModel.Header, notificationModel.Content, notificationModel.Latitude, notificationModel.Longitude, notificationModel.SubscriberID);
        }
        public async Task NotifySpecificUsers(NotificationModel notificationModel)
        {
            var connections = userConnectionManager.GetUserConnections(notificationModel.UserId);
            if (connections != null && connections.Count > 0)
            {
                foreach (var connectionId in connections)
                {
                    await notificationUserHubContext.Clients.Client(connectionId).SendAsync("sendToUser", notificationModel.Header, notificationModel.Content);
                }
            }
        }
    }
}
