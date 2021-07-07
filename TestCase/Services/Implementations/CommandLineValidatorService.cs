using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestCase.Services.Contracts;

namespace TestCase.Services.Implementations
{
    public class CommandLineValidatorService : IStringValidatorService
    {
        private Regex validString = new Regex(@"^\dx\d\s(\(\d,\s\d\)\s*)+$");
        public bool ValidateString(string str) => validString.IsMatch(str);
    }
}
