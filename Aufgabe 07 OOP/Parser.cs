using System;


namespace Aufgabe_07_OOP
{
    class Parser
    {
        WordTab space;
        public Parser(WordTab wrdTab)
        {
            space = wrdTab;
        }
        public void Parse(String text)
        {
            if (text == "")
            {
                throw new Exception("TextBox is empty");
            }
            String word = "";
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].Equals(' '))
                {
                    if (word != "")
                    {
                        space.AddWord(word);
                        word = "";
                    }
                }
                else
                {
                    word += charArray[i];
                }
            }
            space.AddWord(word);
            Console.WriteLine(word);
        }
    }
}