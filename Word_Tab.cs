using System;
using System.Linq;
using System.Windows.Forms;

namespace Aufgabe_07_OOP
{
    class WordTab
    {
        String[] Words = new String[1];
        public void AddWord(String word)
        {
            Array.Resize(ref Words, Words.Length + 1);
            for (int i = 0; i < Words.Length; i++)
            {
                if (Words[i] == null)
                {
                    Words[i] = word;
                    break;
                }
            }
        }
        public String GetTab()
        {
            String table = String.Format("{0,-20} {1,20}", "Wort", "Anzahl");
            var groups = Words.GroupBy(v => v);
            foreach (var group in groups)
            {
                table += Environment.NewLine;
                String line = String.Format("{0,-20} {1,20}", group.Key, group.Count());
                table += line;
            }
            return table;

        }
        public void PrintTab(String table, TextBox outputBox)
        {
            outputBox.Text = table;
        }

    }
}