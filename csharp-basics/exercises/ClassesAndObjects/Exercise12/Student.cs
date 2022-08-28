using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Student : IStudent
    {
        private List<string> _testsTaken = new List<string>();

        public string PapersTaken() 
        {
            if (_testsTaken.Count == 0) 
            {
                return "No tests taken";
            }

            return string.Join(", ", _testsTaken);
        }

        public void TakeTest(ITestPaper paper, string[] answers) 
        {
            double questions = paper.MarkScheme.Length;
            double correctAnswers = 0;
            double score;
            string isPassed = "Failed";

            for (int i = 0; i < questions; i++) 
            {
                if (paper.MarkScheme[i] == answers[i]) 
                {
                    correctAnswers++;
                }
            }

            score = Math.Round((correctAnswers / questions) * 100 , 0);

            if (score >= Int32.Parse(paper.PassMark.Substring(0,2)))
            { 
                isPassed = "Passed";
            }

            _testsTaken.Add($"{paper.Subject}: {isPassed}! ({score}%)");
        }

        public List<string> TestsTaken => _testsTaken;
    }
}
