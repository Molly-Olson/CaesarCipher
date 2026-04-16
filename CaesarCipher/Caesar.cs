using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class Caesar
    {
        private const int shift = 12;
        public string ShiftForward(string message) => ShiftText(message, shift);
        public string ShiftBackward(string message) => ShiftText(message, (26 -  (shift % 26)));
        private static string ShiftText(string input, int shift)
        {
            if (input == null) return null;
            shift %= 26;
            var sb = new StringBuilder(input.Length);

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    char d = (char)('A' + (c - 'A' + shift) % 26);
                    sb.Append(d);
                }
                else if (char.IsLower(c))
                {
                    char d = (char)('a' + (c - 'a' + shift) % 26);
                    sb.Append(d);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
