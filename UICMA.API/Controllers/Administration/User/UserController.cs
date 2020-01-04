using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UICMA.API.ViewModels;
using UICMA.Service;
using UICMA.Domain.Entities;

namespace UICMA.API.Controllers.Administration
{
  
    public class UserController : Controller
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        public UserController(ILoggerManager logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            UserViewModel userViewModel = new UserViewModel();
            return Ok(_mapper.Map<User>(userViewModel));
        }
    }
}