using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {        
        public bool IsValid(string s)
        {
            //First validation
            if (s.Length % 2 != 0)
            {
                return false;
            }
            // Second
            if (s[0] == ')' || s[0] == '}' || s[0] == ']') 
            {
                return false;
            }

            string[] parenthesesTypes = new string[s.Length];
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {               
                bool openingParentheses = false;
                bool closingParentheses = false;
                bool openingSquareBracket = false;
                bool closingSquareBracket = false;
                bool openingBraces = false;
                bool closingBraces = false;

                switch (s[i])
                {
                    case '(':
                        openingParentheses = true;
                        break;
                    case ')':
                        closingParentheses = true;
                        break;
                    case '[':
                        openingSquareBracket = true;
                        break;
                    case ']':
                        closingSquareBracket = true;
                        break;
                    case '{':
                        openingBraces = true;
                        break;
                    case '}':
                        closingBraces = true;
                        break;
                    default:
                        break;
                }
                
                if (openingParentheses)
                {
                    parenthesesTypes[j] = "openingParentheses";
                    j++;
                }
                if (closingParentheses)
                {
                    if (j == 0)
                    {
                        return false;
                    }
                    if (parenthesesTypes[j-1] == "openingParentheses")
                    {
                       j--;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (openingSquareBracket)
                {
                    parenthesesTypes[j] = "openingSquareBracket";
                    j++;
                }
                if (closingSquareBracket)
                {
                    if (j == 0)
                    {
                        return false;
                    }
                    if (parenthesesTypes[j - 1] == "openingSquareBracket")
                    {
                        j--;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (openingBraces)
                {
                    parenthesesTypes[j] = "openingBraces";
                    j++;
                }
                if (closingBraces)
                {
                    if (j == 0)
                    {
                        return false;
                    }
                    if (parenthesesTypes[j - 1] == "openingBraces")
                    {
                        j--;
                    }
                    else
                    {
                        return false;
                    }                    
                }
            }
            if(j > 0)
            {
                return false;
            }
            return true;
        }

    }
}
