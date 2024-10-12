using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Entities.Entities
{
	public class Answer
	{
        public int AnswerId { get; set; }
        public required string AnswerContent { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }

    }
}
