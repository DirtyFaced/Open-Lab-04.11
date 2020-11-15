using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] chungus = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                int smrad = 0;
                for (int ii = 0; ii < str.Length; ii++)
                {
                    int first = (int)str[i];
                    int second = (int)str[ii];
                    if (first > second)
                    {
                        smrad = smrad + 1;
                    }
                }
                for (int iii = smrad; chungus[smrad] == str[i]; iii++)
                {
                    smrad = smrad + 1;   
                }
                chungus[smrad] = str[i];
            }
            string vysledok = new string(chungus);
            return vysledok;
        }
    }
}
