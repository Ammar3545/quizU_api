using QuizUApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizUApi.Services
{
    public interface IPlayerServices
    {
        Task<ServiceResponse<string>> LoginAndRegester(LoginAndRegisterPlayer loginAndRegisterPlayer);
        Task<ServiceResponse<string>> AddPlayerScore(PlayerScore playerScore);
        Task<ServiceResponse<List<int>>> GetPlayerScore(string token);
        Task<ServiceResponse<List<Question>>> GetQuestions();
    }
}
