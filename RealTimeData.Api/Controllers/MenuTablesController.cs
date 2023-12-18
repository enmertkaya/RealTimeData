﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeData.BusinessLayer.Abstract;

namespace RealTimeData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTablesController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }

        [HttpGet("MenuTableCount")]
        public IActionResult MenuTableCount ()
        {
            return Ok(_menuTableService.TMenuTableCount());
        }
    }
}
