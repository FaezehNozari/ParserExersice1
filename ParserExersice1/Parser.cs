using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserExersice1
{
    public class Parser
    {
        public static string[] ParseCharacter(string str, string seprator)
        {
            var result = seprator.Split(str);

            if (string.IsNullOrEmpty(str))
                return Array.Empty<string>();

            else if (string.IsNullOrEmpty(seprator))
                throw new Exception($" {nameof(seprator)} Is Not Empty or Null.");

            else
                return result;

        }
    }
}
