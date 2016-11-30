using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS357Project
{
    class NFA
    {
        private string[]        sStates,        //states of the NFA
                                sFinal;         //End states
        private char[]          cLanguage;      //language
        private string[][][]    sTransitions;   //transition function
        private string          sStart;         //start state

        public void initStates(string newStates)
        {
            string[] statesTemp = new string[newStates.Length];
            int count = 0;

            for (int i = 0; 0 < newStates.Length; i++)
            {
                int tempIndex = newStates.IndexOf(',');
                string sub;
                if (tempIndex == -1)
                {
                    sub = newStates.Substring(0);
                    count++;
                    newStates = "";
                }
                else
                {
                    sub = newStates.Substring(0, tempIndex);
                    newStates = newStates.Substring(tempIndex + 1);
                    count++;
                }
                    statesTemp[i] = sub;
            }

            sStates = new string[count];

            for (int i=0; i < count; i++)
            {
                sStates[i] = statesTemp[i];
            }
        }

        public void initLanguage(string lang)
        {
            char [] tempLang              = new char[lang.Length];
            int count = 1;

            cLanguage[0]           = 'e';
            char[] tempCharArray   = lang.ToCharArray();

            for (int i=0, j=1; i < tempCharArray.Length; i++)
            {
                char temp = tempCharArray[i];
                if ((temp != ',') && (temp != ' '))
                {
                    cLanguage[j] = temp;
                    j++;
                    count++;
                }
            }

            cLanguage = new char[count];

            for (int i = 0; i < count; i++)
            {
                cLanguage[i] = tempLang[i];
            }
        }

        public void initTransitions(string transitions)
        {

        }

        public void initStartEnd(string start, string end)
        {
            sStart = start;

        }
    }
}
