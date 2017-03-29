using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class stringReverse
    {
        public string reverseWords(string s)
        {
            // edge cases start
            Boolean containsLetters = false;
            for (int j = 0; j <= s.Length - 1; j++)
            {
                if ((s[j] != ' '))
                {
                    containsLetters = true;
                    break;
                }
            }
            if (containsLetters != true)
            {
                return "";
            }
            if (s.Length == 1)
            {
                return s;
            }

            // edge cases end

            StringBuilder stringdata = new StringBuilder();
            Boolean extraSpace = false;
            for (int j = 0; j <= s.Length - 1; j++)
            {
                if (s[j] != ' ')
                {
                    extraSpace = false;
                    stringdata.Append(s[j]);
                }
                else if (extraSpace == false)
                {
                    stringdata.Append(s[j]);
                    extraSpace = true;
                }
                else
                {
                    extraSpace = true;
                }
            }

            s = stringdata.ToString();
            int count = 0;
            Boolean seenLetter = false;
            String substring = "";
            StringBuilder answerbuild = new StringBuilder();
            int i = s.Length - 1;

            while (i >= 0)
            {
                if (s[i] == ' ' & i != s.Length - 1)
                {
                    substring += s.Substring(i + 1, count);
                    answerbuild.Append(substring);
                    substring = "";
                    count = 0;
                    seenLetter = false;
                    if (i != 0)
                    {
                        substring += " ";
                    }
                }
                else
                {
                    count += 1;
                    seenLetter = true;
                }
                i -= 1;
                if (i == -1)
                {
                    if (seenLetter)
                    {
                        substring += s.Substring(i + 1, count);
                        answerbuild.Append(substring);
                    }
                }
            }

            string answer = answerbuild.ToString();
            while (answer[answer.Length - 1] == ' ')
            {
                Console.WriteLine("Ends with space");
                answer = answer.Substring(0, answer.Length - 1);
            }
            while (answer[0] == ' ')
            {
                Console.WriteLine("Starts with space");
                answer = answer.Substring(1, answer.Length - 1);
            }
            StringBuilder answerdata = new StringBuilder();
            Boolean extraSpace2 = false;
            if (answer.Length == 1)
            {
                return answer;
            }
            for (int j = 0; j <= answer.Length - 1; j++)
            {
                if (answer[j] != ' ')
                {
                    extraSpace2 = false;
                    answerdata.Append(answer[j]);
                }
                else if (extraSpace2 == false)
                {
                    answerdata.Append(answer[j]);
                    extraSpace2 = true;
                }
                else
                {
                    extraSpace2 = true;
                }
            }

            answer = answerdata.ToString();

            return answer;
        }
    }
}
