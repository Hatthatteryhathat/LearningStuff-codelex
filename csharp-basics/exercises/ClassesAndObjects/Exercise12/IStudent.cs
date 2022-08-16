using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal interface IStudent
    {
        public List<string> TestsTaken { get; }

        public void TakeTest(ITestPaper paper, string[] answers);
    }
}
