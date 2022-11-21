using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizUApi.Models
{
    public class Question
    {
        public string question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
    }
}
