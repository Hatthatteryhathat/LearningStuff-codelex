using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Testpaper : ITestPaper
    {
        private string _subject;
        private string[] _markScheme;
        private string _passMark;

        public Testpaper(string subject, string[] markScheme, string passMark) 
        { 
            _subject = subject;
            _markScheme = markScheme;
            _passMark = passMark;
        }

        public string Subject => _subject;

        public string[] MarkScheme => _markScheme;

        public string PassMark => _passMark;
    }
}
