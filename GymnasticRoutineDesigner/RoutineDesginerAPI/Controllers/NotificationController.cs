using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RoutineDesginerAPI.Hubs;

namespace RoutineDesginerAPI.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {

        private IHubContext<NotificationHub> _notificationHub;

        public NotificationController(IHubContext<NotificationHub> notificationHub)
        {
            _notificationHub = notificationHub;
        }

        [HttpPost]
        [Route("Create"), ActionName("CreateNotification")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Create(Notification notification)
        {
            await _notificationHub.Clients.All.SendAsync("sendToReact", "'The message '" + notification.Message + "' has been recieved'");
            return Ok("ha");
        }

        public async Task<IActionResult> SendNotification(string message)
        {
            Notification not = new Notification();
            not.Message = message;
            await _notificationHub.Clients.All.SendAsync("RecieveNotification", not.Message);
            return Ok();
        }
    }
}
