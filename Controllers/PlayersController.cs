using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizUApi.Models;
using QuizUApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace QuizUApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerServices _playerServices;
        public PlayersController(IPlayerServices playerServices)
        {
            _playerServices = playerServices;
        }

        [HttpPost]
        public async Task<IActionResult> LoginAndRegisterPlayer(LoginAndRegisterPlayer loginAndRegisterPlayer)
        {
            return Ok(await _playerServices.LoginAndRegester(loginAndRegisterPlayer));
        }
        [HttpPost("AddScore")]
        public async Task<IActionResult> AddPlayerScore(PlayerScore playerScore)
        {
            return Ok(await _playerServices.AddPlayerScore(playerScore));
        }
        [HttpGet("scores")]
        public async Task<IActionResult> GetPlayerScore()
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            return Ok(await _playerServices.GetPlayerScore(token));
        }
        [HttpGet]
        public async Task<IActionResult> GetQuestions()
        {
            return Ok(await _playerServices.GetQuestions());
        }

    }
}
