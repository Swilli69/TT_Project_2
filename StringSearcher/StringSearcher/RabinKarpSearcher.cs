using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class RabinKarpSearcher
    {
        //the list remembers the positions within the text at which the pattern begins
        List<int> start_indexex;
        private int pattern_hash;
        private int text_hash;

        const int B = 257, M = 997;

        public RabinKarpSearcher()
        {
            start_indexex = new List<int>();
        }

        private int CalculateHash(String _string)
        {
            int b_to_power_m = 1;       // B^0
            int hash = _string[_string.Length - 1];     //_string[m-1] * B^0
                                                        //m = pattern.Length
            for (int i = 1; i < _string.Length; i++)
            {
                b_to_power_m = (b_to_power_m * B) % M;  //B^(i) % M
                int part_of_sum = (_string[_string.Length - i - 1] * b_to_power_m) % M;   //_string[m-i-1] * B^(i) % M
                hash = (hash + part_of_sum) % M;
            }
            return hash;
        }

        public List<int> Search(String pattern, String text)
        {
            if (text.Length < pattern.Length || pattern.Length == 0)
                return start_indexex;

            int b_to_power_m_mod_M = 1;                 //B^(m-1) % M - this value is the need to calculate each subsequent part of the text
                                                        //m = pattern.Length
            for (int i = 1; i < pattern.Length; i++)
                b_to_power_m_mod_M = (b_to_power_m_mod_M * B) % M;


            pattern_hash = CalculateHash(pattern);
            
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                if (i == 0)
                    text_hash = CalculateHash(text.Substring(0, pattern.Length));       //initially hes needs to be calculated for the first m characters of the text
                else
                {
                    int hash_subtract = positive_mod(text_hash - (text[i - 1] * b_to_power_m_mod_M) % M, M);     //subtract the weight it contributed from the old value of the hess 
                                                                                                                 //the letter that is no longer part of the substring being observed
                                                                                                                 //the result must be positive
                    text_hash = (hash_subtract * B % M + text[i - 1 + pattern.Length]) % M;             //by multiplying by B, the weight with which each letter participates rises by a degree higher
                }                                                                                       //the weight of the letter that last appeared within the substring is added

                if (pattern_hash == text_hash)
                {
                    if (CheckForMatch(pattern, text.Substring(i, pattern.Length)))          //additional verification is required, character by character
                        start_indexex.Add(i);
                }
            }
            return start_indexex;
        }

        private int positive_mod(int number, int mod)
        {
            return (number % mod + mod) % mod;
        }

        private bool CheckForMatch(String pattern, String part_of_text)
        {
            int index = 0;
            while ((index < pattern.Length) && (pattern[index] == part_of_text[index]))
                index++;

            if (index == pattern.Length)
                return true;
            else
                return false;
        }

        public void ClearIndexes()
        {
            start_indexex.Clear();
        }
    }
}
