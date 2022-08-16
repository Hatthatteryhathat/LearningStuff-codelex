using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal interface ITestPaper
    {
        public string Subject { get; }

        public string[] MarkScheme { get; }

        public string PassMark { get; }

    }
}
