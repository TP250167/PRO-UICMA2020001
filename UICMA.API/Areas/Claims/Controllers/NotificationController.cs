using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Notifications;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {        
        private ILoggerManager _logger;
        private IMapper _mapper;
        private INotificationService _NotificationService;

        public NotificationController(ILoggerManager logger, IMapper mapper, INotificationService _NotificationService)
        {
            _logger = logger;
            _mapper = mapper;
            this._NotificationService = _NotificationService;
        }

        [HttpPost("AddandUpdateNotification")]
        public Notification AddandUpdateNotification(Notification notification)
        {
            return _NotificationService.AddandUpdateNotification(notification);
        }

        [HttpGet("GetNotificationAll")]
        public ActionResult<IEnumerable<Notification>> GetNotificationAll()

        {
            var result = _NotificationService.GetNotificationAll().ToList();
            return result;
        }

        [HttpGet("GetNotificationbyID/{id}")]
        public ActionResult<Notification> GetNotificationbyID(int id)
        {
            var results = _NotificationService.GetNotificationbyID(id);
            return results;
        }

    }
}