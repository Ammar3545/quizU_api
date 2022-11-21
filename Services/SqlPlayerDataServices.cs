using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuizUApi.Fixed;
using QuizUApi.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuizUApi.Services
{
    public class SqlPlayerDataServices : IPlayerServices
    {
        private PlayerContext _playerContext;
        private static IConfiguration _config;
        public SqlPlayerDataServices(PlayerContext playerContext, IConfiguration config)
        {
            _playerContext = playerContext;
            _config = config;
        }
        public async Task<ServiceResponse<string>> AddPlayerScore(PlayerScore playerScore)
        {
            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();
            playerScore.Id = Guid.NewGuid();
            _playerContext.PlayerScore.Add(playerScore);
            _playerContext.SaveChanges();
            serviceResponse.Data = "Successfully Added";
            serviceResponse.Message = "ok";
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<int>>> GetPlayerScore(string token)
        {
            ServiceResponse<List<int>> serviceResponse = new ServiceResponse<List<int>>();
            List<int> scoreList = new List<int>();
            var playerScoreObjectList = _playerContext.PlayerScore.Where(item => item.TokenLink == token).ToList();
            foreach (var item in playerScoreObjectList)
            {
                scoreList.Add(item.Score);
            }
            serviceResponse.Data = scoreList;
            serviceResponse.Message = "ok";
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Question>>> GetQuestions()
        {
            ServiceResponse<List<Question>> serviceResponse = new ServiceResponse<List<Question>>();
            serviceResponse.Data = StaticProperties.questions;
            serviceResponse.Message = "All Questions";
            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> LoginAndRegester(LoginAndRegisterPlayer loginAndRegisterPlayer)
        {
            var dbLoginRegPlayer = _playerContext.LoginAndRegisterPlayers;
            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();
            var player = dbLoginRegPlayer.FirstOrDefault(item => item.Email == loginAndRegisterPlayer.Email);
            if (player==null)
            {
                loginAndRegisterPlayer.Id = Guid.NewGuid();
                string token=GenerateToken(loginAndRegisterPlayer);
                loginAndRegisterPlayer.Token = token;
                _playerContext.LoginAndRegisterPlayers.Add(loginAndRegisterPlayer);
                serviceResponse.Data = loginAndRegisterPlayer.Token;
                serviceResponse.Message = "New Player";
                _playerContext.SaveChanges();
                return serviceResponse;
            }

            serviceResponse.Data = player.Token;
            serviceResponse.Message = "already Player";
            return serviceResponse;
            

        }
         string GenerateToken(LoginAndRegisterPlayer loginAndRegisterPlayer)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentail = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, loginAndRegisterPlayer.Name),
                new Claim(ClaimTypes.Email, loginAndRegisterPlayer.Email),
            };

            var token = new JwtSecurityToken
                (
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentail
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
