using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizUApi.Models
{
    public class PlayerScore
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public string TokenLink { get; set; }
    }
}
