using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Entities.Entities
{
	public class Question
	{

        public int QuestionId { get; set; }
        public int QuestionCategory { get; set; }
        public string? QuestionContent { get; set; }
    }
}
