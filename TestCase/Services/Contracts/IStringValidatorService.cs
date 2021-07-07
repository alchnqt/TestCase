using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Services.Contracts
{
    public interface IStringValidatorService
    {
        bool ValidateString(string str);
    }
}
